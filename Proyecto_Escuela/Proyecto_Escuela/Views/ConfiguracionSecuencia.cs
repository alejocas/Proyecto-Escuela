using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Escuela.Models;
using Proyecto_Escuela.Controllers;
using System.IO;

namespace Proyecto_Escuela.Views
{
    public partial class ConfiguracionSecuencia : Form
    {
        ConfiguracionSecuenciaController secuenciaController;
        bool modificar = false;
        public ConfiguracionSecuencia(ConfiguracionSecuenciaController controller)
        {
            InitializeComponent();
            secuenciaController = controller;            
        }

        private void btnCarpeta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog escanerDeCarpeta = new FolderBrowserDialog();
            DialogResult res = escanerDeCarpeta.ShowDialog();
            if(res == DialogResult.OK)
            {
                txtRutaCarpeta.Text = escanerDeCarpeta.SelectedPath;
            }
            tabla.Enabled = true;
            //Aquí estan las rutas de las imagenes en un arreglo de STRINGS
            string[] imagenes = Directory.GetFiles(txtRutaCarpeta.Text, "*.png");
            for(int i = 0; i < imagenes.Length; i++)
            {
                tabla.Rows.Add(0, imagenes[i], Image.FromFile(imagenes[i]));
            }
        }

        private void gridSecuencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrden.Text = tabla.CurrentRow.Cells[0].Value.ToString();
        }

        private void ConfiguracionSecuencia_Load(object sender, EventArgs e)
        {
            secuenciaController.BuscarTextos(titulo);
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            tabla.CurrentRow.Cells[0].Value = txtOrden.Text;
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            tabla.Rows.Remove(tabla.CurrentRow);
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {

            SecuenciaImagenModel modelo = new SecuenciaImagenModel();
            modelo.SetTitulo(titulo.SelectedItem.ToString());
            modelo.SetSecuencia(convertirArreglo());
            if (tabla.Rows.Count == 8)
            {
                if (modificar == true)
                {
                    
                    secuenciaController.Editar(modelo);
                }
                else
                {
                    secuenciaController.Agregar(modelo);
                }
            }
        }

        private void titulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            secuenciaController.ListarImagenes(tabla, titulo.SelectedItem.ToString());
            if (tabla.Rows.Count != 0)
            {
                modificar = true;
            }
            else
            {
                modificar = false;
            }
        }

        private string[] convertirArreglo()
        {
            string a = "\\".Substring(0);            
            string[] arreglo = new string[8];
            for (int i = 0; i < 8; i++)
            {
                arreglo[int.Parse(tabla.Rows[i].Cells[0].Value.ToString())] = tabla.Rows[i].Cells[1].Value.ToString().Replace(a, "\\\\");
            }
            return arreglo;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            new Configuracion().Show();
            this.Dispose();
        }
    }
}
