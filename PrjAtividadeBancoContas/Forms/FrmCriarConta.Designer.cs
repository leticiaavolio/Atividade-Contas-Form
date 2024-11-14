namespace PrjAtividadeBancoContas.Forms
{
    partial class FrmCriarConta
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(102, 124);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(102, 164);
            label3.Name = "label3";
            label3.Size = new Size(143, 21);
            label3.TabIndex = 2;
            label3.Text = "Número da Conta:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(102, 204);
            label4.Name = "label4";
            label4.Size = new Size(116, 21);
            label4.TabIndex = 3;
            label4.Text = "Tipo da Conta:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(416, 124);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 4;
            label5.Text = "Saldo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(416, 165);
            label6.Name = "label6";
            label6.Size = new Size(59, 21);
            label6.TabIndex = 5;
            label6.Text = "Limite:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(416, 206);
            label7.Name = "label7";
            label7.Size = new Size(58, 21);
            label7.TabIndex = 6;
            label7.Text = "Senha:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(234, 247);
            label8.Name = "label8";
            label8.Size = new Size(177, 21);
            label8.TabIndex = 7;
            label8.Text = "Confirmação da Senha:";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(309, 47);
            label9.Name = "label9";
            label9.Size = new Size(143, 32);
            label9.TabIndex = 8;
            label9.Text = "Criar Conta";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(167, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 29);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(251, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(144, 29);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(224, 196);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(149, 29);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(477, 116);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(179, 29);
            textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(481, 162);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(175, 29);
            textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.Location = new Point(480, 201);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(176, 29);
            textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox7.Location = new Point(417, 244);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(176, 29);
            textBox7.TabIndex = 15;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(309, 308);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(143, 37);
            btnCadastrar.TabIndex = 16;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FrmCriarConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 248, 232);
            ClientSize = new Size(760, 413);
            Controls.Add(btnCadastrar);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmCriarConta";
            Text = "FrmCriarConta";
            Load += FrmCriarConta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button btnCadastrar;
    }
}