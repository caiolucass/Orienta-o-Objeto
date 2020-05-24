//
// nome do programa: Ex56.cs
//
// programador(es): Caio Lucas(604365),Wernen Rodrigues(597704)
// data: 18/02/2019
// entrada(s): seleção no menu o tipo de conversao e depois o valor da temperatura.
// saida(s): imprime a temperatura convertida de Celsius para Fahrenheit 
// saida(s): imprime a temperatura convertida de Fahrenheit para Celsius
//saida(s):  imprime a temperatura convertida de Kelvin para Celsius
// para executar e testar digite: 
// Ex56.exe  ConversorP.exe 
// descricao: recebe a opção com base em um menu, chama o metodo e apresenta temperatura convertida.
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
        static void Menu()
        {

            Console.Clear();
            Console.WriteLine ("\nMatricula: 597704 Nome: Wernen Rodrigues Maciel \nMatricula: 604365 Nome: Caio Lucas Ferreira Santos ");
			
            Console.WriteLine("\n Programa de conversao de Temperaturas\n");
            Console.WriteLine("1. Converter de Celsius para Fahrenheit ");
            Console.WriteLine("2. Converter de Fahrenheit para Celsius ");
			Console.WriteLine("3. Conveter de kelvin para Celsius "  );
            Console.WriteLine("4. Sair do programa");
            Console.Write("\nDigite Sua Opção: ");
        }
        static void Main(string[] args)
        {
            double temp;
            int opcao;
            ConversorP T = new ConversorP();
			Console.WriteLine ("\nMatricula: 597704 Nome: Wernen Rodrigues Maciel \nMatricula: 604365 Nome: Caio Lucas Ferreira Santos ");
            Console.WriteLine ("\nProgrma Ex56.exe ");
            Menu();                        
       
            for (opcao = 0; opcao != 4;)
            {
                Menu();
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    Console.Write("\nDigite a Temperatura em Celsius: ");
                    temp = double.Parse(Console.ReadLine());
                    Console.WriteLine("\nTemperatura em Fahrenheit: " + T.Fahrenheit(temp));
                    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu ");
                    Console.ReadKey();
                }
                else if (opcao == 2)
                {
                    Console.Write("\nDigite a Temperatura em Fahrenheit: ");
					temp = double.Parse(Console.ReadLine());
					Console.WriteLine("\nTemperatura em Celsius:" + T.Celsius(temp));
                    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu ");
                    Console.ReadKey();
                }
		        else if (opcao == 3)
				{
					Console.WriteLine("\nDigite a Temperatura em Kelvin:");
					temp = double.Parse(Console.ReadLine());
					Console.WriteLine("\nTemperatura em Celsius:"+ T.Kelvin(temp));
					Console.WriteLine("\nDigite qualquer tela para voltar ao menu");
					Console.ReadKey();
				}
                else if (opcao == 4)
                {
                    Console.WriteLine("\nPrograma terminado!!!");
                    Console.WriteLine("\nDigite qualquer tecla para sair ");
                    Console.ReadKey();
                }

                else
                {
                    Console.WriteLine("\nOpcao {0} invalida.", opcao);
                    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu ");
                    Console.ReadKey();
                }
            }            
        }
    }
}

