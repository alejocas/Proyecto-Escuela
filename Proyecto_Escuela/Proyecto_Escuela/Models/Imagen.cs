﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Proyecto_Escuela.Models
{
    public class Imagen: PictureBox
    {
        private int posicion;
        private string descripcion;
        private string ruta="";

        public Imagen()
        {           
        }        
        public int GetPosicion()
        {
            return posicion;
        }
        public string GetDescripcion()
        {
            return descripcion;
        }
        public Image GetImagen()
        {
            return BackgroundImage;
        }
        public string GetRuta()
        {
            return ruta;
        }
       
        public void SetDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }
        public void SetImagen(Image imagen)
        {
            this.BackgroundImage = imagen;
        }
        public void SetPosicion(int i)
        {
            this.posicion = i;
        }
        public void SetRuta(string path)
        {
            this.ruta = path;
        }
        
    }
}
