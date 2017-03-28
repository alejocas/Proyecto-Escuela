using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using System.Web;

namespace ColoreaPalabras 
{
    //Textos Máximo de 70 palabras
    public partial class coloreaPalabras : Form
    {

       
        string[] palabras, palabraClave;//Almacena textoCrudo, keyWordCrudo divido en posicion de vector
        string[] colores = { "Rojo", "Amarillo", "Naranja", "Azul", "Verde", "Violeta" };//Máximo numero de palabras contenidas en texto
        int id, yLocation = 0, xlocation = 0;//Posición donde se mostraran las cajas
        string textboxname = "text";//Usado para asignar nombre de los texto box
        int i = 0, j = 0;//Para saber cuandos textbox tenemos
        string colorEscogido;
        object color;
        string[] botonPalabraClave = new string[70];
        bool auxiliar = false;//Sabemos cuando ha seleccionado el color y activamos panel

        int aciertoPalabra = 0, numPalabras = 0, aciertoColor = 0, falloColor = 0;//Control estadísticas(Estas variables se reciben en la base de datos)
        
        public coloreaPalabras()
        {
            InitializeComponent();
        }


        private void Page_Load(object sender, System.EventArgs e)
        {

        }


        private void AddControls(int number)//Añadimos botones al panel
        {
            for (i = 0; i < palabras.Length; i++)
            {
                if (i % 6 == 0 && i != 0)//Usamos modulo para saber cuando llega al máximo ancho horizontal
                {
                    xlocation = 0;//Reiniciamos la posición en 'X'
                    yLocation = yLocation + 28;//Posicion en 'Y' aumentará en medida del tamaño de los checkbox
                }
                id = i;
                textboxname = "text" + id.ToString();//Convertimos id a string y se lo concatenamos al name del textbox
                Button dynamictextbox = new Button();//Creamos textBox Dinámico
                dynamictextbox.Size = new Size(152, 33);//Establecemos tamaño de los botones(Palabra más larga del español)
                dynamictextbox.Text = palabras[i]; //Ingresamos Texto al textBox Dinámico
                dynamictextbox.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dynamictextbox.BackColor = System.Drawing.Color.White;//Color de fondo
                dynamictextbox.Name = textboxname; //Asignamos nombre único a los textBox
                dynamictextbox.Location = new Point(152 * xlocation, yLocation);
                xlocation++;//Aumentamos posición de x
                if (palabraClave[number].CompareTo(dynamictextbox.Text) == 0)//
                {//Si la palabra clave es la misma que la de esta posición del texto asignamos evento de click
                    botonPalabraClave[j] = textboxname;//Vector colores
                    dynamictextbox.Click += new System.EventHandler(dynamictextbox_Click);//Le agregamos evento de click                
                    j++;
                }
                    panelTexto.Controls.Add(dynamictextbox);//Añade el textoBox al Panel                
                textboxname = "text";//Restablecemos nombre de textBox
            }
        }

        private void dynamictextbox_Click(Object sender, System.EventArgs e)
        {//Agregamos evento click al nuevo dynamic textBox
            for (int flag = 0; flag < j; flag++)
            {//Longitud máxima auxiliar j 
                Control aux = this.FindControlRecursive(panelTexto, botonPalabraClave[flag]);
                Button tb = (Button)(aux);//Encontramos el panel con método recursivo para agregarle evento
                tb.ForeColor = (System.Drawing.Color)color;//Color de fondo de las letras
                numPalabras = numPalabras + 1;//Controlamos estadísticas
                    if (auxiliar&&numPalabras==j+1)
                    {
                        mostrarResultado();
                    }              
            }
        }

        private Control FindControlRecursive(Control root, string id)
        {//Método recursivo para encontrar panel
            if (root.Name.CompareTo(id) == 0)//Comparamos nombre para buscarlo recursivo
            {
                return root;
            }

            foreach (Control c in root.Controls)
            {
                Control t = FindControlRecursive(c, id);
                if (t != null)
                {
                    return t;
                }
            }
            return null;
        }

        public void creaPalabra(string textoCrudo, string keywordCrudo)
        {//Dividamos los textos entrados en un vector
            palabras = textoCrudo.Split(' ');
            palabraClave = keywordCrudo.Split(' ');
            mostrarPaso();           
        }

      

        private void mostrarPaso()//Muestra instrucciones al usuario
        {
            Random rm = new Random();
            int number = rm.Next(1, colores.Length);//Color Aleatoria
            int number2 = rm.Next(0, palabraClave.Length);//Palabra clave aleatoria
            textColor.Text = colores[number];
            textPalabra.Text = palabraClave[number2];
            seleccionaColor(colores[number]);
            AddControls(number2);
            panelTexto.Visible = false;
        }
        

        private object seleccionaColor(string colores)
        {//Seleccionamos el color de las letras
            switch (colores)
            {
                case "Rojo":
                    color = System.Drawing.Color.Red;
                    colorEscogido = "Rojo";
                    return color;
                case "Azul":
                    color = System.Drawing.Color.Blue;
                    colorEscogido = "Azul";
                    return color;
                case "Violeta":
                    color = System.Drawing.Color.Purple;
                    colorEscogido = "Violeta";
                    return color;
                case "Amarillo":
                   
                    color = System.Drawing.Color.Yellow;
                    colorEscogido = "Amarillo";
                    return color;
                case "Naranja":
                    color = System.Drawing.Color.Orange;
                    colorEscogido = "Naranja";
                    return color;
                case "Verde":
                    color = System.Drawing.Color.Green;
                    colorEscogido = "Verde";
                    return color;
            }
            return System.Drawing.Color.Blue;
        }       

       
        private void mostrarResultado()
        {//Reiniciamos el juego para jugarlo con otra palabra y otro color  
             MessageBox.Show("¡Has Pintado la palabra correcta y el Color!");
            j = 0;//Reiniciamos variables
            xlocation = 0;//Reiniciamos variables
            yLocation = 0;//Reiniciamos variables
            panelTexto.Controls.Clear();
            auxiliar = false;//Reiniciamos variables
            mostrarPaso();
            aciertoPalabra = aciertoPalabra+1;//Control a estadistica
            numPalabras = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panelRojo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//Acceso para los profesores
        {
            DialogResult boton = MessageBox.Show("¿ESTÁS SEGURO QUE ERES PROFESOR?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (boton == DialogResult.OK)
            {
                modText frame = new modText();
                frame.StartPosition = FormStartPosition.CenterScreen;
                frame.Show();
                this.Hide();
            }
        }

        private void panelVerde_Click(object sender, EventArgs e)
        {
            if (textColor.Text.CompareTo(colorEscogido) == 0)
            {
                aciertoColor = aciertoColor + 1;
                panelTexto.Visible = true;
                auxiliar = true;
            }
            else
            {
                MessageBox.Show("Upss ese no era");
                falloColor = falloColor + 1;
            }
        }

        private void panelVioleta_Click(object sender, EventArgs e)
        {
            if (textColor.Text.CompareTo("Violeta") == 0)
            {
                aciertoColor = aciertoColor + 1;
                panelTexto.Visible = true;
                auxiliar = true;
            }
            else
            {
                MessageBox.Show("Upss ese no era");
                falloColor = falloColor + 1;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelRojo_Click(object sender, EventArgs e)//Verificamos que acierte color
        {
            if (textColor.Text.CompareTo("Rojo") == 0)
            {
                aciertoColor = aciertoColor + 1;
                panelTexto.Visible = true;
                auxiliar = true;
            }
            else
            {
                MessageBox.Show("Upss ese no era");
                falloColor = falloColor + 1;
            }
        }

        private void panelAmarillo_Click(object sender, EventArgs e)//Verificamos que acierte color
        {
            if (textColor.Text.CompareTo("Amarillo") == 0)
            {
                aciertoColor = aciertoColor + 1;
                panelTexto.Visible = true;
                auxiliar = true;
            }
            else
            {
                MessageBox.Show("Upss ese no era");
                falloColor = falloColor + 1;
            }
        }

        private void panelNaranja_Click(object sender, EventArgs e)//Verificamos que acierte color
        {
            if (textColor.Text.CompareTo("Naranja") == 0)
            {
                aciertoColor = aciertoColor + 1;
                panelTexto.Visible = true;
                auxiliar = true;
            }
            else
            {
                MessageBox.Show("Upss ese no era");
                falloColor = falloColor + 1;
            }
        }

        private void panelAzul_Click(object sender, EventArgs e)//Verificamos que acierte color
        {
            if (textColor.Text.CompareTo("Azul") == 0)
            {
                aciertoColor = aciertoColor + 1;
                panelTexto.Visible = true;
                auxiliar = true;

            }
            else
            {
                MessageBox.Show("Upss ese no era");
                falloColor = falloColor + 1;
            }
        }
    }
}
