using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ColoreaPalabras
{

    public partial class modText : Form
    {
        string texto, keyword;
           // char c;
        public modText()
        {
            InitializeComponent();
        }

        private void modText_Load(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)//BOTON OK PARA CARGAR DATOS
        {
            texto = TextArea.Text;
            string patron = @"[\+\-\¿\!\¡\;\,\:\.\?\#\@\(\)]";
           // string patron = @"[^\w]";
            Regex regex = new Regex(patron);
            texto= regex.Replace(texto, "");
            keyword = palabraIngresada.Text;
            coloreaPalabras frm = new coloreaPalabras();
            frm.creaPalabra(texto, keyword);
            frm.Show();
            TextArea.Text = "";
            palabraIngresada.Text = "";
            this.Close();
        }

        
    }
}
