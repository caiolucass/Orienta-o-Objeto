using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_3
{
    class GeradorDeExtrato
    {
        public void imprimeExtratoBasico ( IConta c) { 
        DateTime agora = DateTime . Now ; 
        string horario = String.Format(" {0: d/M/yyyy HH:mm:ss}", agora ); 
        Console.WriteLine (" DATA : " + horario ); 
        Console.WriteLine (" SALDO : " + c. Saldo ); 
        }//fim imprimeExtrato
    }//fim class
}//fim namespace
