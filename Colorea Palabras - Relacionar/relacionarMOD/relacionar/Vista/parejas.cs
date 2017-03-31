
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace relacionar
{
    public partial class parejas : Form
    {
        int X1=0, Y1=0,X2=0,Y2=0;
        bool izq=false, dcha=false;
        int numParejas = 0;//Numero de parejas seleccionadas hasta el momento
        int[] evaluaBotones= {0,0,0,0,0,0,0,0};//Evaluador para evitar errores con los botones
        string[] evaluaRelacion;//Lo usamos para validar la relacion real
        string[] relacionActual = new string[4];//Evaluar relaciones hechas en ejecucion
        int posActual;//Inidicamos posicion actual donde llevaremos información al vector
        string botonActual;//Lo usamos para saber que boton se clickeo


        int aciertos = 0;//Variable que guarda resultados acertados
        int fallos = 0;//Variable que guarda resultados fallidos

        public parejas()
        {
            InitializeComponent();       
            desactiveIzq();//Al principio todo esta desactivado
            desactiveDcha();//Al principio todo esta desactivado
        }

        private void btnizq1_Click(object sender, EventArgs e)
        {
            Point position = PointToClient(Cursor.Position);
             X1 = position.X;
             Y1 = position.Y;
            desactiveIzq();//Controlamos que oprima un boton por lado a la vez
            activeDcha();//Controlamos que oprima un boton por lado a la vez
            evaluaBotones[0] = 1;
            botonActual = "1";
            posActual = 0;//Inidicamos posicion actual donde llevaremos información al vector
            izq = true;//Auxiliar para saber cuando le dimos click a la izquierda
            btnizq1.Enabled = false;
        }       

        private void btnizq2_Click(object sender, EventArgs e)
        {
            Point position = PointToClient(Cursor.Position);
            X1 = position.X;
            Y1 = position.Y;
            botonActual = "2";
            posActual = 1;//Inidicamos posicion actual donde llevaremos información al vector
            desactiveIzq();//Controlamos que oprima un boton por lado a la vez
            activeDcha();//Controlamos que oprima un boton por lado a la vez
            evaluaBotones[1] = 1;
            izq = true;//Auxiliar para saber cuando le dimos click a la izquierda
            btnizq2.Enabled = false;
        }

        private void btnizq3_Click(object sender, EventArgs e)
        {
            Point position = PointToClient(Cursor.Position);
            X1 = position.X;
            Y1 = position.Y;
            desactiveIzq();//Controlamos que oprima un boton por lado a la vez
            activeDcha();//Controlamos que oprima un boton por lado a la vez
            evaluaBotones[2] = 1;
            botonActual = "3";
            posActual = 2;//Inidicamos posicion actual donde llevaremos información al vector
            izq = true;//Auxiliar para saber cuando le dimos click a la izquierda
            btnizq3.Enabled = false;
        }

        private void btnizq4_Click(object sender, EventArgs e)
        {
            Point position = PointToClient(Cursor.Position);
            X1 = position.X;
            Y1 = position.Y;
            desactiveIzq();//Controlamos que oprima un boton por lado a la vez
            activeDcha();//Controlamos que oprima un boton por lado a la vez
            evaluaBotones[3] = 1;
            botonActual = "4";
            posActual = 3;//Inidicamos posicion actual donde llevaremos información al vector
            izq = true;//Auxiliar para saber cuando le dimos click a la izquierda
            btnizq4.Enabled = false;
        }

        private void dibujaLinea()//Método para dibujar las líneas
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Blue, 3);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();

            if (izq && dcha)
            {
                formGraphics.DrawLine(myPen, X1, Y1, X2, Y2);
                if (numParejas == 4)
                {
                    aciertos = aciertos + 1;
                    if (comparaRelacion()) { MessageBox.Show("Muy bien has acertado todas las relaciones"); aciertos = aciertos + 1; }//Mensaje de acierto y contabilizamos aciertos
                    else { MessageBox.Show("Lo siento has fallado"); fallos = fallos + 1; }//Mensaje de fallo y contabilizamos fallos
                    Thread.Sleep(1000);
                    DialogResult boton = MessageBox.Show("¿DESEAS VOLVER A JUGAR?", "Alerta", MessageBoxButtons.OKCancel);
                    if (boton == DialogResult.OK)
                    {
                        for(int i = 0; i < 8; i++)
                        {
                            evaluaBotones[i] = 0;//Reiniciamos auxiliar de reinicio
                        }
                        activeIzq();
                        activeDcha();
                        formGraphics.Clear(Color.WhiteSmoke);
                        numParejas = 0;//Reiniciamos variables
                    }
                    else
                    {
                        this.Close();
                        //Volver al menu ppal
                    }
                    myPen.Dispose();
                    formGraphics.Dispose();
                }
                izq = false;//Auxiliar para saber que NO utilize dos veces el mismo recuadro
                dcha = false;//Auxiliar para saber que NO utilize dos veces el mismo recuadro

            }
        }

        private void modCol_Click(object sender, EventArgs e)
        {
            DialogResult boton = MessageBox.Show("¿ESTÁS SEGURO QUE ERES PROFESOR?", "Alerta", MessageBoxButtons.OKCancel);
            if (boton == DialogResult.OK)
            {
                modcols frame = new modcols();                frame.Show();                this.Hide();
            }
        }
   

        private void desactiveIzq()
        {
            if (evaluaBotones[0] == 0) { btnizq1.Enabled = false; }
            if (evaluaBotones[1] == 0) { btnizq2.Enabled = false; }
            if (evaluaBotones[2] == 0) { btnizq3.Enabled = false; }
            if (evaluaBotones[3] == 0) { btnizq4.Enabled = false; }
        }

        private void activeIzq()
        {
            if (evaluaBotones[0] == 0) { btnizq1.Enabled = true; }
            if (evaluaBotones[1] == 0) { btnizq2.Enabled = true; }
            if (evaluaBotones[2] == 0) { btnizq3.Enabled = true; }
            if (evaluaBotones[3] == 0) { btnizq4.Enabled = true; }
        }

        private void desactiveDcha()
        {
            if (evaluaBotones[4] == 0) { btndcha1.Enabled = false; }
            if (evaluaBotones[5] == 0) { btndcha2.Enabled = false; }
            if (evaluaBotones[6] == 0) { btndcha3.Enabled = false; }
            if (evaluaBotones[7] == 0) { btndcha4.Enabled = false; }
        }

        private void activeDcha()
        {
            if (evaluaBotones[4] == 0) { btndcha1.Enabled = true; }
            if (evaluaBotones[5] == 0) { btndcha2.Enabled = true; }
            if (evaluaBotones[6] == 0) { btndcha3.Enabled = true; }
            if (evaluaBotones[7] == 0) { btndcha4.Enabled = true; }
        }


        public void muestraPalabra(string[] palabras, string[] pairs)
        {
            evaluaRelacion = pairs;//Le llevamos el valor del parametro
            btnizq1.Text = palabras[0];
            btnizq2.Text = palabras[1];
            btnizq3.Text = palabras[2];
            btnizq4.Text = palabras[3];
            btndcha1.Text = palabras[4];
            btndcha2.Text = palabras[5];
            btndcha3.Text = palabras[6];
            btndcha4.Text = palabras[7];
            activeIzq();
            activeDcha();
        }       

        private void button2_Click(object sender, EventArgs e)
        {
            parejas frm = new parejas();            frm.Show();            this.Close();
        }

        private void btndcha1_Click(object sender, EventArgs e)
        {
            Point position = PointToClient(Cursor.Position);
            X2 = position.X;
            Y2 = position.Y;
            relacionActual[posActual] = botonActual + "5";//Enviamos relacion recien hecha
            desactiveDcha();//Controlamos que oprima un boton por lado a la vez
            activeIzq();//Controlamos que oprima un boton por lado a la vez
            evaluaBotones[4] = 1;
            dcha = true;//Auxiliar para saber que le dimos click a la derecha
            numParejas = numParejas + 1;
            btndcha1.Enabled = false;
            dibujaLinea();
        }

        private void btndcha2_Click(object sender, EventArgs e)
        {
            Point position = PointToClient(Cursor.Position);
            X2 = position.X;
            Y2 = position.Y;
            relacionActual[posActual] = botonActual + "6";//Enviamos relacion recien hecha
            desactiveDcha();//Controlamos que oprima un boton por lado a la vez
            activeIzq();//Controlamos que oprima un boton por lado a la vez
            evaluaBotones[5] = 1;
            dcha = true;//Auxiliar para saber que le dimos click a la derecha
            numParejas = numParejas + 1;
            btndcha2.Enabled = false;
            dibujaLinea();
        }

        private void btndcha3_Click(object sender, EventArgs e)
        {
            Point position = PointToClient(Cursor.Position);
            X2 = position.X;
            Y2 = position.Y;
            relacionActual[posActual] = botonActual + "7";//Enviamos relacion recien hecha
            desactiveDcha();//Controlamos que oprima un boton por lado a la vez
            activeIzq();//Controlamos que oprima un boton por lado a la vez
            evaluaBotones[6] = 1;
            dcha = true;//Auxiliar para saber que le dimos click a la derecha
            numParejas = numParejas + 1;
            btndcha3.Enabled = false;
            dibujaLinea();
        }

        private void btndcha4_Click(object sender, EventArgs e)
        {
            Point position = PointToClient(Cursor.Position);//Detectamos posición del mouse
            X2 = position.X;//Obtenemos posición relativa de X
            Y2 = position.Y;//Obtenemos posición relativa de Y
            relacionActual[posActual] = botonActual + "8";//Enviamos relacion recien hecha
            dcha = true;//Auxiliar para saber
            desactiveDcha();//Controlamos que oprima un boton por lado a la vez
            activeIzq();//Controlamos que oprima un boton por lado a la vez
            evaluaBotones[7] = 1;
            numParejas = numParejas + 1;
            btndcha4.Enabled = false;
            dibujaLinea();
        }

        private bool comparaRelacion()//Comparamos relacion correcta con la actual
        {
            int i = 0;
            while(i<4)
            {
                if (relacionActual[i].CompareTo(evaluaRelacion[i]) == 0) { i++; }//Seguimos comparando
                else { return false; }
            }
            return true;
        }
        
    }
}
