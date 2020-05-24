using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeBancos
{
    class Fatura
    {
        double total;
        // Adiciona o valor ao total da fatura
        public void adiciona(double valor)
        {
            total += valor;
        }
        // Calcula multa de 2% sobre o total da fatura
        public double calculaMulta()
        {
            total += total * 0.2;
            return (total);
        }
        // Imprime o total da fatura
        public void imprimeDados()
        {
            Console.WriteLine(total);
          }
    }
}
