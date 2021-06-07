using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedagogyOn_2021
{
    class Profissional : Pessoa
    {
        private int cod_profissional;
        private string especializacao;
        private string observacoes;

        public int Cod_profissional
        {
            get { return cod_profissional; }
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
    }
}
