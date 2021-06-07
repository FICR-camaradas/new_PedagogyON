using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedagogyOn_2021
{
    public class Cliente : Pessoa
    {
        private int idCliente;
        private int tipo;

        public int IdCliente
        {
            get { return idCliente; }
        }

        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
    }
}
