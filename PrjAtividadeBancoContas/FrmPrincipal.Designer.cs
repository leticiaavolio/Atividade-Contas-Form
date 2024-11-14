namespace PrjAtividadeBancoContas
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            contasToolStripMenuItem = new ToolStripMenuItem();
            criarContasToolStripMenuItem = new ToolStripMenuItem();
            operaçõesToolStripMenuItem = new ToolStripMenuItem();
            sacarToolStripMenuItem = new ToolStripMenuItem();
            depositoToolStripMenuItem = new ToolStripMenuItem();
            transferirToolStripMenuItem = new ToolStripMenuItem();
            verSaldoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(254, 248, 232);
            menuStrip1.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { contasToolStripMenuItem, operaçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(15, 6, 0, 6);
            menuStrip1.Size = new Size(1189, 31);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // contasToolStripMenuItem
            // 
            contasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { criarContasToolStripMenuItem });
            contasToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            contasToolStripMenuItem.Name = "contasToolStripMenuItem";
            contasToolStripMenuItem.Size = new Size(56, 19);
            contasToolStripMenuItem.Text = "Contas";
            // 
            // criarContasToolStripMenuItem
            // 
            criarContasToolStripMenuItem.ForeColor = Color.FromArgb(72, 69, 120);
            criarContasToolStripMenuItem.Name = "criarContasToolStripMenuItem";
            criarContasToolStripMenuItem.Size = new Size(180, 22);
            criarContasToolStripMenuItem.Text = "Criar Contas";
            criarContasToolStripMenuItem.Click += criarContasToolStripMenuItem_Click;
            // 
            // operaçõesToolStripMenuItem
            // 
            operaçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sacarToolStripMenuItem, depositoToolStripMenuItem, transferirToolStripMenuItem, verSaldoToolStripMenuItem });
            operaçõesToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            operaçõesToolStripMenuItem.Size = new Size(78, 19);
            operaçõesToolStripMenuItem.Text = "Operações";
            // 
            // sacarToolStripMenuItem
            // 
            sacarToolStripMenuItem.Name = "sacarToolStripMenuItem";
            sacarToolStripMenuItem.Size = new Size(180, 22);
            sacarToolStripMenuItem.Text = "Sacar";
            sacarToolStripMenuItem.Click += sacarToolStripMenuItem_Click;
            // 
            // depositoToolStripMenuItem
            // 
            depositoToolStripMenuItem.Name = "depositoToolStripMenuItem";
            depositoToolStripMenuItem.Size = new Size(180, 22);
            depositoToolStripMenuItem.Text = "Deposito";
            depositoToolStripMenuItem.Click += depositoToolStripMenuItem_Click;
            // 
            // transferirToolStripMenuItem
            // 
            transferirToolStripMenuItem.Name = "transferirToolStripMenuItem";
            transferirToolStripMenuItem.Size = new Size(180, 22);
            transferirToolStripMenuItem.Text = "Transferir";
            transferirToolStripMenuItem.Click += transferirToolStripMenuItem_Click;
            // 
            // verSaldoToolStripMenuItem
            // 
            verSaldoToolStripMenuItem.Name = "verSaldoToolStripMenuItem";
            verSaldoToolStripMenuItem.Size = new Size(180, 22);
            verSaldoToolStripMenuItem.Text = "Ver Saldo";
            verSaldoToolStripMenuItem.Click += verSaldoToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(17F, 43F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 248, 232);
            ClientSize = new Size(1189, 553);
            Controls.Add(menuStrip1);
            Font = new Font("Impact", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(1, 182, 139);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(7, 9, 7, 9);
            Name = "FrmPrincipal";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem contasToolStripMenuItem;
        private ToolStripMenuItem criarContasToolStripMenuItem;
        private ToolStripMenuItem operaçõesToolStripMenuItem;
        private ToolStripMenuItem sacarToolStripMenuItem;
        private ToolStripMenuItem depositoToolStripMenuItem;
        private ToolStripMenuItem transferirToolStripMenuItem;
        private ToolStripMenuItem verSaldoToolStripMenuItem;
    }
}