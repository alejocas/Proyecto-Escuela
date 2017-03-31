using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Escuela.Controllers;
using Proyecto_Escuela.Models;

namespace Proyecto_Escuela.Views
{
    public partial class MenuActividades : Form
    {
        private DescribeImagenModel describeImagenModel = new DescribeImagenModel();
        private Jugador jugador;
        private SecuenciaController secuenciaController;
        private DescribeImagenController describeController;
        private ListaEstudianteController ListaController;
        private ListaTextosController listaTextos;

        public MenuActividades(string titulo, Jugador jugador, ListaEstudianteController controller, ListaTextosController listaTextos)
        {
            InitializeComponent();
            tituloLabel.Text = titulo;
            this.jugador = jugador;
            secuenciaController = new SecuenciaController(jugador, this);
            describeController = new DescribeImagenController(this,jugador);
            ListaController = controller;
            this.listaTextos = listaTextos;
        }

        //Getter y Setter de los componentes para su utilización
        public Label getLabel1()
        {
            return tituloLabel;
        }

        public void setLabel1(string titulo)
        {
            tituloLabel.Text = titulo; 
        }

        private void MenuActividades_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void JuegoTerminado(int i)
        {
            switch (i)
            {
                case 1:
                    describe.Enabled = false;
                    Comprobar();
                    describe.ForeColor = Color.Black;
                    break;
                case 2:                    
                    secuencia.Enabled = false;
                    secuencia.ForeColor = Color.Black;
                    Comprobar();
                    break;               
            }
        }

        private void describe_Click(object sender, EventArgs e)
        {            
            describeController.mostrar();
            this.Visible = false;
        }

        public string GetTitulo()
        {
            return tituloLabel.Text;
        }

        private void secuencia_Click(object sender, EventArgs e)
        {
            secuenciaController.mostrar();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListaController.Mostar();
            this.Visible = false;
        }
        private void Comprobar()
        {
            if (secuencia.Enabled == false && describe.Enabled == false)
            {
                volverTextos.Enabled = true;
                volverEstudiantes.Enabled = true;             
            }

        }

        private void volverTextos_Click(object sender, EventArgs e)
        {
            listaTextos.Mostar();
            this.Visible = false;
        }
    }
}
