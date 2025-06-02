namespace ExercicioWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Olá, Windows Forms!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exercicio2 exercicio2 = new Exercicio2 ();
            exercicio2.Show();
                

        }
    }
}
