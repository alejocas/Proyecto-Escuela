using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Escuela.Views;
using System.Windows.Forms;
using Proyecto_Escuela.DAOS;
using MySql.Data.MySqlClient;
using System.Drawing;
using Proyecto_Escuela.Models;

namespace Proyecto_Escuela.Controllers
{
    public class ListaEstudianteController
    {
        ConexionDB conexion = new ConexionDB();           
        ListaEstudiantes listaEstudiantes;

        public ListaEstudianteController()
        {
            listaEstudiantes = new ListaEstudiantes(this);
            listaEstudiantes.Show();

        }
        public List<List<Estudiante>> Listar(DataGridView tabla)
        {
            try
            {
                if (conexion.AbrirConexion() == true)
                {
                    IList<Estudiante> lista = DAOS.DAOEstudiante.ListarEstudiantes(conexion.GetConexion());
                    List<List<Estudiante>> filas = new List<List<Estudiante>>();
                    for (int i = 0; i < lista.Count; i += 4)
                    {
                        List<Estudiante> estudiantes = new List<Estudiante>();
                        for (int j = 0; j < 4; j++)
                        {
                            Estudiante estudiante = new Estudiante();
                            try
                            {
                                estudiante = lista[i + j];
                                estudiantes.Add(estudiante);
                            }
                            catch
                            {
                            }
                        }
                        filas.Add(estudiantes);


                    }
                    tabla.Rows.Clear();
                    for (int i = 0; i < filas.Count; i++)
                    {
                        switch (filas[i].Count)
                        {
                            case 1:

                                tabla.Rows.Add(Image.FromFile(filas[i][0].GetFoto()));
                                break;
                            case 2:
                                tabla.Rows.Add(Image.FromFile(filas[i][0].GetFoto()), Image.FromFile(filas[i][1].GetFoto()));

                                break;
                            case 3:
                                tabla.Rows.Add(Image.FromFile(filas[i][0].GetFoto()), Image.FromFile(filas[i][1].GetFoto()), Image.FromFile(filas[i][2].GetFoto()));

                                break;
                            case 4:
                                tabla.Rows.Add(Image.FromFile(filas[i][0].GetFoto()), Image.FromFile(filas[i][1].GetFoto()), Image.FromFile(filas[i][2].GetFoto()), Image.FromFile(filas[i][3].GetFoto()));
                                break;
                        }
                    }
                    return filas;
                }
                return null;
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                conexion.CerrarConexion();
                return null;
            }
        }

        public Jugador retornarEstudiante(DataGridView tabla, List<List<Estudiante>> lista)
        {
            int row = tabla.CurrentCell.RowIndex;
            int col = tabla.CurrentCell.ColumnIndex;
            Jugador men = new Jugador();
            men.SetNombre(lista[row][col].GetNombre());
            men.SetApellido(lista[row][col].GetApellido());
            men.SetDocumento(lista[row][col].GetDocumento().ToString());
            men.SetFoto(lista[row][col].GetFoto());
            men.SetGrado(lista[row][col].GetGrado());
            men.SetGrupo(lista[row][col].GetGrupo().ToString());
            return men;
        }

        public void Mostar()
        {
            listaEstudiantes.Visible = true;
        }

    }

}
