        /* 
         Nome do programa: FilesEX03.cs
         Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)
         Data: 24/03/2019
         Entrada(s): nome do arquivo1, nome do arquivo2
         Para executar e testar digite: 
         Exemplo: FilesEX03_v2 "nomeDoArquivo1.txt" "nomeArquivo2.txt"
         Descricao: copiar arquivos texto (.txt) e arquivos binários (executáveis, imagens e músicas).  
         */

        using System.Collections.Generic;
        using System.IO;
        using System.Linq;
        using System.Text;
        using System;

        namespace Exemplo03 {
            class Ex3 {
                public static void Main (string[] args) {
                    menu ();
                    Stream entrada = File.Open (args[0], FileMode.Open); // abrir arquivo
                    Stream saida = File.Open (args[1], FileMode.Create); // criar arquivo
                    BinaryReader f1 = new BinaryReader (entrada);
                    BinaryWriter f2 = new BinaryWriter (saida);
                    byte[] buf = new byte[1]; // buffer para armazenar byte(s) lido(s)
                    int lidos; // byte(s) lido(s) ou escritos em cada etapa
                    while (true) {
                        lidos = f1.Read (buf, 0, 1); // ler um byte de cada vez
                        if (lidos < 0) break; // erro no arquivo
                        if (lidos == 0) break; // fim de arquivo
                        f2.Write (buf, 0, lidos); // escrever byte(s) lido(s)
                    }
                    f1.Close (); // fechar arquivo de leitura
                    f2.Close (); // fechar arquivo de escrita
                } //end main 
                public static void menu () {
                    Console.Clear ();
                    Console.WriteLine (" Nome do programa: FilesEX03( 5.5 ).cs ");
                    Console.WriteLine ("Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)");
                    Console.WriteLine ();
                } //end MENU
            } //end class
        } //end namespace