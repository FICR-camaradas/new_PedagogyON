using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedagogyOn_2021
{
    public class Dependente : Pessoa
    {
        private int idDependente;
        private string observacoes;
        private Cliente cliente;

        public int Cod_dependente
        {
            get { return idDependente; }
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
