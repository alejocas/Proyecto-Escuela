using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace juego
{
    public partial class Form2 : Form
    {
       
        
        MySqlConnection con = new MySqlConnection("Server = localhost; Uid = test; Password = test; Database = juegosss; Port = 3306");
        MySqlCommand cmd = new MySqlCommand();
       public Form2()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.textBox2.Text = textBox8.Text;
            f1.label1.Text = textBox3.Text;
            f1.label3.Text = textBox1.Text;
            f1.label10.Text = textBox2.Text;
            f1.label11.Text = textBox4.Text;
            f1.textBox5.Text = textBox2.Text;
            f1.textBox6.Text = textBox4.Text;
            f1.Show();
           //falta que esto vaya al texto que se configuro con la base de datos para que el niño juegue
        } 

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aqui estaran los textos que se deben guardaron
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // aqui va el texto que se eligió
        }
    }


    
}
