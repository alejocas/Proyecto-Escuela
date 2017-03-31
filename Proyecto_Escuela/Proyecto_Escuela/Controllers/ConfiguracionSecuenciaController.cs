using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Escuela.Models;
using Proyecto_Escuela.DAOS;
using Proyecto_Escuela.Views;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace Proyecto_Escuela.Controllers
{
    public class ConfiguracionSecuenciaController
    {
        ConexionDB conexion = new ConexionDB();
        ConfiguracionSecuencia configuracionSecuencia;
        public ConfiguracionSecuenciaController()
        {
            configuracionSecuencia = new ConfiguracionSecuencia(this);
            configuracionSecuencia.Show();
        }
        public int Agregar(SecuenciaImagenModel model)
        {
            try
            {
                if (conexion.AbrirConexion() == true)
                {
                    int resultado;
                    resultado = DAOS.DAOSecuenciaImagen.AgregarActividad(conexion.GetConexion(), model);
                    conexion.CerrarConexion();
                    return resultado;
                }
                conexion.CerrarConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                conexion.CerrarConexion();
            }
            return 0;
        }

        public void BuscarTextos(ComboBox combo)
        {
            try
            {
                if (conexion.AbrirConexion() == true)
                {
                    IList<Texto> lista = DAOTexto.ListarTextos(conexion.GetConexion());

                    for (int i = 0; i < lista.Count; i++)
                    {
                        combo.Items.Add(lista[i].getTitulo());
                    }
                    conexion.CerrarConexion();

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                conexion.CerrarConexion();
            }

        }



        public int Editar(SecuenciaImagenModel modelo)
        {
            try
            {

                if (conexion.AbrirConexion() == true)
                {
                    int resultado;
                    resultado = DAOS.DAOSecuenciaImagen.ModificarActividad(conexion.GetConexion(), modelo);
                    conexion.CerrarConexion();
                    return resultado;
                }
                conexion.CerrarConexion();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                conexion.CerrarConexion();
            }
            return 0;
        }

        public void ListarImagenes(DataGridView tabla, string titulo)
        {
            try
            {
                if (conexion.AbrirConexion() == true)
                {
                    SecuenciaImagenModel lista = DAOS.DAOSecuenciaImagen.ObtenerActividad(conexion.GetConexion(), titulo);
                    tabla.Rows.Clear();
                    for (int i = 0; i < lista.GetSecuencia().Length; i++)
                    {
                        if (lista.GetSecuencia()[i] != null)
                        {
                            tabla.Rows.Add(i, lista.GetSecuencia()[i], Image.FromFile(lista.GetSecuencia()[i]));
                        }
                    }
                    conexion.CerrarConexion();

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                conexion.CerrarConexion();
            }
        }
    }
}
