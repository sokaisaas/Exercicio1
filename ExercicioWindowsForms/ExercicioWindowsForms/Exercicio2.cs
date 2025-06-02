using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioWindowsForms
{
    public partial class Exercicio2 : Form
    {
        public Exercicio2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obter o nome digitado
            string nome = txtNome.Text;

            // Verificar se o nome foi digitado
            if (!
                string.IsNullOrWhiteSpace(nome))

            {
                // Exibir mensagem personalizada
                MessageBox.Show($"Bem Vindo(a), {nome}!", "Saudação",

             MessageBoxButtons.OK,
             MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, digite seu nome!", "Aviso",

                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exercicio3 exercicio3 = new Exercicio3();
            exercicio3.Show();
        }
    }
}
