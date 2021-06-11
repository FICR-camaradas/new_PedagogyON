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
    public partial class cadastro1 : Form
    {
        public cadastro1()
        {
            InitializeComponent();
        }

        private void buttonCad_Click(object sender, EventArgs e)
        {
            Cliente novoCliente = new Cliente();

            novoCliente.Nome = textBoxNome.Text;
            novoCliente.Cpf = textBoxCpf.Text;
            novoCliente.Rg = textBoxRg.Text;
            novoCliente.Orgao_exp = textBoxOrg.Text;
            novoCliente.Data_nasc = dateTimePicker1.Value;
            novoCliente.Sexo = comboBoxSexo.SelectedItem.ToString();
            novoCliente.Telefone = textBoxFone.Text;
            novoCliente.Endereco = textBoxEndereco.Text;
            novoCliente.Cep = textBoxCep.Text;
            novoCliente.Cidade = textBoxCidade.Text;
            novoCliente.Estado = textBoxUF.Text;
            novoCliente.Email = textBoxEmail.Text;
            novoCliente.Senha = textBoxSenha.Text;


        }
    }
}
