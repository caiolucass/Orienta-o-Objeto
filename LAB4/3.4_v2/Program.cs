using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4
{
    class Program
    {
        const int Maxcontatos = 100;    //maximo de contatos suportados
        static List<Agenda> vetAgenda = new List<Agenda>(Maxcontatos);   //criar vetor de contatos
        static int cont = 0;

        static void Main(string[] args)
        {
            int opcao;//gravar a opcao do usuario
            int i;//indice de inicialização do for
            int erro;

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
                        Console.WriteLine("1. Incluir um contato.");

                        IncluirContato(cont);
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("2. Excluir um contato existente.");
                        ExcluirContato();

                        Console.ReadKey();
                        break;


                    case 3:
                        Console.Clear();
                        Console.WriteLine("3.Mostrar os dados de um contato da agenda\n");
                        MostrarDados();

                        Console.ReadKey();
                        break;


                    case 4:
                        Console.Clear();
                        Console.WriteLine("\n Programa Finalizado. \n");
                        Console.WriteLine("");

                        Console.ReadKey();
                        break;

                    default:
                        break;

                }//fim switch
            }
            while (opcao != 4);//fim do while
        }//fim main

        public static void menu()
        {
            Console.Clear();
            Console.WriteLine("Agenda.");
            Console.WriteLine("________________________");
            Console.WriteLine("1.Incluir um contato.");
            Console.WriteLine("2.Excluir um contato.");
            Console.WriteLine("3.Mostrar os dados de um contato da agenda.");
            Console.WriteLine("4.Sair do Programa.");
        }//fim menu

        public static void IncluirContato(int contador) //adicionar contatos
        {
            string nome;
            string endereço;
            string cpf;
            string cnpj;
            string contri;
            string sexo;
            string data;

            if (contador <= Maxcontatos)
            {
                Console.WriteLine("Nome do contato:");
                nome = Console.ReadLine();

                Console.WriteLine("Endereço do contato:");
                endereço = Console.ReadLine();

                Console.WriteLine("Digite que tipo de pessoa voce é:");
                contri = Console.ReadLine();

                if (contri == "PF")
                {
                    Console.WriteLine("Digite seu sexo:");
                    sexo = (Console.ReadLine());

                    Console.WriteLine("Digite seu CPF:");
                    cpf = Console.ReadLine();

                    PessoaFisica aux = new PessoaFisica("PF", cpf, nome, endereço, sexo);
                    vetAgenda.Insert(contador, aux);    //inserir na Lista na posicao "contador", o obj "aux"
                    vetAgenda[contador].Sexo = aux.Genero();
                    contador++;

                    Console.WriteLine("Contato adicionado com êxito.");
                }
                else
                {

                    Console.WriteLine("Digite seu CNPJ:");
                    cnpj = Console.ReadLine();

                    Console.WriteLine("Digite a data da fundação de sua empresa:");
                    data = Console.ReadLine();

                    PessoaJuridica aux = new PessoaJuridica("PJ", cnpj, nome, endereço, data);
                    vetAgenda.Insert(contador, aux);    //inserir na Lista na posicao "contador", o obj "aux"
                    vetAgenda[contador].Documento = aux.Data;
                    contador++;
        
                    Console.WriteLine("Contato adicionado com êxito.");
                }
            }
        }//fim incluircontato

        public static void ExcluirContato() //excluir Contato
        {
            string nome;
            int i = 0;
            Console.WriteLine("Digite o nome do Contato:");
            nome = Console.ReadLine();

            if ((i = AcharContato(nome)) < Maxcontatos && AcharContato(nome) != -1)
            {
                if (vetAgenda[i].AcessorExcluir)
                {
                    vetAgenda[i].Excluir();
                    vetAgenda.Remove(vetAgenda[i]);
                    Console.WriteLine("Contato excluido com êxito.");
                }
                else
                {
                    Console.WriteLine("Contato já excluido.");
                }
            }
            else Console.WriteLine("Contato não existe.");
            Console.WriteLine("Digite qualquer tecla para voltar ao menu.");
        }//fim excluircontato

        public static int AcharContato(string nome) //achar a posicao de um contato
        {

            for (int i = 0; i < vetAgenda.Count; i++)
            {
                if (vetAgenda[i].Nome == nome)
                {
                    return i;
                }
            }
            return -1;
        }

        public static void MostrarDados()  //mostrar dados dos contatos
        {
            int posicao;
            string nome;

            Console.WriteLine("Qual o nome do contato?");
            nome = Console.ReadLine();


            if ((posicao = AcharContato(nome)) != -1)
            {
                if (vetAgenda[posicao].Tipo() == "PF")
                {

                    Console.WriteLine("Nome = {0} CPF = {1} Endereço = {2} Sexo = {3}",
                    vetAgenda[posicao].Nome, vetAgenda[posicao].Documento, vetAgenda[posicao].Endereço, vetAgenda[posicao].Sexo);
                }
                else
                {
                    Console.WriteLine("Nome = {0} CNPJ = {1} Endereço = {2} Data = {3}",
                   vetAgenda[posicao].Nome,vetAgenda[posicao].Documento,vetAgenda[posicao].Endereço,vetAgenda[posicao].Data);
                }
            }
            else Console.WriteLine("Contato não existe.");
        }//fim mostrar dados
    }
}

