
//
// nome do programa: eleiçao.cs
//
// programador(es): Caio Lucas(604365),Wernen Rodrigues(597704)
// data: 18/02/2019
// entrada(s): numero de votos e o numero do canditado.
// saida(s): imprime o numero de voto de cada candidato e suas porcentagens de votos.
// para executar e testar digite: 
// eleicao.exe 10 19
// exemplo:eleicao.exe usando a linha de comando( lc) 10(numero de votos)19(numero o candidato)
// descricao: recebe a opção com base em um switch atraves do main.
// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eleiçao
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_eleitor = int.Parse(args[0]);
            int opcao = 0;
            int i, j;
            j = args.Length;
            int machado = 0, guimaraes = 0, cecilia = 0;
            Console.WriteLine ("\nMatricula: 597704 Nome: Wernen Rodrigues Maciel \nMatricula: 604365 Nome: Caio Lucas Ferreira Santos ");
            Console.WriteLine ("\nProgrma eleiçao.exe " + num_eleitor +"  eleitores:\n");
            for (i = 0; i < num_eleitor; i++)
            {
                Console.WriteLine("Digite o numero do seu candidato:");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 19:
                        Console.WriteLine("Machado .");
                        machado++;
                        break;
                    case 21:
                        Console.WriteLine("Guimarães Rosa.");
                        guimaraes++;
                        break;
                    case 33:
                        Console.WriteLine("Cecília Meireles.");
                        cecilia++;
                        break;
                    default:
                        Console.WriteLine("Candidatos invalidos!");
                        break;
                }//fim switch
                Console.ReadKey();
            }//fim for
            Console.WriteLine("Machado : "  + machado * 100 / num_eleitor + " % ");
            Console.WriteLine("Guimarães:" + guimaraes * 100 / num_eleitor + " % ");
            Console.WriteLine("Cecilia :"  + cecilia * 100 / num_eleitor + " % ");

        }
    }
}
