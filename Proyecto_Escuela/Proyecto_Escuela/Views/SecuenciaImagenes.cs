using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Proyecto_Escuela.Models;
using Proyecto_Escuela.Controllers;

namespace Proyecto_Escuela.Views
{
    public partial class SecuenciaImagenes : Form
    {
        #region Constantes
        public const int maxAnchuraDelGrid = 4;
        public const int maxAlturaDelGrid = 2;
        public const int anchoImagen = 140;
        public const int altoImagen = 120;
        public const int bordeEnGrid = 60;
        #endregion

        private smTile[] grid;
        private smTile[] encaje;
        private SecuenciaController tc;
        private string[] ordenCorrecto;
        private bool ansiado = false;
        private Jugador jugador;
        private int errores = 0;
        private MenuActividades menu;

        #region Empty constructor
        /// <summary>
        /// Empty constructor
        /// </summary>
        public SecuenciaImagenes(Jugador nino, SecuenciaController controller, SecuenciaImagenModel model, MenuActividades menu)
        {
            if (model.GetSecuencia().Count() == 0)
            {
                MessageBox.Show("No hay actividad");
                this.Dispose();
            }
            
            InitializeComponent();
            this.menu = menu;
            this.jugador = nino;
            this.tc = controller;
            this.BackColor = Color.Chocolate;
            this.lblNombre.Text = nino.GetNombre() + " " + nino.GetApellido();
            int xSpot;
            int ySpot;
            int pp;
            string[] imagenes = model.GetSecuencia();
            int numImagenes = imagenes.Count();
            ordenCorrecto = model.GetSecuencia();
            Random rnd = new Random();
            bool[] imgUsada = new bool[numImagenes];
            // Initialize the grid
            grid = new smTile[numImagenes];

            // Initialize each tile in the grid
            for (int row = 0; row < numImagenes; row++)
            {
                try
                {
                    pp = rnd.Next() % numImagenes;
                    while (imgUsada[pp])
                    {
                        pp = rnd.Next() % numImagenes;
                    }

                    // Create the tile
                    grid[row] = new smTile(imagenes[pp]);
                    grid[row].PutItem(grid[row].FilledImage);
                    imgUsada[pp] = true;

                    // Set the location for the tile
                    if (row < 4)
                    {
                        xSpot = (row * anchoImagen) + bordeEnGrid;
                        ySpot = bordeEnGrid;
                        grid[row].Location = new Point(xSpot, ySpot);
                    }
                    else
                    {
                        xSpot = ((row - 4) * anchoImagen) + bordeEnGrid;
                        ySpot = altoImagen + bordeEnGrid + 30;
                        grid[row].Location = new Point(xSpot, ySpot);
                    }

                    // Add the tile to the form
                    this.Controls.Add(grid[row]);


                }
                catch
                {
                    // Just catch an exception, no error handling yet
                    Console.WriteLine("Exception caught for tile[{0}]", row);
                }
            }

            encaje = new smTile[numImagenes];

            for (int i = 0; i < numImagenes; i++)
            {
                try
                {
                    encaje[i] = new smTile();
                    // Set the location for the tile
                    if (i < 4)
                    {
                        xSpot = (i * anchoImagen) + bordeEnGrid;
                        ySpot = 3 * altoImagen;
                        encaje[i].Location = new Point(xSpot, ySpot);
                    }
                    else
                    {
                        xSpot = ((i - 4) * anchoImagen) + bordeEnGrid;
                        ySpot = 4 * altoImagen + bordeEnGrid;
                        encaje[i].Location = new Point(xSpot, ySpot);
                    }
                    this.Controls.Add(encaje[i]);
                }
                catch
                {
                    Console.WriteLine("Error en: {0}", i);
                }
            }
        }
        #endregion      

        private void btnComprobacion_Click(object sender, EventArgs e)
        {                       
            ansiado = tc.Comprobar(encaje, ordenCorrecto);
            if (ansiado)
            {
                jugador.GetDesempeño()[1].SetDesempeño(1, errores);
                MessageBox.Show("Felicidades :D","Felicitaciones");
                btnComprobacion.Enabled = false;
                menu.JuegoTerminado(2);
                
            }
            else
            {
                errores++;
                MessageBox.Show("Sigue intentando, vas para el intento #" + errores,"Felicitaciones");
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buen día querido jugador/a, para jugar debes arrastrar las imágenes\ny colocarlas en el orden correcto, buena suerte.");
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            menu.Visible = true;
            jugador.GetDesempeño()[1].SetDesempeño(1, errores);
        }
    }
}