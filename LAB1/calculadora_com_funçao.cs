
//
// nome do programa: Calculadoracomfuncao.cs
//
// programador(es): Caio Lucas(604365),Wernen Rodrigues(597704)
// data: 18/02/2019
// entrada(s):selecione a opcao desejada atraves do void main.
// saida(s): imprime o resultado dda operaçao desejada.
// para executar e testar digite: 
// Conversor.exe usando a linha de comando(lc) digitando 
// exemplo: Conversor.exe 10 C
// descricao: recebe a opção com base em um switch definido pelo main.
// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_com_funçao
{
    class Program
    {
        static double soma(double num, double num2)
        {
            return num + num2;
        }

        static double mult(double num, double num2)
        {
            return num * num2;
        }

        static double div(double num, double num2)
        {
            return num / num2;
        }

        static double sub(double num, double num2)
        {
            return num - num2;
        }

        static void Main(string[] args)
        {
            double num = double.Parse(args[0]);
            double num2 = double.Parse(args[2]);
            char opcao = char.Parse(args[1].ToLower());

           Console.WriteLine ("\nMatricula: 597704 Nome: Wernen Rodrigues Maciel \nMatricula: 604365 Nome: Caio Lucas Ferreira Santos ");
            Console.WriteLine ("\nProgrma calculadora_com_funçao.exe");
            switch (opcao)
            {
                case 'x':
                    Console.WriteLine("mult = " + mult(num, num2));
                    break;
                case '-':
                    Console.WriteLine("sub = " + sub(num, num2));
                    break;
                case '+':
                    Console.WriteLine("soma = " + soma(num, num2));
                    break;
                case '/':
                    if (num2 == 0)
                        Console.WriteLine("Erro:o denominador e igual a zero");
                    else
                        Console.WriteLine("div = " + div(num, num2));
                    break;
                default:
                    Console.WriteLine("Operador invalido.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
