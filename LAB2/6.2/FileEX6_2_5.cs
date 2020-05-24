/* 
           Nome do programa: Files6_2_5.cs
           Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)
           Data: 23/03/2019
           Entrada(s): nome do diretorio( args [0] )
           Para executar e testar digite: 
           Exemplo: FileEX6_2_5 "/dir"
           Descricao: O Programa renomear um diretorio
        */
using System;
using System.IO;

namespace Filex6 {
    public class FileEX6_2_5 {
        public static void Main (string[] args) {
            menu ();
            Console.WriteLine ("\n\tPrograma para renomear um diretorio...\t");
            renameDirectory (args[0]);
        }
        public static void menu () {
            Console.Clear ();
            Console.WriteLine (" Nome do programa: FileEX6_2_5.cs ");
            Console.WriteLine ("Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)");
            Console.WriteLine ();
        } //end MENU

        public static void renameDirectory (string path) {
            if (Directory.Exists (path)) {
                DirectoryInfo di = new DirectoryInfo (path);
                //pegar o caminho do diretorio a ser renomeado  
                int way = (path.Length - (di.Name).Length); //pegar a quantidade de caracteres no diretorio
                string caminho = ""; //guardar o diretorio Exemplo = ( "C:\" ) // way = 3
                for (int x = 0; x < way; x++) {
                    caminho += path[x]; // 'C'  // ':'  // '\'
                }
                Console.WriteLine ("\nEntre com o novo nome do diretorio: ");
                string newName = caminho + Console.ReadLine ();
                di.MoveTo (newName);
                Console.WriteLine ("Diretorio renomeado com sucesso.");
            } else {
                Console.WriteLine ("O diretorio nao existe.");
            }
        } //end renameFile( )
    } //end class
} //end namespace