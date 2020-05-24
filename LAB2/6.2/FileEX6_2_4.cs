/* 
           Nome do programa: Files6_2_4.cs
           Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)
           Data: 23/03/2019
           Entrada(s): nome do diretorio( args [0] )
           Para executar e testar digite: 
           Exemplo: FileEX6_2_4 "/dir"
           Descricao: O Programa remove um diretorio
        */
using System;
using System.IO;

namespace Filex6 {

    public class FileEX6_2_4 {
        public static void Main (string[] args) {
            menu ();
            Console.WriteLine ("\n\tPrograma para remover um diretorio...\t");
            removeDirectory (args[0]);
        }

        public static void menu () {
            Console.Clear ();
            Console.WriteLine (" Nome do programa: FileEX6_2_4.cs ");
            Console.WriteLine ("Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)");
            Console.WriteLine ();
        } //end MENU

        public static void removeDirectory (string path) {
            try {
                if (Directory.Exists (path)) {
                    DirectoryInfo di = new DirectoryInfo (path);
                    di.Delete ();
                    Console.WriteLine ("Diretorio removido com sucesso.");
                } else {
                    Console.WriteLine ("O diretorio nao existe.");
                }
            } catch (Exception) {
                Console.WriteLine ("O diretorio nao pode ser excluido, pois contem subDiretorios.");
            }
        } //end deleteFile( )

    } //end class
} //end namespace