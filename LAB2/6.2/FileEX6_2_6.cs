/* 
           Nome do programa: Files6_2_6.cs
           Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)
           Data: 23/03/2019
           Entrada(s): nome do diretorio a ser copiado( args [0] ), nome dir destino( args [1])
           Para executar e testar digite: 
           Exemplo: FileEX6_2_6 "/dir1" "/dir2"
           Descricao: Programa para copiar um diretorio (args[0]) para outro(args[1]) 
        */
using System;
using System.IO;

namespace Filex6 {
    public class FileEX6_2_6 {
        public static void Main (string[] args) {
            menu ();
            Console.WriteLine ("\n\tPrograma para copiar um diretorio (args[0]) para outro(args[1]).\t");
            copyDirectory (args[0], args[1], true);
        }

        public static void menu () {
            Console.Clear ();
            Console.WriteLine (" Nome do programa: FileEX6_2_6.cs ");
            Console.WriteLine ("Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)");
            Console.WriteLine ();
        } //end MENU
        private static void copyDirectory (string pathOrigem, string pathDestino, bool copySubDirs) {
            // pegar os subdiretorios do diretorio de origem
            DirectoryInfo dir = new DirectoryInfo (pathOrigem);
            if (!dir.Exists) {
                throw new DirectoryNotFoundException (
                    "O diretorio de origem nao existe ou nao foi encontrado: " +
                    pathOrigem);
            }

            DirectoryInfo[] dirs = dir.GetDirectories ();
            // Se o destino do diretorio nao existe, cria-lo
            if (!Directory.Exists (pathDestino)) {
                Directory.CreateDirectory (pathDestino);
            }

            // pegar os arquivos no diretorio de origem e copiar para novo local
            FileInfo[] files = dir.GetFiles ();
            foreach (FileInfo file in files) // para cada arquivo 
            {
                //combinar o destino com o nome do arquivo em uma string temporaria
                string temppath = Path.Combine (pathDestino, file.Name);
                file.CopyTo (temppath, false); //copiar cada arquivo para o novo diretorio, false = nao substituir existentes
            }

            // Se existe subDiretorios, copia-los e seus reespectivos conteudos para o novo local
            if (copySubDirs) {
                foreach (DirectoryInfo subdir in dirs) //para cada subdiretorio
                {
                    string temppath = Path.Combine (pathDestino, subdir.Name); //combinar em string temporaria gerando o caminho do diretorio
                    copyDirectory (subdir.FullName, temppath, copySubDirs);
                }
            }
        } //fim metodo copia

    } //end class
} //end namespace