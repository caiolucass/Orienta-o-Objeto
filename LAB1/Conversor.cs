//
// nome do programa: Conversor.cs
//
// programador(es): Caio Lucas(604365),Wernen Rodrigues(597704)
// data: 18/02/2019
// entrada(s):selecione a opcao desejada atraves do void main.
// saida(s): imprime a temperatura convertida de Celsius para Fahrenheit 
// saida(s): imprime a temperatura convertida de Fahrenheit para Celsius
// saida(s): imprime a temperatura convertida de Kelvin para Celsius
// para executar e testar digite: 
// Conversor.exe usando a linha de comando(lc)digitando a temperatura e o grau dejesado
// exemplo: Conversor.exe 10 C
// descricao: recebe a opção com base em um switch definido pelo main.
// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            int grau = int.Parse(args[0]);
            char opcao = char.Parse(args[1].ToUpper()); 
            Console.WriteLine ("\nMatricula: 597704 Nome: Wernen Rodrigues Maciel \nMatricula: 604365 Nome: Caio Lucas Ferreira Santos ");
            Console.WriteLine ("\nProgrma Conversor.exe");
            switch (opcao)
            {
                case 'C':
                    Console.WriteLine("Celsius para Farhenrenit :" + (grau - 132/1.8 ));
                    break;
                case 'F':
                    Console.WriteLine("Farhenrenit para Celcius: " + grau * 1.8 +32 );
                    break;
                case 'K':
                    Console.WriteLine("Kelvin para Celsius : " + (grau - 273.15));
                    break;
                default:
                    Console.WriteLine("Conversão de temperautura invalida!");
                    break;
            }
            Console.ReadKey();

        }
    }
}
