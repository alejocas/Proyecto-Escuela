using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient;
using Proyecto_Escuela.Models;

namespace Proyecto_Escuela.DAOS
{
    public class DAOSecuenciaImagen
    {
        public DAOSecuenciaImagen()
        {
        }

        public static int AgregarActividad(MySqlConnection conexion, SecuenciaImagenModel modelo)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO SecuenciaImagen (titulo, imagen1, imagen2, imagen3, imagen4, imagen5, imagen6, imagen7, imagen8) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", modelo.GetTitulo(), modelo.GetSecuencia()[0], modelo.GetSecuencia()[1], modelo.GetSecuencia()[2], modelo.GetSecuencia()[3], modelo.GetSecuencia()[4], modelo.GetSecuencia()[5], modelo.GetSecuencia()[6], modelo.GetSecuencia()[7]), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static int ModificarActividad(MySqlConnection conexion, SecuenciaImagenModel modelo)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE SecuenciaImagen set imagen1='{1}', imagen2='{2}', imagen3='{3}', imagen4='{4}', imagen5='{5}', imagen6='{6}', imagen7='{7}', imagen8='{8}' WHERE titulo='{0}'", modelo.GetTitulo(), modelo.GetSecuencia()[0], modelo.GetSecuencia()[1], modelo.GetSecuencia()[2], modelo.GetSecuencia()[3], modelo.GetSecuencia()[4], modelo.GetSecuencia()[5], modelo.GetSecuencia()[6], modelo.GetSecuencia()[7]), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static SecuenciaImagenModel ObtenerActividad(MySqlConnection conexion, string titulo)
        {
            SecuenciaImagenModel secuencia = new SecuenciaImagenModel();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM SecuenciaImagen WHERE titulo='{0}'", titulo), conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                string[] arreglo = new string[8];
                for (int i = 0; i < 8; i++)
                {
                    arreglo[i] = reader.GetString(i+1);
                    Console.WriteLine("Holi "+reader.GetString(i + 1));
                }
                secuencia.SetSecuencia(arreglo);
            }

            return secuencia;
        }        
    }
}
