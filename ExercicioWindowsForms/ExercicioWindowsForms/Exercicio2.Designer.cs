namespace ExercicioWindowsForms
{
    partial class Exercicio2
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
            txtNome = new TextBox();
            btnSaudar = new Button();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(79, 124);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // btnSaudar
            // 
            btnSaudar.Location = new Point(79, 182);
            btnSaudar.Name = "btnSaudar";
            btnSaudar.Size = new Size(94, 29);
            btnSaudar.TabIndex = 1;
            btnSaudar.Text = "Saudar";
            btnSaudar.UseVisualStyleBackColor = true;
            btnSaudar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 77);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 2;
            label1.Text = "Digite seu nome";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(79, 245);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Prox";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Exercicio2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(btnSaudar);
            Controls.Add(txtNome);
            Name = "Exercicio2";
            Text = "Exercicio2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Button btnSaudar;
        private Label label1;
        private Button button2;
    }
}