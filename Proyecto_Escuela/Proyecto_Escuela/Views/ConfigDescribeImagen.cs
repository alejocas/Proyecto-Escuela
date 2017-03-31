using Proyecto_Escuela.Controllers;
using Proyecto_Escuela.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Escuela.Views
{
    public partial class ConfigDescribeImagen : Form
    {
        ConfiguracionDescribeControler describeContrller;
        string ruta;
        DescribeImagenModel describeModel = new DescribeImagenModel();
        int indice = 0;
        Imagen image;
        bool modificacion = false;
        bool cambiar = false;

        public ConfigDescribeImagen(ConfiguracionDescribeControler controller)
        {
            InitializeComponent();
            this.describeContrller = controller;
            image = new Imagen();

        }


        private void campoImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImagen = new OpenFileDialog();
            PictureBox fotoEstudiante = new PictureBox();
            fotoEstudiante.Visible = false;
            fotoEstudiante.Enabled = false;
            getImagen.Filter = "Archivos de imagen (*.jpg)(*jpeg)|*.jpg;*.jpeg|PNG(*.png)|*.png|GIF(*.gif)|*.gif";
            if (getImagen.ShowDialog() == DialogResult.OK)
            {
                string a = "\\".Substring(0);
                campoImagen.Image = Image.FromFile(getImagen.FileName);
                ruta = getImagen.FileName.Replace(a, "\\\\");
            }
            else
            {
                MessageBox.Show("No selecciono ninguna Imagen", "Sin seleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            campoDescripcion.Text = describeModel.GetImagen(tabla.CurrentRow.Index).GetDescripcion();
            campoImagen.Image = Image.FromFile(describeModel.GetImagen(tabla.CurrentRow.Index).GetRuta());
            modificar.Enabled = false;
            modificacion = true;

        }
        private void agregar_Click(object sender, EventArgs e)
        {
            if (modificacion == true)
            {
                image.SetDescripcion(campoDescripcion.Text);
                image.SetRuta(ruta);
                tabla.CurrentRow.Cells[0].Value = image.GetDescripcion();
                tabla.CurrentRow.Cells[1].Value = Image.FromFile(image.GetRuta());
                describeModel.SetImagen(image, tabla.CurrentRow.Index);
                modificar.Enabled = true;
            }
            else
            {
                image = new Imagen();
                image.SetDescripcion(campoDescripcion.Text);
                image.SetRuta(ruta);
                tabla.Rows.Add(image.GetDescripcion(), Image.FromFile(image.GetRuta()));
                describeModel.AgregarImagen(image);
                indice = indice + 1;
            }
            campoImagen.Image = null;
            campoDescripcion.Clear();
            if (indice == 5)
            {
                agregar.Enabled = false;
                campoImagen.Enabled = false;
            }
            if (tabla.Rows.Count == 5)
            {
                botonAceptar.Enabled = true;
            }
        }

        private void ConfigDescribeImagen_Load(object sender, EventArgs e)
        {
            describeContrller.Buscar(titulo);
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            
            describeModel.SetTitulo(titulo.SelectedItem.ToString());
            if (cambiar == false)
            {
                describeContrller.Agregar(describeModel);

            }
            else
            {
                describeContrller.Editar(describeModel);
            }
        }

        private void titulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            describeContrller.Buscar(titulo);
            indice = tabla.Rows.Count;
            if (tabla.Rows.Count != 0)
            {
                cambiar = true;
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            new Configuracion().Show();
            this.Dispose();
        }
    }
}