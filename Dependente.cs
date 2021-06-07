using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedagogyOn_2021
{
    class Dependente : Pessoa
    {
        private int cod_dependente;
        private string observacoes;
        private Cliente cliente;

        public int Cod_dependente
        {
            get { return cod_dependente; }
        }

        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }

        public Cliente Cliente
        {
            get { return cliente; }
        }
    }
}
