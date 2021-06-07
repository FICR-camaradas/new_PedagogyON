using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedagogyOn_2021
{ 
    class Contrato
    {
        private int cod_contrato;
        private DateTime data;
        private float valor_pago;
        private string descricao;
        private int avaliacao_servico;
        private string comentario;
        private Cliente cliente;
        private Dependente dependente;
        private Profissional profissional;

        public int Cod_contrato
        {
            get { return cod_contrato; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public float Valor_pago
        {
            get { return valor_pago; }
            set { valor_pago = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public int Avaliacao_servico
        {
            get { return avaliacao_servico; }
            set { avaliacao_servico = value; }
        }

        public string Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }

        public Cliente Cliente
        {
            get { return cliente; }
        }

        public Dependente Dependente
        {
            get { return dependente; }
        }

        public Profissional Profissional
        {
            get { return profissional; }
        }

    }
}
