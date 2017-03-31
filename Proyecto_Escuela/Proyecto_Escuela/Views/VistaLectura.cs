using Proyecto_Escuela.Controllers;
using Proyecto_Escuela.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Escuela
{
    public partial class VistaLectura : Form
    {
        //Atrubuto tiempo, necesario para contar cuánto se demora el estudiante en leer el texto
        private int tiempo;
        private string titulo;
        private MenuActividadesController menuActividades;
        private Jugador jugador;
        private ListaEstudianteController lista;
        private ListaTextosController textos;
        //Constructor
        public VistaLectura(Texto texto, Jugador jugador, ListaEstudianteController lista, ListaTextosController textos)
        {
            InitializeComponent();
            this.lista = lista;
            this.jugador = jugador;
            this.titulo = texto.getTitulo();
            this.tiempo = texto.getTiempo();
            this.labelNombre.Text = jugador.GetNombre() + " " + jugador.GetApellido();
            campoTexto.Text = texto.getTexto();
            labelTiempo.Text = "Tiempo: " + texto.getTiempo().ToString();            
            timer1.Start();
            tituloLabel.Text = titulo;
        }

        #region Método de Timer
        //Método que controla el tiempo de lectura del texto
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tiempo > 0)
            {
                tiempo = tiempo - 1;
                labelTiempo.Text = "Tiempo: " + tiempo;
            }
            else
            {
                timer1.Stop();
                if (MessageBox.Show("¡Se agotó el tiempo!\n¿Deseas más tiempo para terminar la lectura?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    tiempo = 30;
                    timer1.Start();
                }
                else
                {
                    Application.Exit();
                    //this.Dispose();
                }
            }
        }
        #endregion

        private void jugar_Click(object sender, EventArgs e)
        {
            menuActividades = new MenuActividadesController(titulo, jugador, lista, textos);
            this.Dispose();
        }
    }
}
