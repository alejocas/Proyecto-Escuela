﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Proyecto_Escuela.Controllers;
using Proyecto_Escuela.Models;
using MySql.Data.MySqlClient;

namespace Proyecto_Escuela.Views
{
    public partial class ConfiguracionEstudiantes : Form
    {
        EstudianteController estudianteController = new EstudianteController();
        Estudiante estudiante = new Estudiante();
        Estudiante limpio = new Estudiante();
        public ConfiguracionEstudiantes()
        {
            InitializeComponent();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            estudiante.SetApellido(apellido.Text);
            estudiante.SetNombre(nombre.Text);
            estudiante.SetDocumento(documento.Text);
            estudiante.SetGrupo(grupo.Text);
            if (string.IsNullOrEmpty(documento.Text))
            {
                estudianteController.Buscar(estudiante, tabla, 0);
            }
            else
            {
                estudianteController.Buscar(estudiante, tabla, 1);
            }
        }

        private void guardar_Click(object sender, EventArgs e)
        {            
            estudiante.SetApellido(apellido.Text);
            estudiante.SetNombre(nombre.Text);
            estudiante.SetDocumento(documento.Text);
            estudiante.SetGrupo(grupo.Text);
            estudiante.SetGrado(grado.SelectedItem.ToString());

            if (documento.ReadOnly == false)
            {
                if (estudianteController.Agregar(estudiante) != 0)
                {
                    nombre.Clear();
                    apellido.Clear();
                    documento.Clear();
                    grupo.Clear();
                    grado.SelectedIndex = 0;                   
                    Listar();
                }
            }
            else
            {
                if (estudianteController.Editar(estudiante) != 0)
                {
                    nombre.Clear();
                    apellido.Clear();
                    documento.Clear();
                    grupo.Clear();
                    grado.SelectedIndex = 0;
                    Listar();
                    documento.ReadOnly = false;

                }
            }

           
        }

        private void ConfiguracionEstudiantes_Load(object sender, EventArgs e)
        {
            
            Listar();
                    
        }

        private void Listar()
        {
            estudianteController.Listar(tabla);
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            try
            {
                estudiante = estudianteController.Seleccionar(tabla);
                documento.Text = estudiante.GetDocumento().ToString();
                nombre.Text = estudiante.GetNombre();
                apellido.Text = estudiante.GetApellido();
                grupo.Text = estudiante.GetGrupo().ToString();
                asignarGrado(estudiante.GetGrado());
                documento.ReadOnly = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + " Debe seleccionar un registro.");
            }

}

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(documento.Text))
            {
                estudiante = estudianteController.Seleccionar(tabla);
                documento.Text = estudiante.GetDocumento().ToString();
                nombre.Text = estudiante.GetNombre();
                apellido.Text = estudiante.GetApellido();                
                grupo.Text = estudiante.GetGrupo().ToString();
                asignarGrado(estudiante.GetGrado());
            }
            else
            {
                DialogResult confirmar = MessageBox.Show("Se eliminará el estudiante con documento: " + documento.Text + " desea continuar?", "Alerta Eliminacion", MessageBoxButtons.YesNo);
                if(confirmar == DialogResult.Yes)
                {
                    if (estudianteController.Eliminar(int.Parse(documento.Text)) != 0)
                    {
                        nombre.Clear();
                        apellido.Clear();
                        documento.Clear();
                        grupo.Clear();
                        grado.SelectedIndex = 0;

                        Listar();
                    }
                }
                else
                {
                    MessageBox.Show("Eliminacion cancelada");
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            nombre.Clear();
            apellido.Clear();
            documento.Clear();
            grupo.Clear();
            Listar();
            grado.SelectedIndex = 0;
            documento.ReadOnly = false;
        }

        private void asignarGrado(string grado)
        {
            switch (grado)
            {
                case "Primero":
                    this.grado.SelectedIndex = 1;
                    break;
                case "Segundo":
                    this.grado.SelectedIndex = 2;

                    break;
                case "Tercero":
                    this.grado.SelectedIndex = 3;
                    break;
            }
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            new Configuracion().Show();
            this.Dispose();
        }

        private void foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImagen = new OpenFileDialog();
            PictureBox fotoEstudiante = new PictureBox();
            fotoEstudiante.Visible = false;
            fotoEstudiante.Enabled = false;
            getImagen.Filter = "Archivos de imagen (*.jpg)(*jpeg)|*.jpg;*.jpeg|PNG(*.png)|*.png|GIF(*.gif)|*.gif";
            if (getImagen.ShowDialog() == DialogResult.OK)
            {
                string a = "\\".Substring(0);
                Console.WriteLine(a);
                foto.Image = Image.FromFile(getImagen.FileName);
                string aux = getImagen.FileName.Replace(a, "\\\\");
                estudiante.SetFoto(aux);
            }
            else
            {
                MessageBox.Show("No selecciono ninguna Imagen", "Sin seleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}