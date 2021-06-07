using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;  // Fornece classes para diversos protocolos de rede
using System.IO;   // Fornece classes para ler e gravar arquivos e fluxo de dados
using Newtonsoft.Json;


namespace PedagogyOn_2021
{
    public partial class frmPagamento : Form
    {
        public frmPagamento()
        {
            InitializeComponent();
        }

        private void pctVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCartaoCredito_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pagamento com cartão de crédito selecionado");
        }

        private void btnBoleto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pagamento com boleto selecionado");
        }

        private void btnTransferência_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pagamento por transferência selecionado");
        }

        private void btnPix_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pagamento por PIX selecionado");
        }
    }
}
