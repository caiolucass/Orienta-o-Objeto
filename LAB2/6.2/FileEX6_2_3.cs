/* 
           Nome do programa: Files6_2_3.cs
           Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)
           Data: 23/03/2019
           Entrada(s): nome do diretorio( args [0] )
           Para executar e testar digite: 
           Exemplo: FileEX6_2_3 "/dir"
           Descricao: O Programa imprime/ lista os itens no presente diretorio
        */
using System;
using System.IO;

namespace Filex6 {

    public class FileEX6_2_3 {
        public static void Main (string[] args) {
            menu ();
            Console.WriteLine ("\n\tPrograma para listar diretorio...\t");
            listDirectory (args[0]);
        }

        public static void menu () {
            Console.Clear ();
            Console.WriteLine (" Nome do programa: FileEX6_2_3.cs ");
            Console.WriteLine ("Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)");
            Console.WriteLine ();
        } //end MENU

        public static void listDirectory (string path) {
            if (Directory.Exists (path)) {
                DirectoryInfo di = new DirectoryInfo (path);
                foreach (var fi in di.GetFiles ()) {
                    Console.WriteLine (fi.FullName);
                }
            } else {
                Console.WriteLine ("O diretorio nao existe.");
            }
        } //end deleteFile( )

    } //end class
} //end namespace