//
// nome do programa: Ex32_ordenaçao.cs
//
// programador(es): Wernen Rodrigues e Caio Lucas
// data: 20/02/2019
// entrada(s): n numeros inteiros através da linha de comando 
// Matricula: 597704 Nome: Wernen Rodrigues Maciel
// Matricula: 604365 Nome: Caio Lucas Ferreira Santos
// saida(s): imprime o vetor de números ordenado, o maior, menor e media de seus valores
// para executar  e testar digite: 
// Ex32_ordenaçao.exe 3 4 6
// descricao: recebe n numeros inteiros através da linha de comando,
// armazena em um vetor e chama um método estático que receba estes
// números inteiros (armazenados no vetor),  e retorna   o maior 
// deles e a média de seus valores.
//

using System;
using System.Text;

namespace Ex32_ordenaçao
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int maior = 0, media = 0, menor = 0; // inicializacao de variaveis para calculo 
            int i, j; // inicializacao de variaveis contadoras
            j = args.Length; // numero de parametros recebidos na LC
            int[] vetor = new int[j]; // alocacao de vetor para receber numeros inteiros
			Console.WriteLine (" Matricula: 597704 Nome: Wernen Rodrigues Maciel \nMatricula: 604365 Nome: Caio Lucas Ferreira Santos ");
			Console.WriteLine ("\nProgrma Ex32_ordenaçao.exe com " + j + " parametros:\n");
		    
            for (i = 0; i < j; i++)
            { // mostra e converte parametros recebidos na LC
                Console.Write("args[" + i + "] = " + args[i]);
                Console.Write(" args[{0}] = {1}", i, args[i]);
                vetor[i] = int.Parse(args[i]); // converte parametro recebidos na LC de string para inteiro e armazena no vetor
                Console.WriteLine(" vetor[{0}] = {1}", i, vetor[i]); // mostra vetor

            }
            Operar_valores(vetor, ref maior, ref menor, ref media); // chama metodo para fazer as operacoes solicitadas
            Console.WriteLine("\nMaior : " + maior);   // mostra maior valor
            Console.WriteLine("\nMedia : " + media); // mostra media dos valores
            Console.WriteLine("\nMenor : " + menor); // falta implementar
            Console.WriteLine("\nVetor em ordem crecente");
            for (i = 0; i < j; i++)
            {
               
                Console.WriteLine(" vetor[{0}] = {1}", i, vetor[i]);
            }
           
            Console.ReadKey();
        }

        static void Operar_valores(int[] vet, ref int maior,ref int  menor, ref int media)
        {
            // metodo imcompleto - deve ser completado pelo aluno
            int soma = 0;
            media = 0; maior = vet[0] ; menor = vet[0];
            int aux = 0;
            for (int i = 0; i < vet.Length; i++)
            {
                soma += vet[i]; // acumular valores
                if (vet[i] > maior) // atualizar maior valor
                {
                    maior = vet[i];
                }
            }
            for (int i = 0; i < vet.Length; i++)
            {
             
                if (vet[i] < menor) 
                {
                    menor = vet[i];
                }
            }
            for (int i = 0; i < vet.Length; i++)
            {

                for (int j = 0; j < vet.Length; j++)
                {
                    if (vet[i] < vet [j])
                    {
                        aux = vet[i];
                        vet[i] = vet[j];
                        vet[j] = aux; 
                    }

                }
               
            }
            media = soma / vet.Length; // calcular media dos valores
        }
    }
}