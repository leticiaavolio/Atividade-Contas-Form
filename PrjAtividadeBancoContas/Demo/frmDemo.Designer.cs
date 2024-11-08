namespace PrjAtividadeBancoContas.Demo
{
    partial class frmDemo
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
            txtNBruto = new TextBox();
            txtNFor = new TextBox();
            btnFormatar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNFor2 = new TextBox();
            SuspendLayout();
            // 
            // txtNBruto
            // 
            txtNBruto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNBruto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNBruto.Location = new Point(145, 102);
            txtNBruto.Name = "txtNBruto";
            txtNBruto.Size = new Size(424, 33);
            txtNBruto.TabIndex = 0;
            // 
            // txtNFor
            // 
            txtNFor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNFor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNFor.Location = new Point(145, 196);
            txtNFor.Name = "txtNFor";
            txtNFor.Size = new Size(424, 33);
            txtNFor.TabIndex = 1;
            // 
            // btnFormatar
            // 
            btnFormatar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnFormatar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFormatar.Location = new Point(280, 375);
            btnFormatar.Name = "btnFormatar";
            btnFormatar.Size = new Size(146, 56);
            btnFormatar.TabIndex = 2;
            btnFormatar.Text = "Formatar";
            btnFormatar.UseVisualStyleBackColor = true;
            btnFormatar.Click += btnFormatar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(145, 168);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 3;
            label1.Text = "Número Formatado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(145, 74);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 4;
            label2.Text = "Número Bruto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(145, 263);
            label3.Name = "label3";
            label3.Size = new Size(181, 25);
            label3.TabIndex = 6;
            label3.Text = "Número Formatado:";
            // 
            // txtNFor2
            // 
            txtNFor2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNFor2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNFor2.Location = new Point(145, 291);
            txtNFor2.Name = "txtNFor2";
            txtNFor2.Size = new Size(424, 33);
            txtNFor2.TabIndex = 5;
            txtNFor2.TextChanged += textBox1_TextChanged;
            // 
            // frmDemo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 636);
            Controls.Add(label3);
            Controls.Add(txtNFor2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnFormatar);
            Controls.Add(txtNFor);
            Controls.Add(txtNBruto);
            Name = "frmDemo";
            Text = "frmDemo";
            Load += frmDemo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNBruto;
        private TextBox txtNFor;
        private Button btnFormatar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNFor2;
    }
}