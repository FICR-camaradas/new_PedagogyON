using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedagogyOn_2021
{
    public class Profissional : Pessoa
    {
        private int idProfissional;
        private string especializacao;
        private string observacoes;
        private int tipo;

        public int IdProfissional
        {
            get { return idProfissional; }
        }

        public string Especializacao
        {
            get { return especializacao; }
            set { especializacao = value; }
        }

        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }

        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

    }
}
