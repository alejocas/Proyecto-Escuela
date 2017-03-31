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
    public partial class ListaEstudiantes : Form
    {
        ListaEstudianteController listaEstudianteController;
        List<List<Estudiante>> filasEstudiantes;
        public ListaEstudiantes(ListaEstudianteController listaEstudianteController)
        {
            this.listaEstudianteController = listaEstudianteController;
            InitializeComponent();

        }      
        private void ListaEstudiantes_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void Listar()
        {
            filasEstudiantes = listaEstudianteController.Listar(tabla);
        }

        private void tablaPrimero_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Jugador play = new Jugador();
            play = listaEstudianteController.retornarEstudiante(tabla, filasEstudiantes);
            Console.WriteLine(play.GetApellido());
            ListaTextosController ListaTextos = new ListaTextosController(play, listaEstudianteController);
            this.Visible = false;
        }

        private void ListaEstudiantes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
