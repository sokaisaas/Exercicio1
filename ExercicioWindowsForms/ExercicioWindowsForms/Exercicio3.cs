using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioWindowsForms
{
    public partial class Exercicio3 : Form
    {
        public Exercicio3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            Calcular((a, b) => a * b);
        }

        private void Calcular(Func<double, double, double> operação)
        {
            try
            {
                double num1 =
        Convert.ToDouble(txtNum1.Text);
                double num2 =
        Convert.ToDouble(txtNum2.Text);

                double resultado =
        operação(num1, num2);
                lblResultado.Text =
        resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, digite números válidos!", "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void btnSoma_Click(object sender, EventArgs e)
        {
            Calcular((a, b) => a + b);
        }

        private void btnSubtracao_Click (object sender, EventArgs e)
        {
            Calcular((a, b) => a - b);
        }
        private void btnDivisao_Click (object sender, EventArgs e)
        {
            try
            {
                Calcular((a, b) =>
                {
                    if (b == 0) throw new
        DivideByZeroException();
                    return a / b;
                });
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Não é possível dividir por zero!", "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                lblResultado.Text = "Erro";
                
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
