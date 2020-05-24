using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_5
{
    class Divisao : iOperacaoMatematica
    {
        public int calcula(int a, int b)
        { 
            int resultado = 0;
            if ( b > 0)
            {
                resultado = ( a / b );
            }
            else
            {
                Console.WriteLine("ERRO: O denominador da divisao deve ser maior que 0.");
            }
            return (resultado);
        }
    }
}
