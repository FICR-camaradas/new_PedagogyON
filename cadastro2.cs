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
    public partial class cadastro2 : Form
    {
        public cadastro2()
        {
            InitializeComponent();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCad_Click(object sender, EventArgs e)
        {
            Profissional novoProfissional = new Profissional();

            novoProfissional.Nome = textBoxNome.Text;
            novoProfissional.Cpf = textBoxCpf.Text;
            novoProfissional.Rg = textBoxRg.Text;
            novoProfissional.Orgao_exp = textBoxOrg.Text;
            novoProfissional.Data_nasc = dateTimePicker1.Value;
            novoProfissional.Sexo = comboBoxSexo.SelectedItem.ToString();
            novoProfissional.Telefone = textBoxFone.Text;
            novoProfissional.Endereco = textBoxEndereco.Text;
            novoProfissional.Cep = textBoxCep.Text;
            novoProfissional.Cidade = textBoxCidade.Text;
            novoProfissional.Estado = textBoxUF.Text;
            novoProfissional.Email = textBoxEmail.Text;
            novoProfissional.Especializacao = textBoxEsp.Text;
            novoProfissional.Observacoes = textBoxObs.Text;
            novoProfissional.Senha = textBoxSenha.Text;


        }
    }
}
