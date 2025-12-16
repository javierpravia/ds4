using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Parcial2
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=.\sqlexpress;Database=ConversorMonedas;Trusted_Connection=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEuroConv_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Obtener el valor de entrada
                decimal cantidadEuro = decimal.Parse(tbEuroQty.Text);

                // Realizar las conversiones
                decimal euroResult = cantidadEuro;
                decimal dolarResult = cantidadEuro * 1.17m;
                decimal pesoResult = cantidadEuro * 4.9826m;

                tbEuroToEuro.Text = euroResult.ToString("F2");
                tbEuroToDolar.Text = dolarResult.ToString("F2");
                tbEuroToPeso.Text = pesoResult.ToString("F2");

                GuardarConversion("EURO", cantidadEuro, euroResult, dolarResult, pesoResult);
            }
            catch
            {
                MessageBox.Show("Ingrese un valor numérico válido");
            }
        }       

        private void btnDolarConv_Click(object sender, EventArgs e)
        {
            try
            {

                decimal cantidadDolar = decimal.Parse(tbDolarQty.Text);

                decimal euroResult = cantidadDolar / 1.17m;
                decimal dolarResult = cantidadDolar;
                decimal pesoResult = cantidadDolar * 4.258m;

                tbDolarToEuro.Text = euroResult.ToString("F2");
                tbDolarToDolar.Text = dolarResult.ToString("F2");
                tbDolarToPeso.Text = pesoResult.ToString("F2");

                GuardarConversion("DOLAR", cantidadDolar, euroResult, dolarResult, pesoResult);
            }
            catch
            {
                MessageBox.Show("Ingrese un valor numérico válido");
            }
        }

        private void btnPesoConv_Click(object sender, EventArgs e)
        {
            try
            {
                decimal cantidadPeso = decimal.Parse(tbPesoQty.Text);

                // Realizar las conversiones
                decimal euroResult = cantidadPeso / 4.9826m;
                decimal dolarResult = cantidadPeso / 4.258m;
                decimal pesoResult = cantidadPeso;

                tbPesoToEuro.Text = euroResult.ToString("F2");
                tbPesoToDolar.Text = dolarResult.ToString("F2");
                tbPesoToPeso.Text = pesoResult.ToString("F2");
            }
            catch
            {
                MessageBox.Show("Ingrese un valor numérico válido");
            }
        }
        private void GuardarConversion(string monedaOrigen, decimal cantidadOrigen,
                               decimal euroResultado, decimal dolarResultado, decimal pesoResultado)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = @"INSERT INTO Conversiones 
                            (MonedaOrigen, CantidadOrigen, EuroResultado, DolarResultado, PesoResultado) 
                            VALUES 
                            (@MonedaOrigen, @CantidadOrigen, @EuroResultado, @DolarResultado, @PesoResultado)";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@MonedaOrigen", monedaOrigen);
                        comando.Parameters.AddWithValue("@CantidadOrigen", cantidadOrigen);
                        comando.Parameters.AddWithValue("@EuroResultado", euroResultado);
                        comando.Parameters.AddWithValue("@DolarResultado", dolarResultado);
                        comando.Parameters.AddWithValue("@PesoResultado", pesoResultado);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Conversión guardada exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

    }
}
