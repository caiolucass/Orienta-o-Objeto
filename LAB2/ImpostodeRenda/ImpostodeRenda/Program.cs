//Nome do programa:Imposto de Renda
//programador(es):Caio Lucas(604365),Wernen Rodrigues(597704),Bernardo Martinez(613081),Cleber Magela(636964)
//Data:22/03/2019
//entrada:sem entrada pela linha de comando(LC)
//saida(s):imprimi que tipo de contribuinte voce é
//saida(s):cadastra e exclui um contribuinte desejado
//saida(s):imprimi a relaçao de contribuintes cadatrados
//saida(s):calcula o seu imposto
//descrição:cadastre um contribuinte, e atraves do menu escolha a sua operaçao desejada na tela
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostodeRenda
{
    class Program
    {
        const int Maxcontribuintes = 100;//maximo de contribuintes suportados
        static Contribuinte[] vetContribuintes = new Contribuinte[Maxcontribuintes];//criar vetor de contribuintes

        static void Main(string[] args)
        {
			Console.clear();
			Console.WriteLine("Caio Lucas(604365),Wernen Rodrigues(597704),Bernardo Martinez(613081),Cleber Magela(636964)");
            int cont = 0;//contador de contribuintes existentes
            int opcao;//gravar a opcao do usuario
            cont++;//conta o numero de contribuintes
            int i;

             for (i = 0; i < vetContribuintes.Length; i++) // percorrer todo o vetor para ver se o contribuinte existe
            {
                vetContribuintes[i] = new Contribuinte();
            }

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
                            Console.WriteLine("3. Exibir os dados de contriuinte.");
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
                            Console.WriteLine("5.Imprimir a relaçao de pessoas juridicas");
                            ImprimirContribuinteFisico(); //chama o metodo de depositos, usando o contador de contas como parâmetro

                            Console.ReadKey();
                            break;

                        case 6:
                            Console.Clear();
                            Console.WriteLine("6. Imprimir a relaçao de pessoas fisicas.");
                            ImprimirContribuinteJuridico();

                            Console.ReadKey();
                            break;

                        case 7:
                            Console.Clear();
                            Console.WriteLine("\n Finalizar o programa \n");
                            Console.WriteLine("Digite qualquer tecla para voltar ao meu.");

                            Console.ReadKey(); break;
                        default:
                            break;

                    }//fim switch
                }
                while (opcao != 7); //fim do while
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
            Console.WriteLine("7.Sair do programa.");
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

                if (contri == "Pessoa Fisica")//verificar se é uma pessoa fisica,caso nao seja salta para a juridica
                {

                    Console.WriteLine("Digite seu salario:");
                    salario = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite seu CPF:");
                    cpf = Console.ReadLine();

                    PessoaFisica aux = new PessoaFisica(nome, endereço, salario, cpf, 1);

                    vetContribuintes[contador - 1] = new PessoaFisica(nome, endereço, salario, cpf, 1);
                    contador++;

                    vetContribuintes[contador - 1].Imposto = aux.CalculoImposto();

                    Console.WriteLine("Alo" , vetContribuintes[contador - 1].Imposto);

                    Console.WriteLine("", aux.CalculoImposto());

                    Console.WriteLine("Conta adicionada com êxito.");
                }
                else
                {
                    Console.WriteLine("Digite seu faturamento:");
                    faturamento = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite seu CNPJ:");
                    cnpj = Console.ReadLine();

                    PessoaJuridica aux = new PessoaJuridica(faturamento, cnpj, endereço,nome, 2);

                    vetContribuintes[contador - 1] = new PessoaJuridica(faturamento, cnpj, endereço, nome, 2);
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

            if ((i = AcharContribuinte(nome)) < Maxcontribuintes)
            {
                if (vetContribuintes[i].AcessorExcluir)
                {
                    vetContribuintes[i].Excluir();
                    Console.WriteLine("Contribuinte excluido com êxito.");
                }
                else
                {
                    Console.WriteLine("Contribuinte ja excluido.");
                }
            }
            else Console.WriteLine("Contribuinte nao existe.");
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
                if (vetContribuintes[posicao].Tipo == 1)
                {

                    Console.WriteLine("nome = {0} cpf = {1} endereço = {2}", vetContribuintes[posicao].Nome, vetContribuintes[posicao].Documento, vetContribuintes[posicao].Endereço);
                }
                else
                {
                    Console.WriteLine("nome = {0} cnpj = {1} endereço = {2}", vetContribuintes[posicao].Nome, vetContribuintes[posicao].Documento, vetContribuintes[posicao].Endereço);
                }
            }
            else Console.WriteLine("Contribuinte nao existe");
        }//fim mostrar dados

        public static void ImprimirContribuinteFisico()  //imprimir dados dos contribuintes fisicos
        {
            int posicao = 0;
            int i;

            for (i = 0; i < vetContribuintes.Length; i++)
            {
                if (vetContribuintes[i].Tipo == 1)
                {
                    Console.WriteLine("nome = {0}  cpf = {1}  endereço = {2}  salario = {3}", vetContribuintes[posicao].Nome, vetContribuintes[posicao].Documento, vetContribuintes[posicao].Endereço, vetContribuintes[posicao].Salario);
                }
            }
        }//fim fisico

        public static void ImprimirContribuinteJuridico() //imprimir dados dos contribuintes juridicos
        {
            int posicao = 0;
            int i;

            for (i = 0; i < vetContribuintes.Length; i++)
            {
                if (vetContribuintes[i].Tipo == 2)
                {
                    Console.WriteLine("nome = 0}  cnpj = {1}  endereço = {2}  salario = {3}", vetContribuintes[posicao].Nome, vetContribuintes[posicao].Documento, vetContribuintes[posicao].Endereço, vetContribuintes[posicao].Salario);
                }
            }
        }//fim juridico


        public static void CalcularImposto()  //calcular os impostos dos clientes
        {
            string contri;
            string nome;
            int posicao; 

            Console.WriteLine("Digite seu tipo de contribuinte:");
            contri = Console.ReadLine();

            if (contri == "Pessoa Fisica")
            {
                Console.WriteLine("Digite o nome da pessoa fisica:");
                nome = Console.ReadLine();

                if ((posicao = AcharContribuinte(nome)) != -1)
                {
                    if (vetContribuintes[posicao].Tipo == 1)
                    {
                        Console.WriteLine("Calculo imposto pessoa fisica:", vetContribuintes[posicao].Imposto);
                    }//fim if
                }
                else
                {

                    Console.WriteLine("Digite o nome da pessoa juridica:");
                    nome = Console.ReadLine();

                    Console.WriteLine("Calculo imposto pessoa juridica:", vetContribuintes[posicao].Imposto);
                }//fim else
            }//fim if

        }//fim calcular imposto 
    }//fim class program
}

