 /* 
                     Nome do programa: FilesEX6_1_3.cs
                     Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)
                     Data: 23/03/2019
                     Entrada(s): nome do arquivo a ser copiado( args [ 0 ]), nome copia( args[1])
                     Para executar e testar digite: 
                     Exemplo: FileEX6_1_3 "nomeArquivo1" "nomeArquivo2"
                     Descricao: renomear o arquivo com o nome dado pela linha de comando, o novo nome nao e' pela LC
                  */
 using System.IO;
 using System;

 namespace Filex6 {
     public class FileEX6_1_3 {
         public static void Main (string[] args) {
             menu ();
             Console.WriteLine ("\n\tPrograma para copiar arquivo...\t");
             copyFile (args[0], args[1]);
         }

         public static void menu () {
             Console.Clear ();
             Console.WriteLine (" Nome do programa: FileEX6_1_3.cs ");
             Console.WriteLine ("Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)");
             Console.WriteLine ();
         }

         public static void copyFile (string path, string path2) {
             if (File.Exists (path + ".txt")) {
                 File.Copy (path + ".txt", path2 + ".txt");
                 Console.WriteLine ("\nArquivo (" + path + ") copiado para (" + path2 + ").");
             } else {
                 Console.WriteLine ("\nERRO: Arquivo nao encontrado.");
             }
         } //end deleteFile( )

     } //end class
 } //end namespace