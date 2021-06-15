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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            if (comboBoxTipo.SelectedIndex == 0)
            {
                cadastro2 cad2 = new cadastro2();
                cad2.ShowDialog();
            }
            else if (comboBoxTipo.SelectedIndex == 1)
            {
                cadastro1 cad1 = new cadastro1();
                cad1.ShowDialog();
            }

        }
    }
}
