using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Proyecto_Escuela.Models;
using Proyecto_Escuela.Controllers;
using System.IO;


namespace Proyecto_Escuela.DAOS
{
    public class DAOTexto
    {
        public DAOTexto()
        {
        }
        public static int AgregarTexto(MySqlConnection conexion, Texto texto)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO Cuento (titulo, texto, tiempo, imagen) VALUES('{0}', '{1}', '{2}', '{3}')", texto.getTitulo(), texto.getTexto(), texto.getTiempo(), texto.getImage()), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int EliminarTexto(MySqlConnection conexion, string titulo)
        {
            int retorno = 0;
            
            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM SecuenciaImagen WHERE titulo='{0}'", titulo), conexion);
            retorno = comando.ExecuteNonQuery();
            comando = new MySqlCommand(string.Format("DELETE FROM DescribeImagen WHERE titulo='{0}'", titulo), conexion);
            retorno = comando.ExecuteNonQuery();
            comando = new MySqlCommand(string.Format("DELETE FROM Cuento WHERE titulo='{0}'", titulo), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static IList<Texto> BuscarTexto(MySqlConnection conexion, string titulo)
        {
            List<Texto> lista = new List<Texto>();

            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM Cuento WHERE titulo LIKE ('%{0}%')", titulo), conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Texto cuento = new Texto();
                cuento.setTitulo(reader.GetString(0));
                cuento.setTexto(reader.GetString(1));
                cuento.setTiempo(reader.GetInt32(2));
                cuento.setImagen(reader.GetString(3));
                lista.Add(cuento);
            }


            return lista;
        }

        public static int ModificarTexto(MySqlConnection conexion, Texto texto)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE Cuento set texto='{1}', tiempo='{2}' WHERE titulo='{0}'", texto.getTitulo(), texto.getTexto(), texto.getTiempo()), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static IList<Texto> ListarTextos(MySqlConnection conexion)
        {
            List<Texto> lista = new List<Texto>();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM Cuento", conexion);
            MySqlDataReader reader = comando.ExecuteReader();



            while (reader.Read())
            {
                Texto cuento = new Texto();
                cuento.setTitulo(reader.GetString(0));
                cuento.setTexto(reader.GetString(1));
                cuento.setTiempo(reader.GetInt32(2));
                cuento.setImagen(reader.GetString(3));

                lista.Add(cuento);
            }


            return lista;
        }


        public static Texto ObtenerTexto(MySqlConnection conexion, string titulo)
        {
            Texto cuento = new Texto();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT *FROM Cuento WHERE titulo='{0}'", titulo), conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {                
                cuento.setTitulo(reader.GetString(0));
                cuento.setTexto(reader.GetString(1));
                cuento.setTiempo(reader.GetInt32(2));
                cuento.setImagen(reader.GetString(3));

            }
            return cuento;            
        }
        


    }
}
