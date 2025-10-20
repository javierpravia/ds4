using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace Laboratorio123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSemiperimetro_Click(object sender, EventArgs e)
        {
            double ladoA = Convert.ToDouble(textBox1.Text);
            double ladoB = Convert.ToDouble(textBox2.Text);
            double ladoC = Convert.ToDouble(textBox3.Text);

            double semiperimetro = (ladoA + ladoB + ladoC) / 2;
            textBoxSemiperimetro.Text = semiperimetro.ToString();

        }

        private void buttonArea_Click(object sender, EventArgs e)
        {
            double ladoA = Convert.ToDouble(textBox1.Text);
            double ladoB = Convert.ToDouble(textBox2.Text);
            double ladoC = Convert.ToDouble(textBox3.Text);

            double s = (ladoA + ladoB + ladoC) / 2;

            double area = Math.Sqrt(s * (s - ladoA) * (s - ladoB) * (s - ladoC));

            textBoxAreaTriangulo.Text = area.ToString();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBoxSemiperimetro.Clear();
            textBoxAreaTriangulo.Clear();
        }
        private void buttonSalida_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
