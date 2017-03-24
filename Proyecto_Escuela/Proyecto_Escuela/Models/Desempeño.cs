﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Escuela.Models
{
    public class Desempeño
    {
        private int aciertos=0;
        private int errores=0;

        public Desempeño()
        {
        }

        public Desempeño(int aciertos, int erroes)
        {
            this.aciertos = aciertos;
            this.errores = erroes;
        }

        public int GetAciertos()
        {
            return aciertos;
        }
        public int GetErrores()
        {
            return errores;
        }
        public void SumarAcierto()
        {
            aciertos++;
        }
        public void SumarError()
        {
            errores++;
        }
    }
}
