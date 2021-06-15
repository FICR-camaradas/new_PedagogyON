using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedagogyOn_2021
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            Application.Run(new Perfil());
            Application.Run(new FormBusca());
            Application.Run(new frmChat());
            Application.Run(new frmPagamento());
            Application.Run(new FormPerfiLinteiro());
            Application.Run(new PerfilUsuario2());
            Application.Run(new FormInfo());
        }
    }
}
