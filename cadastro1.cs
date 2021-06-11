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
            ClienteAux novoCliente = new ClienteAux();

            novoCliente.nome = textBoxNome.Text;
            novoCliente.cpf = textBoxCpf.Text;
            novoCliente.rg = textBoxRg.Text;
            novoCliente.orgao_exp = textBoxOrg.Text;
            novoCliente.data_nasc = dateTimePicker1.Value;
            novoCliente.sexo = comboBoxSexo.SelectedItem.ToString();
            novoCliente.telefone = textBoxFone.Text;
            novoCliente.endereco = textBoxEndereco.Text;
            novoCliente.cep = textBoxCep.Text;
            novoCliente.cidade = textBoxCidade.Text;
            novoCliente.estado = textBoxUF.Text;
            novoCliente.email = textBoxEmail.Text;
            novoCliente.senha = textBoxSenha.Text;

            String json = JsonConvert.SerializeObject(novoCliente);

            String rota = "http://localhost:3000/cliente";

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
