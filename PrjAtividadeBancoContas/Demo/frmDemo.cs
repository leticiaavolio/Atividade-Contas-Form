using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;//biblioteca para trabalhar com internacionalização da aplicação

namespace PrjAtividadeBancoContas.Demo
{
    public partial class frmDemo : Form
    {
        public frmDemo()
        {
            InitializeComponent();
        }

        private void frmDemo_Load(object sender, EventArgs e)
        {

        }

        private void btnFormatar_Click(object sender, EventArgs e)
        {
            //decimal preco = 199M;

            // //:C == apresenta o número com R$    == R$ 199,00
            //txtNFor.Text = $"Preço do produto: {preco:C}";

            // :N*1* == quantidade casas decimais pedidas  == 199,0
            //txtNFor.Text = $"Preço do produto: {preco:N1}";


            //double fatorPercentual = .70;

            // .ToString("P") == apresenta a porcentagem formatada == 70,00%
            //txtNFor.Text = $"Percentual: {fatorPercentual.ToString("P")}";

            //Manipulando a localização do sistema
            //CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-UK");
            //decimal preco = 1999 * (decimal)Math.PI;

            //txtNFor.Text = $"Preço do produto: {preco:C}";
            //DateTime dataHoje = DateTime.Now;
            //txtNFor2.Text = dataHoje.ToString();

            //manipulando a saida 
            //txtNFor2.Text= preco.ToString("C",CultureInfo.CreateSpecificCulture("pt-BR"));

            //////////////////long cpf = 42673618864;
            //////////////////txtNFor2.Text = cpf.ToString("000.000.000-00");


            DateTime data = DateTime.Now;
            txtNFor.Text = data.ToString("dddd  dd \\de MMMM \\de yyyy  à\\s H:mm:ss");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
