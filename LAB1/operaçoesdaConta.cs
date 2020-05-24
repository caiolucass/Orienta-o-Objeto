using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta
{
        class operaçoesdaConta
        {
            public double Depositar(double saldo, double depos)
            {
                return (saldo + depos);
            }

            public double Sacar(double saldo, double saque)
            {
                return (saldo - saque);
            }

            public double Saldo(double saldo)
            {
                return (saldo);
            }
        }
    }

