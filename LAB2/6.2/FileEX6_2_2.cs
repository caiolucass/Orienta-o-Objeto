/* 
           Nome do programa: Files6_2_2.cs
           Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)
           Data: 23/03/2019
           Entrada(s): sem entrada pelo terminal
           Para executar e testar digite: 
           Exemplo: FileEX6_2_2
           Descricao: O Programa imprime o nome absoluto do diretorio de trabalho
        */

using System;
using System.IO;

namespace Filex6 {

    public class FileEX6_2_2 {
        public static void Main (string[] args) {
            string dir = @"C:\Users\berna\Documents\PUCSG\POO\LAB 2 pt 1\LAB 2 pt 2\Files 6.2";
            menu( );
            Console.WriteLine ("\n\tPrograma para imprimir nome absoluto do diretorio de trabalho...\t");

            printDirectory (dir);
        }

        public static void menu () {
            Console.Clear ();
            Console.WriteLine (" Nome do programa: FileEX6_2_2.cs ");
            Console.WriteLine ("Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)");
            Console.WriteLine ();
        } //end MENU

        public static void printDirectory (string dir) {
            if (Directory.Exists (dir)) {
                DirectoryInfo di = new DirectoryInfo (dir);
                Console.WriteLine ("\n Nome do diretorio = {0}", di.FullName + ".\n");
            } else {
                Console.WriteLine ("O diretorio nao existe.");
            }
        } //end deleteFile( )

    } //end class
} //end namespace