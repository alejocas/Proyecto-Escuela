using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Threading;

namespace juego
{
    public partial class Form1 : Form
    {
        
        Form2 f2 = new Form2();
        SpeechSynthesizer sy = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        int i = 0; //contador de dictado 
        int t = 0; //contador de dictado
        int q = 0; //estadistica de si es buena o no
        int w = 0; //contador de errores
      
        public Form1()
        {
            InitializeComponent();

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            sy.Rate = (int) -2;
            pb.ClearContent();
            pb.AppendText(label1.Text);
            sy.Speak(pb);
            
        } 


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

   
        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult salirEscape = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo);

            switch (salirEscape)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;

                case DialogResult.No:
                    Cursor.Hide();

                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == textBox3.Text)
            {
                q = q + 1;
            }
            else
            {
                //aqui manda al profesor un mensaje enviado que tuvo error y mostrado lo que se escribio en el textobox 3
            }
            if (textBox6.Text == textBox4.Text)
            {
                q = q + 1;
            }
            else
            {
                //aqui manda al profesor un mensaje enviado que tuvo error y mostrado lo que se escribio en el textobox 4
            }
            MessageBox.Show("felicidades obtuviste" + "\n" + q ,"puntos");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pb.ClearContent();
            pb.AppendText(label10.Text);
            sy.Speak(pb);
            i = i + 1; //cuantas veces dio click
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pb.ClearContent();
            pb.AppendText(label11.Text);
            sy.Speak(pb);
            t = t + 1; //cuantas veces dio click
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            if (textBox2.Text == textBox1.Text) 
            {
                MessageBox.Show("Muy bien continua el siguiente ejercicio");
                q = q + 1;
                label7.Visible = true;
                label8.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;

            }
            else
            {
                MessageBox.Show("incorrecta intenta denuevo");
                w = w + 1;
                // manda a la cuenta del profesor lo que se equivoco en el textbox 1
            }
        }
    }
}
