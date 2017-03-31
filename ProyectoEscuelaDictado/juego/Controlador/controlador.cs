using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego.Controlador
{
    class controlador
    {
        private Form2 view;

        public controlador(Form2 view)
        {
            this.view = view;

        }

        public void mostrar()
        {
            this.view.Show();
        }

        public void cargarAtributos()
        {
            
        }




    }
}
