using Proyecto_Escuela.Models;
using Proyecto_Escuela.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Escuela.Controllers
{
    public class ListaTextosController
    {
        ListaTextos listaTexto;

        public ListaTextosController(Jugador jugador, ListaEstudianteController lista)
        {
            listaTexto = new ListaTextos(jugador, lista, this);
            listaTexto.Show();
        }

        public void Mostar()
        {
            listaTexto.Visible = true;
        }

        
    }
}
