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
    public class LecturaController{
        private VistaLectura vistaTexto;
        

        public LecturaController(Texto texto, Jugador jugador, ListaEstudianteController lista, ListaTextosController textos)
        {
            vistaTexto = new VistaLectura(texto, jugador, lista, textos);
            vistaTexto.Show(); 
        }
    }
}
