using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace relacionar
{
    public partial class modcols : Form
    {
        public modcols()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            parejas frm = new relacionar.parejas();
            string[] col = new string[8];//Almacena las palabras
            string[] pair = new string[4];//alamcena parejas
            col[0] = textCol1.Text;
            col[1] = textCol2.Text;
            col[2] = textCol3.Text;
            col[3] = textCol4.Text;
            col[4] = textCol5.Text;
            col[5] = textCol6.Text;
            col[6] = textCol7.Text;
            col[7] = textCol8.Text;
            //A uno posición le corresponde el primer elemento de la otra columna. etc...
            pair[0] = "1" + derecha1.Text;//Lo usamos para saber relaciones
            pair[1] = "2" + derecha2.Text;//Lo usamos para saber relaciones
            pair[2] = "3" + derecha3.Text;//Lo usamos para saber relaciones
            pair[3] = "4" + derecha4.Text;//Lo usamos para saber relaciones
            frm.muestraPalabra(col,pair);
            frm.Show();
            textCol1.Text= "";
            textCol2.Text = "";
            textCol3.Text = "";
            textCol4.Text = "";
            textCol5.Text = "";
            textCol6.Text = "";
            textCol7.Text = "";
            textCol8.Text = "";
            derecha1.Text = "";
            derecha2.Text = "";
            derecha3.Text = "";
            derecha4.Text = "";
            this.Close();
        }
    }
}
