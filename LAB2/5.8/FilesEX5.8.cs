/* 
  Nome do programa: FileEX5.8.cs
  
   Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)
   Data: 25/03/2019
   Entrada(s): // args[0]: nome do arquivo de origem (ja existente): arq_origem
              // args[1]: nome do arquivo de destino(a ser criado): arq_destino
   Para executar e testar digite: 
   Exemplo: FileEX5.8.cs "nomeDoArquivo.txt" "nomeDoArquivo2.txt"
   Descricao: programa para copiar arquivos texto (.txt) e arquivos binários (executáveis, imagens e músicas) 
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
// copia_texto_linha_sga_s116.cs
// copia_texto_linha_sga_s116.exe arq_origem arq_destino
namespace copia_texto_linha_s116 {
    class copia_texto_linha_s116 {

        public static void menu () {
            Console.Clear ();
            Console.WriteLine (" Nome do programa: FilesEX5.8.cs ");
            Console.WriteLine ("Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)");
            Console.WriteLine ();
        } //end MENU
        static void Main (string[] args) {
            menu ();
            int i = 0;
            String linha; //para ler ou escrever linhas do ou para o arquivo
            FileInfo fi = new FileInfo (args[0]); // cria objeto Fileinfo para obter atributos do arquivo
            Console.WriteLine ("Arquivo de origem: " + fi.Name); // exibe alguns atributos do arquivo
            Console.WriteLine ("Diretorio: " + fi.Directory);
            Console.WriteLine ("Tamanho do arquivo: " + fi.Length);
            Console.WriteLine ("Arquivo de destino: " + args[1]);
            if (File.Exists (args[0])) //se existe o arquivo...
            { // Aqui se tem certeza que o arquivo existe
                StreamReader entrada = new StreamReader (args[0]); //abrir o arquivo origem
                StreamWriter saida = new StreamWriter (args[1]); //abre arquivo de destino
                linha = entrada.ReadLine (); //ler 1a linha
                while (linha != null) //enquanto houver dados...
                {
                    saida.WriteLine (linha); //escreve no arquivo
                    linha = entrada.ReadLine (); //ler proxima linha
                    i++;
                }
                entrada.Close (); //fecha arquivo de leitura
                saida.Close (); //fecha o arquivo de escrita
            }
            Console.WriteLine ("Bytes copiados: " + i);
        }
    }
}