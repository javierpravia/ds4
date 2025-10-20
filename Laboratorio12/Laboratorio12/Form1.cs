using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laboratorio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double velocidad = Convert.ToDouble(textBoxVelo.Text);
            double tiempo = Convert.ToDouble(textBoxTiempo.Text);

            double distancia = velocidad * tiempo;

            textBox3.Text = distancia.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxVelo.Clear();
            textBoxTiempo.Clear();
            textBox3.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
