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
            ProfissionalAux novoProfissional = new ProfissionalAux();

            novoProfissional.nome = textBoxNome.Text;
            novoProfissional.cpf = textBoxCpf.Text;
            novoProfissional.rg = textBoxRg.Text;
            novoProfissional.orgao_expedidor = textBoxOrg.Text;
            novoProfissional.data_nasc = dateTimePicker1.Value;
            novoProfissional.sexo = comboBoxSexo.SelectedItem.ToString();
            novoProfissional.telefone = textBoxFone.Text;
            novoProfissional.endereco = textBoxEndereco.Text;
            novoProfissional.cep = textBoxCep.Text;
            novoProfissional.cidade = textBoxCidade.Text;
            novoProfissional.estado = textBoxUF.Text;
            novoProfissional.email = textBoxEmail.Text;
            novoProfissional.especializacao = textBoxEsp.Text;
            novoProfissional.observacoes = textBoxObs.Text;
            novoProfissional.senha = textBoxSenha.Text;

            String json = JsonConvert.SerializeObject(novoProfissional);

            String rota = "http://localhost:3000/profissional";

            var req = WebRequest.CreateHttp(rota);
            req.Method = "POST";

            req.ContentType = "application/json; charset = utf-8";

            var byteArray = Encoding.UTF8.GetBytes(json);

            req.ContentLength = byteArray.Length;

            Stream str = req.GetRequestStream();
            str.Write(byteArray, 0, byteArray.Length);
            str.Close();

            //MessageBox.Show(json);
            MessageBox.Show("Cadastro realizado com sucesso!");

        }
    }
}
