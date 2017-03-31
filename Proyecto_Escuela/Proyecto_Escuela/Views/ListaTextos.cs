using Proyecto_Escuela.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Escuela.Controllers;

namespace Proyecto_Escuela.Views
{
    public partial class ListaTextos : Form
    {
        private TextoController textoController = new TextoController();
        private Texto texto = new Texto();
        private Jugador jugador;
        private ListaEstudianteController lista;
        private ListaTextosController textos;

        public ListaTextos(Jugador jugador, ListaEstudianteController lista, ListaTextosController textos)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.jugador = jugador;
            this.lista = lista;
            this.textos = textos;
        }

        //Getter para usar el DataGrid en el controller
        public DataGridView getLista()
        {
            return tabla;
        }

        //Características del DataGrid cuando carga la ventana
        private void ListaTextos_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void Listar()
        {
            textoController.Listar(tabla, 1);
        }

       

        private void tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            texto = textoController.Seleccionar(tabla);
            new LecturaController(texto,jugador, lista, textos);
            tabla.CurrentRow.Visible = false;
            this.Visible = false;

        }

        private void volver_Click(object sender, EventArgs e)
        {
            ListaEstudianteController estudiantes = new ListaEstudianteController();
            this.Visible=false;
        }
    }
}
