using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Escuela.Views;
using Proyecto_Escuela.Controllers;
using Proyecto_Escuela.Models;

namespace Proyecto_Escuela.Controllers
{
    public class MenuActividadesController
    {        
        MenuActividades menu;
                
        public MenuActividadesController(string titulo, Jugador jugador, ListaEstudianteController lista, ListaTextosController textos)
        {
            menu = new MenuActividades(titulo, jugador, lista, textos);            
            menu.Show();            
        }
        
    }

    
}
