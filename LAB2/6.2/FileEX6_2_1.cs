        /* 
           Nome do programa: FilesEX6_2_1.cs
           Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)
           Data: 23/03/2019
           Entrada(s): nome do diretorio
           Para executar e testar digite: 
           Exemplo: FileEX6_2_1 "nomeDir"
           Descricao: cria um diretorio a partir do nome na linha de comando
        */
        using System.IO;
        using System;

        namespace Filex6 {

            public class FileEX6_2_1 {
                public static void Main (string[] args) {
                    menu ();
                    Console.WriteLine ("\n\tPrograma para criar diretorio...\t");
                    createDirectory (args[0]);
                }

                public static void menu () {
                    Console.Clear ();
                    Console.WriteLine (" Nome do programa: FileEX6_2_1.cs ");
                    Console.WriteLine ("Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)");
                    Console.WriteLine ();
                } //end MENU

                public static void createDirectory (string path) {
                    if (Directory.Exists (path)) {
                        Console.WriteLine ("O diretorio ja' existe.");
                    } else {
                        DirectoryInfo di = Directory.CreateDirectory (path);
                        Console.WriteLine ("Diretorio criado com sucesso 'as {0}.", Directory.GetCreationTime (path) + "\n");
                    }
                } //end deleteFile( )

            } //end class
        } //end namespace