namespace Laboratorio122
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcProm_Click(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(textBox1.Text);
            double nota2 = Convert.ToDouble(textBox2.Text);
            double nota3 = Convert.ToDouble(textBox3.Text);

            double promedio = (nota1 + nota2 + nota3) / 3;

            textBoxResult.Text = promedio.ToString();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBoxResult.Clear();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
