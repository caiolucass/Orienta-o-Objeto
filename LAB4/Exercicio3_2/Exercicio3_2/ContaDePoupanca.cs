using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *Escreva um programa driver para testar a classe
ContaDePoupanca. Instancie dois objetos ContaDePoupanca, poupador1 e poupador2, com
saldos de R$2000,00 e R$3000,00, respectivamente. Configure taxaDeJurosAnual como 4% e, em
seguida, calcule os juros mensais e imprima os novos saldos para cada um dos poupadores. Depois,
configure taxaDeJurosAnual como 5%, calcule os juros do próximo mês e imprima os novos saldos
para cada um dos poupadores. 
 *
 */

namespace Exercicio3_2
{
    class ContaDePoupanca
    {
        double saldoPoupanca;
        static double taxaDeJurosAnual;
        static double taxaDeJurosMensal;

        static void alterarTaxaDeJuros(double taxa)
        {
            taxaDeJurosAnual = taxa;
        }

        public static double TaxaDeJurosAnual
        {
            get { return taxaDeJurosAnual; }
            set
            {
                taxaDeJurosAnual = value;
            }
        }
        public double SaldoPoupanca
        {
            get { return saldoPoupanca; }
            set
            {
                saldoPoupanca = value;
            }
        }

        void calcularJuroMensal()
        {
            taxaDeJurosMensal = ( SaldoPoupanca*(TaxaDeJurosAnual/12) );
            SaldoPoupanca += taxaDeJurosMensal;
        }
    }
}
