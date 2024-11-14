using PrjAtividadeBancoContas.Forms;

namespace PrjAtividadeBancoContas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void criarContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCriarConta frmCriarConta = new FrmCriarConta();
            frmCriarConta.MdiParent = this;
            frmCriarConta.Show();
        }

        private void sacarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSacar frmSacar = new FrmSacar();
            frmSacar.MdiParent = this;
            frmSacar.Show();
        }

        private void depositoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepositar frmDeposito = new FrmDepositar();
            frmDeposito.MdiParent = this;
            frmDeposito.Show();
        }

        private void transferirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTransferir frmTransferir = new FrmTransferir();
            frmTransferir.MdiParent = this;
            frmTransferir.Show();
        }

        private void verSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVerSaldo frmVerSaldo = new FrmVerSaldo();
            frmVerSaldo.MdiParent = this;
            frmVerSaldo.Show();
        }
    }
}