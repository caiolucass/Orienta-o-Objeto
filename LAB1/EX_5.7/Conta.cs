
// nome do programa: Conta.cs e operaçoesdaConta.cs
//
// programador(es): Wernen Rodrigues e Caio Lucas
// data: 20/02/2019
// entrada(s): - Obtêm a opção do usuário 
// Matricula: 597704 Nome: Wernen Rodrigues Maciel
// Matricula: 604365 Nome: Caio Lucas Ferreira Santos
// saida(s): mostrar as alteraçoes feitas pelo switch
// para executar  e testar digite: 
// Conta.exe operaçoesConta.exe 
// descricao: receObtêm a opção do usuário e chamar o método correspondente, 
//apresenta o resultado e sempre voltar
// ao menu inicial, 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta
{
    class Program
    {
        static int menu()
        {
            Console.WriteLine("\nMatricula: 597704 Nome: Wernen Rodrigues Maciel \nMatricula: 604365 Nome: Caio Lucas Ferreira Santos ");
            Console.WriteLine("\nProgrma Conta.exe ");
            Console.Clear();
            Console.WriteLine("\n Programa conta bancária ");
            Console.WriteLine("\n 1.Depositar na conta ");
            Console.WriteLine("\n 2.Fazer retirada na conta ");
            Console.WriteLine("\n 3.Imprimir saldo na conta ");
            Console.WriteLine("\n 4.Sair do programa. ");
            Console.WriteLine("\n Digite sua opcao: ");

            return (Convert.ToInt32(Console.ReadLine()));
        }

        static void Main(string[] args)
        {
            operaçoesdaConta P = new operaçoesdaConta();

            double saldo = 0;
            double depos = 0;
            double saque = 0;
            int opcao;

            for (opcao = 0; opcao != 4;)
            {
                opcao = menu();

                if (opcao == 1)
                {
                    Console.WriteLine("Digite o valor a ser depositado: " + P.Depositar(saldo, depos));
                    depos = double.Parse(Console.ReadLine());

                    if (depos > 0)
                    {
                        Console.WriteLine("Valor depositado com sucesso.");
                    }
                    else Console.WriteLine("Erro:Impossivel depositar valor negativo.");
                }//fim if

                else if (opcao == 2)
                {
                    Console.WriteLine("Digite o valor a ser retirado:");
                    saque = double.Parse(Console.ReadLine());

                    if (saldo > 0)
                    {
                       P.Sacar(saldo, saque);
                    }
                    else Console.WriteLine("Erro:Valor menor que zero.");
                }//fim if

                else if (opcao == 3)
                {
                    {
                        Console.WriteLine("Imprimindo saldo!" + P.Saldo(saldo));
                    }

                }//fim if

                else if (opcao == 4)
                {
                    Console.WriteLine("\n Programa terminado!");
                    Console.WriteLine("\n Digite qualquer tecla para volta.");
                    Console.ReadKey();
                }//fim if

                else Console.WriteLine("\n Opcao {0} invalida ");
                Console.WriteLine("Digite qualquer tecla para voltar ao menu.");
                Console.ReadKey();

            }//fim for

        }
    }
}


