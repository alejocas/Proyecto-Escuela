using Proyecto_Escuela.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using Proyecto_Escuela.Views;
using Proyecto_Escuela.DAOS;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace Proyecto_Escuela.Controllers
{
    public class DescribeImagenController
    {
        DescripcionImagen vista;
        DescribeImagenModel describeImagenModel;
        ConexionDB conexion = new ConexionDB();
        string titulo;

        public DescribeImagenController(MenuActividades menu, Jugador jugador)
        {
            titulo = menu.GetTitulo();
            describeImagenModel= new DescribeImagenModel();
            ListarImagenes();
            AsignarImagenes(describeImagenModel.GetImagenes());
            vista = new DescripcionImagen(this, describeImagenModel, menu, jugador);

        }
        public bool compararRespuesta(int i, string respuesta)
        {
            string texto1 = describeImagenModel.GetImagen(i).GetDescripcion();
            string texto2 = respuesta;
            return compararTextos(texto1, texto2);
        }

        private bool compararTextos(string texto1, string texto2)
        {
            if (texto1.Equals(texto2))
            {
                return true;
            }
            return false;
        }

        private void ListarImagenes()
        {
            try
            {
                if (conexion.AbrirConexion() == true)
                {
                    describeImagenModel = DAODescribeImagen.ObtenerActividad(conexion.GetConexion(), titulo);
                    conexion.CerrarConexion();
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        public void AsignarImagenes(List<Imagen> lista)
        {
            for(int i =0; i < lista.Count; i++)
            {
               Imagen.SetPicture(lista[i]);
            }
        }

        public void mostrar()
        {
            vista.Visible = true;
        }

        public void ocultar()
        {
            vista.Visible = false;
        }

    }    
}
