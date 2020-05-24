/* 
  Nome do programa: FileEX5.9.cs
  
   Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)
   Data: 25/03/2019
   Entrada(s): // args[0]: nome do arquivo com letras minusculas
   Para executar e testar digite: 
   Exemplo: FileEX5.9.cs "nomeDoArquivo.txt" 
   Descricao: O programa le o arquivo (args[0]) e converte os caracteres para letras maiusculas.
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
// copia_texto_linha_sga_s116.cs
// copia_texto_linha_sga_s116.exe arq_origem arq_destino
namespace Exercicio_59 {
    class Ex59 {
        public static void menu () {
            Console.Clear ();
            Console.WriteLine (" Nome do programa: FilesEX5.9.cs ");
            Console.WriteLine ("Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)");
            Console.WriteLine ();
        } //end MENU
        static void Main (string[] args) {
            menu ();
            int i = 0;
            String linha; //para ler ou escrever linhas do ou para o arquivo

            Console.WriteLine ("Programa de teste do sistema de arquivos.");
            Console.WriteLine ("Alunos: Bernardo, Wernen, Caio e Cleber.");

            char[] vet1 = new char[50]; //vetor para salvar leitura do teclado
            string[] vet2 = new string[vet1.Length];
            //criacao do arquivo entrada
            StreamWriter entrada = new StreamWriter (args[0] + ".txt");
            FileInfo fEntrada = new FileInfo (args[0] + ".txt");
            Console.WriteLine ("Arquivo de texto de entrada: " + fEntrada.Name);

            //criacao do arquivo saida( maiusculas )
            StreamWriter saida = new StreamWriter (args[1] + ".txt");
            FileInfo fSaida = new FileInfo (args[1] + ".txt");
            Console.WriteLine ("Arquivo de texto de saida: " + fSaida.Name);

            //entrar com os caracteres pelo teclado e salva em vet1[]
            Console.Write ("Entre com os caracteres: ");
            string leitura = Console.ReadLine ();
            int x = 0;
            do {
                vet1[x] = leitura[x];
                x++;
            } while (leitura[x] != '*');

            //escrever a sequencia de caracteres, lida pelo teclado, no arquivo
            for (int k = 0; k < vet1.Length; k++) {
                entrada.WriteLine (vet1[k]);
            }
            entrada.Close ();

            //abertura do arquivo de entrada e salva dados em vet2[]
            StreamReader entradaLeitura = new StreamReader (args[0] + ".txt");
            //string[] vet2 = new string[vet1.Length];
            linha = entradaLeitura.ReadLine (); //ler 1a linha
            Console.Write ("Caracteres digitados: ");
            while (linha != null) //enquanto houver dados...
            {
                vet2[i] = linha;
                Console.Write (linha);
                linha = entradaLeitura.ReadLine (); //ler proxima linha
                i++;
            } //end while
            entrada.Close ();

            string conv = "";
            Console.Write ("\nCaracteres convertidos: ");
            for (int j = 0; j < vet2.Length; j++) {
                conv = vet2[j].ToUpper ();
                Console.Write (" " + conv);
                saida.WriteLine (conv);
            }
            saida.Close ();

        } //end main( )
    } //end class
} //end namespace