        /* 
                   Nome do programa: FilesEX6_1_1.cs
                   Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)
                   Data: 23/03/2019
                   Entrada(s): nome do arquivo a ser apagado( args [ 0 ])
                   Para executar e testar digite: 
                   Exemplo: FileEX6_1_1 "nomeArquivo"
                   Descricao: apaga um arquivo com o nome dado pela linha de comando
                */
        using System.IO;
        using System;

        namespace Filex6 {

            public class FileEX6_1_1 {
                public static void Main (string[] args) {
                    menu ();
                    Console.WriteLine ("\n\tPrograma para apagar arquivo...\t");
                    deleteFile (args[0]);
                }

                public static void menu () {
                    Console.Clear ();
                    Console.WriteLine (" Nome do programa: FileEX6_1_1.cs ");
                    Console.WriteLine ("Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)");
                    Console.WriteLine ();
                } 
                public static void deleteFile (string path) {
                    if (File.Exists (path + ".txt")) {
                        File.Delete (path + ".txt");
                        Console.WriteLine ("\nArquivo (" + path + ") deletado.");
                    } else {
                        Console.WriteLine ("\nERRO: Arquivo nao encontrado.");
                    }
                } //end deleteFile( )

            } //end class
        } //end namespace