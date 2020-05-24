//
// nome do programa: Calculadoraclasse.cs
//
// programador(es): Caio Lucas(604365),Wernen Rodrigues(597704)
// data: 18/02/2019
// entrada(s):entrar com o primeiro indice do args, e logo em seguida o operador e por ultimo o numero para efetuar o calculo.
// saida(s): imprime o resultado dda operaçao desejada.
// para executar e testar digite: 
// Calculadoraclasse.exe mat.exe usando a linha de comando(lc) digitando 
// exemplo: calcs.exe  mat.exe 2.5 x 3 
// descricao: recebe a opção com base em um switch definido pelo main e chame a clase Calculadoraclasse.
// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadoraclasse
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(args[0]);
            char opcao = char.Parse(args[1]);
            double num2 = double.Parse(args[2]);
            Console.WriteLine("\nMatricula: 597704 Nome: Wernen Rodrigues Maciel \nMatricula: 604365 Nome: Caio Lucas Ferreira Santos ");
            Console.WriteLine("\nProgrma Calculadoraclasse.exe e mat.cs");
            mat C = new mat();

            switch (opcao)
            {
                case 'x':
                    Console.WriteLine("mult = " + C.Multiplicaçao(num, num2));
                    break;
                case '-':
                    Console.WriteLine("sub = " + C.Subtraçao (num, num2));
                    break;
                case '+':
                    Console.WriteLine("soma = " + C.Adiçao(num, num2) );
                    break;
                case '/':
                    if (num2 == 0)
                        Console.WriteLine("Erro:o denominador e igual a zero");
                    else
                        Console.WriteLine("div = " + C.Subtraçao(num, num2));
                    break;
                default:
                    Console.WriteLine("Operador invalido.");
                    break;
            }
            Console.ReadKey();

        }
    }

}
