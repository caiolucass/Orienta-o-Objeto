using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_extrato
{
    class GeradorDeExtrato
    {
        public void ImprimeExtratoBasico(Conta c)
        {
            DateTime agora = DateTime.Now;
            string horario = String.Format(" {0: d/M/yyyy HH:mm:ss}", agora);
            Console.WriteLine(" DATA : " + horario);
            Console.WriteLine(" SALDO : " + c.Saldo);
        }
    }
}
