//
// nome do programa: EX33_DistanciaHamming.cs
//
// programador(es): Wernen Rodrigues e Caio Lucas
// data: 20/02/2019
// entrada(s): duas cadeias de n números inteiros através da linha de comando, as quais são separados pelo caractere flag “h”
// Matricula: 597704 Nome: Wernen Rodrigues Maciel
// Matricula: 604365 Nome: Caio Lucas Ferreira Santos
// saida(s): imprime os vetores e a distancia de hamming.
// para executar  e testar digite: 
// EX33_DistanciaHamming.exe 3 4 6 h 3 5 6
// descricao: receba duas sequências denúmeros inteiros através da linha de comando,
// as quais são separados pelo caractere flag “h”,
// armazene em dois vetores e chame um método estático que receba estes vetores retorne a distância
// de Hamming entre tais vetores
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX33_DistanciaHamming
{
    class Program
    {
        static void Main(string[] args)
        {
			
            int j, a =0,b = 0;
            j = args.Length;
            int hamming;
            int[] vet1 = new int[j / 2];
            int[] vet2 = new int[j / 2];
            bool ver = false;
			Console.WriteLine ("\nMatricula: 597704 Nome: Wernen Rodrigues Maciel \nMatricula: 604365 Nome: Caio Lucas Ferreira Santos ");
            Console.WriteLine ("\nProgrma Ex33_DistanciaHamming.exe com " + j +" parametros:\n");
		   
            for (int i = 0; i < j; i++)
            {

                if (args[i] == "h")
                {
                    ver = true;

                }



                else if (ver == false)
                {
                    vet1[i] = int.Parse(args[i]);
                    a++;
                }
                else
                {
                    vet2[b] = int.Parse(args[i]);
                    b++;
                }

            }

            if (a == b)
            {
				
                hamming = Calculo_Hamming(vet1, vet2);




                for (int i = 0; i < vet1.Length; i++)
                {
                    Console.WriteLine("vetor 1[{0}] = {1}", i, vet1[i]);

                }
				Console.WriteLine ("--------------------------------------");
                for (int i = 0; i < vet2.Length; i++)
                {
                    Console.WriteLine("vetor 2[{0}] = {1}", i, vet2[i]);
                }
                Console.WriteLine("Distancia de hamming : " + hamming);
            }
            else Console.WriteLine(" ERRO: tamanho dos vetores diferentes ");
        }
        static int Calculo_Hamming(int[] vet1, int[] vet2)
        {
            int Hamming = 0;
            for (int i = 0; i < vet1.Length; i++)
            {
                if (vet1[i] != vet2[i])
                {
                    Hamming++;
                }
            }
            return (Hamming);
        }

    }
}