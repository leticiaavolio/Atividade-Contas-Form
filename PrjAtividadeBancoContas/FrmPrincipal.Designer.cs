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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { contasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1172, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // contasToolStripMenuItem
            // 
            contasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { criarContasToolStripMenuItem });
            contasToolStripMenuItem.Name = "contasToolStripMenuItem";
            contasToolStripMenuItem.Size = new Size(56, 20);
            contasToolStripMenuItem.Text = "Contas";
            // 
            // criarContasToolStripMenuItem
            // 
            criarContasToolStripMenuItem.Name = "criarContasToolStripMenuItem";
            criarContasToolStripMenuItem.Size = new Size(180, 22);
            criarContasToolStripMenuItem.Text = "Criar Contas";
            criarContasToolStripMenuItem.Click += criarContasToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 643);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
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

    }
}