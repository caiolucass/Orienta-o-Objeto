using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// Programa Imposto de Renda
//	Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704).


namespace ImpostodeRenda_arquivo_
{
    class Program
    {
        const int Maxcontribuintes = 100;//maximo de contribuintes suportados
        static Contribuinte[] vetContribuintes = new Contribuinte[Maxcontribuintes];//criar vetor de contribuintes
        const string nomeArquivo = "Contribuinte.txt"; //nome do arquivo dos dados a serem salvos
        static int cont = 0;

        static void Main(string[] args)
        {
			names( );
            int opcao;//gravar a opcao do usuario
            int i;//indice de inicialização do for
            int erro;

            for (i = 0; i < vetContribuintes.Length; i++) // percorrer todo o vetor para ver se o contribuinte existe
            {
                vetContribuintes[i] = new Contribuinte();
            }

            if (File.Exists(nomeArquivo))//ver se o arquivo existe
            {
                erro = LerDados(nomeArquivo);
            }
            else Console.WriteLine("\n Arquivo nao encontrado!");
            Console.WriteLine("\n Programa terminado.");
            Console.WriteLine("\n Aperte qualquer tecla para sair");

            do
            {
                menu();
                Console.Write("\nEntre com a opcao:");
                opcao = int.Parse(Console.ReadLine());

                //Chamar os metodos dependendo da opcao
                switch (opcao)
                {

                    case 1:
                        Console.Clear();
                        Console.WriteLine("1. Incluir um cliente.");

                        IncluirContribuintes(ref cont);
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("2. Excluir um cliente existente.");
                        ExcluirContribuintes();

                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("3. Exibir os dados de contribuinteuinte.");
                        MostrarDados(); //chama o metodo de depositos, usando o contador de contas como parâmetro

                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("4.Calcular o imposto a ser pago.");
                        CalcularImposto(); //chama o metodo de depositos, usando o contador de contas como parâmetro

                        Console.ReadKey();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("5.Imprimir a relação de pessoas fisicas.\n");
                        ImprimirContribuinteFisico();

                        Console.ReadKey();
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("6. Imprimir a relação de pessoas juridicas.\n");
                        ImprimirContribuinteJuridico();

                        Console.ReadKey();
                        break;

                    case 7:
                        Console.Clear();
                        Console.WriteLine("\n Finalizar o programa. \n");
                        Console.WriteLine("Digite qualquer tecla para voltar ao menu.");
                        gravarDados();

                        Console.ReadKey(); break;
                    default:
                        break;

                }//fim switch
            }
            while (opcao != 7);//fim do while
        }//fim main

        public static void menu()
        {
            Console.Clear();
            Console.WriteLine("Imposto de Renda.");
            Console.WriteLine("________________________");
            Console.WriteLine("1.Incluir um contribuinte.");
            Console.WriteLine("2.Excluir um contribuinte.");
            Console.WriteLine("3.Exibir os dados de um contribuinte.");
            Console.WriteLine("4.Calcular o imposto a ser pago pelo contribuinte.");
            Console.WriteLine("5.Imprimir uma relação dos contribuintes Pessoa Física cadastrados.");
            Console.WriteLine("6.Imprimir uma relação dos contribuintes Pessoa Jurídica cadastrados.");
            Console.WriteLine("7.Sair do Programa.");
        }//fim menu

        public static void IncluirContribuintes(ref int contador) //adicionar contribuintes
        {
            string nome;
            string endereço;
            string cpf;
            string cnpj;
            double faturamento;
            double salario;
            string contri;

            if (contador <= Maxcontribuintes)
            {
                Console.WriteLine("Nome do contribuinte:");
                nome = Console.ReadLine();

                Console.WriteLine("Endereço do contribuinte:");
                endereço = Console.ReadLine();

                Console.WriteLine("Digite que tipo de contribuinte voce é:");
                contri = Console.ReadLine();

                if (contri == "PF")//verificar se é uma pessoa fisica
                {

                    Console.WriteLine("Digite seu salário:");
                    salario = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite seu CPF:");
                    cpf = Console.ReadLine();

                    PessoaFisica aux = new PessoaFisica("PF", cpf, nome, endereço, salario);

                    vetContribuintes[contador - 1] = new PessoaFisica("PF", cpf, nome, endereço, salario);
                    contador++;

                    vetContribuintes[contador - 1].Imposto = aux.CalculoImposto();

                    Console.WriteLine("", aux.CalculoImposto());

                    Console.WriteLine("Conta adicionada com êxito.");
                }
                else
                {
                    Console.WriteLine("Digite seu faturamento:");
                    faturamento = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite seu CNPJ:");
                    cnpj = Console.ReadLine();

                    PessoaJuridica aux = new PessoaJuridica("PJ", cnpj, nome, endereço, faturamento);

                    vetContribuintes[contador - 1] = new PessoaJuridica("PJ", cnpj, nome, endereço, faturamento);
                    contador++;

                    vetContribuintes[contador - 1].Imposto = aux.CalculoImposto();

                    Console.WriteLine("Conta adicionada com êxito.");
                }
            }
        }//fim incluir contribuintes

        public static void ExcluirContribuintes() //excluir contribuintes
        {
            string nome;
            int i = 0;
            Console.WriteLine("Digite o nome do contribuinte:");
            nome = Console.ReadLine();

            if ((i = AcharContribuinte(nome)) < Maxcontribuintes && AcharContribuinte(nome)!= -1)
            {
                if (vetContribuintes[i].AcessorExcluir)
                {
                    vetContribuintes[i].Excluir();
                    Console.WriteLine("Contribuinte excluido com êxito.");
                }
                else 
                {
                    Console.WriteLine("Contribuinte já excluido.");
                }
            }
            else Console.WriteLine("Contribuinte não existe.");
            Console.WriteLine("Digite qualquer tecla para voltar ao menu.");
        }//fim excluircontribuintes

        public static int AcharContribuinte(string nome) //achar a posicao de um contribuinte
        {

            for (int i = 0; i < vetContribuintes.Length; i++)
            {
                if (vetContribuintes[i].Nome == nome)
                {
                    return i;
                }
            }
            return -1;
        }
        //fim acharfuncionario

        public static void MostrarDados()  //mostrar dados dos contribuintes
        {
            int posicao;
            string nome;

            Console.WriteLine("Qual o nome do contribuinte?");
            nome = Console.ReadLine();


            if ((posicao = AcharContribuinte(nome)) != -1)
            {
                if (vetContribuintes[posicao].Tipo() == "PF")
                {

                    Console.WriteLine("Nome = {0} CPF = {1} Endereço = {2} Salario = {3}",
                    vetContribuintes[posicao].Nome, vetContribuintes[posicao].Documento, vetContribuintes[posicao].Endereço, vetContribuintes[posicao].Salario);
                }
                else
                {
                    Console.WriteLine("Nome = {0} CNPJ = {1} Endereço = {2} Faturamento = {3}",
                   vetContribuintes[posicao].Nome, vetContribuintes[posicao].Documento, vetContribuintes[posicao].Endereço, vetContribuintes[posicao].Salario);
                }
            }
            else Console.WriteLine("Contribuinte não existe");
        }//fim mostrar dados

        public static void ImprimirContribuinteFisico()  //imprimir dados dos contribuintes fisicos
        {
            int i;

            for (i = 0; i < cont ; i++)
            {
                if (vetContribuintes[i].Tipo() == "PF")
                {
                    Console.WriteLine(" Nome = {0}  CPF = {1} Endereço = {2} Salario = {3}",
                    vetContribuintes[i].Nome, vetContribuintes[i].Documento, vetContribuintes[i].Endereço, vetContribuintes[i].Salario);
                }
            }
        }//fim fisico

        public static void ImprimirContribuinteJuridico() //imprimir dados dos contribuintes juridicos
        {
            int i = 0;

            for (i = 0; i < cont; i++)
            {
                if (vetContribuintes[i].Tipo() == "PJ")
                {
                    Console.WriteLine("Nome = {0} CNPJ = {1} Endereço = {2} Faturamento = {3}",
                    vetContribuintes[i].Nome, vetContribuintes[i].Documento, vetContribuintes[i].Endereço, vetContribuintes[i].Salario);
                }
            }
        }//fim juridico


        public static void CalcularImposto()  //calcular os impostos dos contribuintes
        {
            string contri;
            string nome;
            int posicao;

            Console.WriteLine("Digite seu tipo de contribuinte:");
            contri = Console.ReadLine();

            if (contri == "PF")
            {
                Console.WriteLine("Digite o nome da pessoa fisica:");
                nome = Console.ReadLine();

                if ((posicao = AcharContribuinte(nome)) != -1)
                {
                    if (vetContribuintes[posicao].Tipo() == "PF")
                    {
                        Console.WriteLine("Calculo do imposto da pessoa fisica:" + vetContribuintes[posicao].CalculoImposto());
                    }//fim if
                }
                else
                {

                    Console.WriteLine("Digite o nome da pessoa juridica:");
                    nome = Console.ReadLine();

                    Console.WriteLine("Calculo do imposto da pessoa juridica:" + vetContribuintes[posicao].CalculoImposto());
                }//fim else
            }//fim if
        }//fim calcular imposto 

        static int LerDados(string nomeArquivo)  //ler dados do arquivo
        {
            string nome = "", endereço = "", cp = "";
            double salario = 0;
            string tipo = "";
            String linha = ""; //para ler ou escrever a linha do arquivo
            String [] auxSeparador; //separar dados de cada linha
            StreamReader arqDados = new StreamReader(nomeArquivo);
            linha = arqDados.ReadLine(); //ler a linha do arquivo

            while (linha != null) //enquanto a linha nao estiver vazia
            {
                
                auxSeparador = linha.Split(';'); //separar os dados dos arquivos
                tipo = (auxSeparador[0]);
                cp = (auxSeparador[1]);
                nome = (auxSeparador[2]);
                endereço = (auxSeparador[3]);
                salario = Convert.ToDouble(auxSeparador[4])/100;

                if (tipo == "PF")
                {
                    vetContribuintes[cont] = new PessoaFisica(tipo, cp, nome, endereço, salario);
                    cont++;
                }

                else
                {
                    vetContribuintes[cont] = new PessoaJuridica(tipo, cp, nome, endereço, salario);
                    cont++;
                }

                linha = arqDados.ReadLine();
            }
            arqDados.Close();//fechar o arquivo
            return (0);
        }
        static void gravarDados() //gravar dados no arquivo
        {
            int i;
            Contribuinte aux;
            StreamWriter arqSaida = new StreamWriter("ContribuinteSaida.txt"); // para abir o arquivo
            String linha; // formatar a linha

            for (i = 0; i < cont - 1; i++)
            {
                aux = vetContribuintes[i];

                if (vetContribuintes[i].Tipo() == "PF")
                {
                    linha = "PF;"+ aux.Documento + ";" + aux.Nome + ";" + aux.Endereço + ";" + aux.Salario; 
                }
                else
                {
                    linha = "PJ;" + aux.Documento + ";" + aux.Nome + ";" + aux.Endereço + ";" + aux.Salario;
                }
                arqSaida.WriteLine(linha); //gravar a linha do arquivo
            }
            arqSaida.Close();  //fechar o arquivo
        }
		
				public static void names( ){
			Console.WriteLine( );
			Console.WriteLine("Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704).");
			Console.WriteLine( );
		}
    }
}
