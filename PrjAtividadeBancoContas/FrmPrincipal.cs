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
    }
}