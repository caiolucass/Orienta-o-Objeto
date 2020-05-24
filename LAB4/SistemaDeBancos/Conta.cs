using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeBancos
{
    class Conta
    {
        double saldo;
        Agencia agencia;

        public double Saldo { get; set; }

        public Agencia Agencia { get; set; }

        public void deposita(double valor)
        {
            saldo += valor;

        }
        public void saca(double valor)
        {
            saldo -= valor;
        }
         public void imprimeExtrato()
        {
            Console.WriteLine( saldo);
        }
    }
}
