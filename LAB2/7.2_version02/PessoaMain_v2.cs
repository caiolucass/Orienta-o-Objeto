/* 
  Nome do programa: PessoaMain_v2.cs
  
   Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)
   Data: 25/03/2019
   Entrada(s): nome do arquivo // dados de pessoas
   Para executar e testar digite: 
   Exemplo: PessoaMain_v2.cs "nomeDoArquivo.txt"
   Descricao: O programa faz a leitura de dados de uma pessoa por linha do arquivo ".txt", tem opcoes para
   a manipulacao e controle de pessoas no arquivo e no programa. Quando uma alteracao e' feita em uma pessoa no 
   programa, a mesma ocorre no arquivo, e vice-versa.   
*/

using System;
using System.IO;

namespace Ex33Lab2 {
    public class PMain {

        const int MAXPESSOAS = 100; //numero maximo de pessoas suportado no vetor

        static int CONTALINHAS = 0;
        static Pessoa[] vetPessoas; //vetor de Pessoas
        static int cont = 0;
        public static void Main (string[] args) {
            int option = -1, aux = 0;
            string leitura = "";
            vetPessoas = new Pessoa[MAXPESSOAS];

            lerDoArquivo (args[0]);

            do {
                menu ();
                aux = 0;
                //testar se o  valor lido pelo teclado e' um numero para evitar erros
                leitura = Console.ReadLine ();
                if (isNumber (leitura)) {
                    option = int.Parse (leitura);
                } else { option = 7; }

                switch (option) {
                    case 1:
                        Console.WriteLine (" Adicionar uma nova pessoa...\n");
                        novaPessoa ();
                        addToFile (args[0]);
                        break;

                    case 2:
                        //Alterar a data de nascimento de uma pessoa
                        Console.WriteLine ("Alteracao de data ... ");
                        Console.WriteLine ("De qual pessoa deseja alterar a data de nascimento? ");
                        aux = int.Parse (Console.ReadLine ());
                        vetPessoas[aux - 1].mudaData ();
                        mudaNoArquivo_1 (args[0], aux);
                        Console.ReadKey ();
                        break;

                    case 3:
                        //Alterar o peso de uma pessoa 
                        Console.WriteLine ("Alteracao de peso ...");
                        Console.WriteLine ("De qual pessoa deseja alterar o peso? ");
                        aux = int.Parse (Console.ReadLine ());
                        vetPessoas[aux - 1].mudaPeso ();
                        mudaNoArquivo_1 (args[0], aux);
                        Console.ReadKey ();
                        break;

                    case 4:
                        //Alterar a altura de uma pessoa
                        Console.WriteLine ("Alteracao de altura ...");
                        Console.WriteLine ("De qual pessoa deseja alterar a altura? ");
                        aux = int.Parse (Console.ReadLine ());
                        vetPessoas[aux - 1].mudaAltura ();
                        mudaNoArquivo_1 (args[0], aux);
                        Console.ReadKey ();
                        break;

                    case 5:
                        //Informar a idade de uma pessoa
                        Console.WriteLine ("Mostrar a idade de qual pessoa? ");
                        aux = int.Parse (Console.ReadLine ());
                        vetPessoas[aux - 1].informaIdade ();
                        Console.ReadKey ();
                        break;

                    case 6:
                        //Informar o IMC de uma pessoa 
                        Console.WriteLine ("Informar o IMC de qual pessoa? ");
                        aux = int.Parse (Console.ReadLine ());
                        vetPessoas[aux - 1].IMC ();
                        Console.ReadKey ();
                        break;

                    case 7:
                        Console.WriteLine ("\nPrograma terminado!!!");
                        Console.WriteLine ("\nDigite qualquer tecla para sair ");
                        Console.ReadKey ();
                        break;

                    case 8:
                        Console.WriteLine ("\nMostrar Pessoas registradas");
                        Pessoa p = new Pessoa ();
                        p.mostrar (vetPessoas, cont);
                        Console.ReadKey ();
                        break;

                    default:
                        Console.Write ("Opcao invalida!!");
                        Console.WriteLine ("\nDigite qualquer tecla para voltar ao menu ");
                        Console.ReadKey ();
                        break;

                } //end switch 
            } while (option != 7);

        } //end main( )

        public static void mudaNoArquivo_1 (string path, int numPessoa) //INCOMPLETO
        { //metodo para atualizar alteracoes feitas, no arquivo

            StreamReader arq = new StreamReader (path);
            String[] linhas = File.ReadAllLines (path);
            String[] tmp = linhas[numPessoa - 1].Split (':');
            int i = 0;

            tmp[0] = vetPessoas[numPessoa - 1].Dia.ToString ();
            tmp[1] = vetPessoas[numPessoa - 1].Mes.ToString ();
            tmp[2] = vetPessoas[numPessoa - 1].Ano.ToString ();
            tmp[3] = vetPessoas[numPessoa - 1].Peso.ToString ();
            tmp[4] = vetPessoas[numPessoa - 1].Altura.ToString ();

            linhas[numPessoa - 1] = tmp[0] + ':' + tmp[1] + ':' + tmp[2] + ':' + tmp[3] + ':' + tmp[4];

            Console.ReadKey ();
            arq.Close ();

            StreamWriter sr = new StreamWriter (path);
            do {
                sr.WriteLine (linhas[i]);
                i++;
            } while (i < linhas.Length);
            sr.Close ();
        }

        public static void novaPessoa () {
            cont++;
            Console.WriteLine ("Entre com os dados da pessoa (" + cont + "): ");
            Console.WriteLine ("Data de nascimento... ");
            Console.Write ("Dia: ");
            int d = int.Parse (Console.ReadLine ());
            Console.Write ("Mes: ");
            int m = int.Parse (Console.ReadLine ());
            Console.Write ("Ano: ");
            int a = int.Parse (Console.ReadLine ());
            Console.WriteLine ("Agora informe o peso e a altura...");
            Console.Write ("Peso: ");
            double p = double.Parse (Console.ReadLine ());
            Console.Write ("Altura: ");
            double alt = Convert.ToDouble (Console.ReadLine ());
            vetPessoas[cont - 1] = new Pessoa (d, m, a, p, alt);
        }

        public static void addToFile (string path) {
            StreamWriter sr = File.AppendText (path); //append = acrescentar novas infos.

            string nova = "";
            nova = vetPessoas[cont - 1].Dia.ToString () + ':' +
                vetPessoas[cont - 1].Mes.ToString () + ':' +
                vetPessoas[cont - 1].Ano.ToString () + ':' +
                vetPessoas[cont - 1].Peso.ToString () + ':' +
                vetPessoas[cont - 1].Altura.ToString ();

            sr.WriteLine (nova);
            sr.Close (); //fecha o arquivo de escrita
        }

        public static bool isNumber (string s) {
            bool r = false;
            for (int i = 0; i < s.Length; i++) {
                if (s[i] >= '0' && s[i] <= '9') {
                    r = true;
                } else {
                    r = false;
                    return r;
                }
            } //end for
            return r;
        } //end isNumber

        public static void menu () {
            Console.Clear( );
            Console.WriteLine( " Nome do programa: PessoaMain_v2.cs " );
            Console.WriteLine ("Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)");
            Console.WriteLine( );
            Console.WriteLine ("\n 1. Incluir uma nova pessoa.");
            Console.WriteLine (" 2. Alterar a data de nascimento de uma pessoa cadastrada.");
            Console.WriteLine (" 3. Alterar o peso de uma pessoa cadastrada.");
            Console.WriteLine (" 4. Alterar a altura de uma pessoa cadastrada");
            Console.WriteLine (" 5. Informar a idade atual de uma pessoa cadastrada.");
            Console.WriteLine (" 6. Informar IMC de uma pessoa cadastrada.");
            Console.WriteLine (" 7. Sair do programa.");
            Console.WriteLine (" 8. Mostrar pessoas registradas.\n");
            Console.Write ("Digite sua opcao: ");
        } //end MENU

        //metodo para contar a quantidade de linhas escritas em um arquivo
        public static void lineCount (string path) {
            String linha = "";
            if (File.Exists (path)) //se existe o arquivo...
            { // Aqui se tem certeza que o arquivo existe
                StreamReader entrada = new StreamReader (path); //abrir o arquivo origem
                linha = entrada.ReadLine (); //ler 1a linha
                while (linha != null) //enquanto houver dados...
                {
                    linha = entrada.ReadLine (); //ler proxima linha
                    CONTALINHAS++;
                }
                entrada.Close (); //fecha arquivo de leitura
            }
        }

        public static void lerDoArquivo (string path) {
            String linha = "";
            lineCount (path);
            string[] tmp = new string[CONTALINHAS]; //arranjo para split ( tamanho = quant. linhas no arquivo )
            int i = 0, d, m, a;
            double p, alt;

            if (File.Exists (path)) //se existe o arquivo...
            { // Aqui se tem certeza que o arquivo existe
                StreamReader entrada = new StreamReader (path); //abrir o arquivo origem
                linha = entrada.ReadLine ();
                do {
                    tmp = linha.Split (':'); //cada pedaco de string em uma posicao do array tmp
                    try {
                        d = int.Parse (tmp[0]);
                        m = int.Parse (tmp[1]);
                        a = int.Parse (tmp[2]);
                        p = double.Parse (tmp[3]);
                        alt = double.Parse (tmp[4]);
                        cont++; //+ uma pessoa
                        vetPessoas[cont - 1] = new Pessoa (d, m, a, p, alt);
                    } catch (Exception) { }
                    //para a proxima pessoa na proxima possicao do vetor vetPessoas[]
                    linha = entrada.ReadLine (); //ler a proxima linha e repetir o processo
                    if (linha != null) { //se existe dados na linha
                        i++; //passar para a proxima possicao do vetor
                    } else { //se leu linha em branco, para o while 
                        i = CONTALINHAS;
                    }
                } while (linha != null && i < CONTALINHAS); //enquanto houver dados no arquivo
                entrada.Close ();
            } //end if File.Exists()
            else {
                Console.WriteLine ("ERRO: Arquivo nao encontrado. ");
            }
        }

    } //end class PMain
} //end namespace