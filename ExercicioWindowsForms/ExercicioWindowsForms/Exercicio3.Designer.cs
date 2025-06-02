namespace ExercicioWindowsForms
{
    partial class Exercicio3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNum1 = new TextBox();
            btnSubtracao = new Button();
            btnMultiplicacao = new Button();
            btnDivisao = new Button();
            btnSoma = new Button();
            txtNum2 = new TextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(176, 77);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(125, 27);
            txtNum1.TabIndex = 0;
            txtNum1.TextChanged += textBox1_TextChanged;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Location = new Point(319, 135);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(94, 29);
            btnSubtracao.TabIndex = 1;
            btnSubtracao.Text = "Subtração";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += button1_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Location = new Point(207, 180);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(94, 29);
            btnMultiplicacao.TabIndex = 2;
            btnMultiplicacao.Text = "Multiplicação";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Location = new Point(319, 180);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(94, 29);
            btnDivisao.TabIndex = 3;
            btnDivisao.Text = "Divisão";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += button3_Click;
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(207, 135);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(94, 29);
            btnSoma.TabIndex = 4;
            btnSoma.Text = "Soma";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += button4_Click;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(332, 77);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(125, 27);
            txtNum2.TabIndex = 5;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(319, 257);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(17, 20);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "0";
            lblResultado.Click += label1_Click;
            // 
            // Exercicio3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(txtNum2);
            Controls.Add(btnSoma);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnSubtracao);
            Controls.Add(txtNum1);
            Name = "Exercicio3";
            Text = "n";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private Button btnSubtracao;
        private Button btnMultiplicacao;
        private Button btnDivisao;
        private Button btnSoma;
        private TextBox txtNum2;
        private Label lblResultado;


    }
}