using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedagogyOn_2021
{
    class Pessoa
    {
        private string nome;
        private string cpf;
        private string rg;
        private string orgao_exp;
        private DateTime data_nasc;
        private string sexo;
        private string endereco;
        private string cep;
        private string cidade;
        private string estado;
        private string telefone;
        private string email;
        private string senha;


        public string Nome 
        { 
            get { return nome; }
            set { nome = value; }
        }

        public string Cpf
        {
            get { return cpf; }
        }

        public string Rg
        {
            get { return rg; }
        }

        public string Orgao_exp
        {
            get { return orgao_exp; }
            set { orgao_exp = value; }
        }

        public DateTime Data_nasc
        {
            get { return data_nasc; }
            set { data_nasc = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Email
        {
            get { return email; }
        }

        public string Senha
        {
            get { return senha; }
        }

    }
}
