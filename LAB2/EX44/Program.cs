using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Arquivo 


/*
programa:  
programador: Wernen, Caio, Bernado e Cleber
data: 20/03/2019
descricao: obter/armazenar dados de uma loja
O programa deve apresentar inicialmente na tela um menu com as seguintes opções:
1. Incluir funcionário.
2. Alterar dados de um funcionário.
3. Excluir funcionário.
4. Imprimir todas as informações de um funcionário.
5. Imprimir a relação de todos os funcionários existentes no sistema
6. Sair do programa

O programa deve obter a opção do usuário, chamar o método correspondente, apresentar o resultado e sempre voltar ao menu inicial, exceto quando for selecionada a opção 6 (Sair do programa).
Deve-se usar as técnicas de encapsulamento e ocultação explicadas nas aulas teóricas.
Criar objetos da classe Conta e simular seu uso.
Outras especificações adicionais podem ser fornecidas pelo professor durante as aulas

entrada(s): opcoes de operacao e no dados dos funcionarios obtidos via teclado 

saida(s): exibe tela menus de opcoes e resultados das operacoes

*/


namespace EX44
{

    class Testa_Conta
    {

        const int MAX = 100;
        static Funcionario[] vetfuncionario = new Funcionario[MAX];


        static void Main(string[] args)
        {

          Console.WriteLine ("Progamadores : Wernen, Caio, Bernado e Cleber");
            int op;
            int cont = 0;


            for (int i = 0; i < vetfuncionario.Length; i++)
            {
                vetfuncionario[i] = new Funcionario();

            }

            do
            {
                menu();
                Console.Write("\nEntre com a opcao: ");
                op = int.Parse(Console.ReadLine());

                //Chamar os metodos dependendo da opcao
                switch (op)
                {

                    case 1:
                        Console.Clear();
                        Console.WriteLine("1. Adicionar Funcionario ");

                        AdicionarFuncionario(ref cont);

                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("2. Mudar dados de um funcionario ");

                        Alterar(ref cont);

                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("3. Excluir uma conta existente");
                        ExcluirFuncionario(ref cont);
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("4. Imprmir todas as informaçaoes dos funcionarios");
                        Imprimir(ref cont);
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("5. Imprmir relaçao de todas os funcionarios");
                        ImprimirRelaçao(ref cont);
                        Console.ReadKey();
                        break;


                    case 6:
                        Console.Clear();
                        Console.WriteLine("\n 6. Finalizar o programa \n");
                        Console.WriteLine("----------------------------------------------");
                        break;

                    default:
                        break;





                } // switch end
            } while (op != 6); // do end  


            Console.ReadKey();

        }// fim do  main


        public static void menu()
        {

            Console.Clear();
            Console.WriteLine("Funcionarios");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("1. Incluir funcionario ");
            Console.WriteLine("2. Alterar dados de um funcionario");
            Console.WriteLine("3. Excluir funcionario");
            Console.WriteLine("4. Imprmir todas as informaçaoes dos funcionarios");
            Console.WriteLine("5. Imprimir a relaçao de todos os funcionarios existentes no sistema");
            Console.WriteLine("6. Sair do programa ");


        }

        static void AdicionarFuncionario(ref int cont)
        {
            string NOME;
            int vendas, minutos;
            string RG, cargo;
            double salario;
            if (cont <= MAX)
            {
                Console.Write("RG do funcionario: ");
                RG = (Console.ReadLine());
                if (( acharRG(RG)) == -1)
                {
                    Console.Write("Nome do funcionario: ");
                    NOME = (Console.ReadLine());


                    Console.Write("Salario: ");
                    salario = double.Parse(Console.ReadLine());
                    Console.Write("\tCargo do funcionario: ");
                   
                    Console.WriteLine("administrativos ou vendedor");
                    cargo = (Console.ReadLine());
                    if (cargo == "vendedor")
                    {
                        Console.Write("vendas totais: ");
                        vendas = int.Parse(Console.ReadLine());
                        vetfuncionario[acharFuncionario(null)] = new Vendedor(NOME, RG, vendas, salario);
                        Console.WriteLine("FUNCIONARIO ADICIONADO COM SUCESSO !!");
                        cont++;
                    }
                    else if (cargo == "administrativos")
                    {
                        Console.Write("minutos  extras ja trabalhadas: ");
                        minutos = int.Parse(Console.ReadLine());
                        vetfuncionario[acharFuncionario(null)] = new Admistrativo(NOME, RG, minutos, salario);
                        Console.WriteLine("FUNCIONARIO ADICIONADO COM SUCESSO !!");
                        cont++;
                    }
                    else Console.WriteLine("ERRO: Cargo inexistente");


                }
                else Console.WriteLine("ERRO: CPF ja cadastrado");
            }
            else Console.WriteLine("ERRO: Limete suportado de funcionarios alcançado");
            Console.WriteLine("Digite qualquer tecla para volta ao menu");
        }
        static public void Alterar(ref int cont)
        {
            string RG, newname, cargo;
            double newsal;
            string newRG;
            int op;
            int pos;

            Console.WriteLine("Qual o RG  do funcionario que deseja vê suas informações");
            RG = (Console.ReadLine());
            if ((pos = acharRG(RG)) != -1)
            {

                if (vetfuncionario[pos].AcessorExcluir)
                {
                    Console.WriteLine("1. Mudar Nome: ");
                    Console.WriteLine("2. Mudar RG: ");
                    Console.WriteLine("3. Novo Cargo: ");
                    Console.WriteLine("4. Reajuste salarial ");
                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {


                        case 1:
                            Console.Write("novo nome: ");
                            newname = (Console.ReadLine());

                            vetfuncionario[pos].MudarNome = newname;
                            break;
                        case 2:
                            Console.Write("Novo RG: ");
                            newRG = (Console.ReadLine());
                            vetfuncionario[pos].MudarRG = newRG;
                            break;
                        case 3:
                            Console.Write("Novo Cargo: ");
                            cargo = (Console.ReadLine());
                            Console.Write("Novo Salario");
                            newsal = double.Parse(Console.ReadLine());
                            if (cargo == "vendedor")
                            {
                                vetfuncionario[pos] = new Vendedor(vetfuncionario[pos].MudarNome, vetfuncionario[pos].MudarRG, vetfuncionario[pos].Extra, newsal);

                                vetfuncionario[pos].MudarSalario = newsal;
                            }
                            else if (cargo == "admistrativo")
                            {
                                vetfuncionario[pos] = new Admistrativo(vetfuncionario[pos].MudarNome, vetfuncionario[pos].MudarRG, vetfuncionario[pos].Extra, newsal);

                                vetfuncionario[pos].MudarSalario = newsal;
                            }
                            else Console.WriteLine("Cargo nao encontrado");
                            break;
                        case 4:
                            double extra;

                            Console.WriteLine("4. Mudar Total de vendas caso seja vendedor ou\t horas extra caso seja admistrativo");
                            extra = double.Parse(Console.ReadLine());
                            vetfuncionario[acharFuncionario(RG)].Extra = extra;
                            break;
                    }

                }
                else Console.WriteLine("Conta excluida");
            }
            else Console.WriteLine("Conta nao existe");

        }

        public static void ExcluirFuncionario(ref int cont)
        {

            string RG;
            int pos;
            Console.WriteLine("Qual o numero do RG do funcionario que deseja excluir?");
            RG = (Console.ReadLine());

            if ((pos = acharRG(RG)) != -1)
            {
                if (vetfuncionario[pos].AcessorExcluir)
                {
                    vetfuncionario[pos].Excluir();
                    Console.WriteLine("Funcionario Excluida com sucesso");
                }
            }
            else Console.WriteLine("Funcionario ja excluido ou nao existe");
            Console.WriteLine("Digite qualquer tecla para voltar para o menu.");
        }





        public static void ImprimirRelaçao(ref int cont)
        {

            //Vendedor aux  = new Vendedor(vetfuncionario[i].MudarNome, vetfuncionario[i].MudarRG, vetfuncionario[i].Extra,vetfuncionario[i].MudarSalario);
            for (int i = 0; i < cont; i++)

            {
                if (vetfuncionario[i].AcessorExcluir)
                {
                    {

                        Console.WriteLine("  {0} = RG: {1} \nNome: {2} \nSalario: {3}\nReajuste de Salario: {4} ",
                            i + 1, vetfuncionario[i].MostrarRG, vetfuncionario[i].ChecarNome, vetfuncionario[i].MudarSalario, vetfuncionario[i].CalculaSalario());
                        Console.WriteLine("------------------");
                    }
                }
                Console.WriteLine("Digite qualquer tecla para voltar para o menu.");
            }
            Console.ReadKey();
        }
        static void Imprimir(ref int cont)
        {
            int pos;
            string RG;
            Console.WriteLine("Qual o RG do Funcionario");
            RG = (Console.ReadLine());
            Vendedor aux = new Vendedor("", "", 0, 0);
            if ((pos = acharRG(RG)) != -1)
            {

                if (vetfuncionario[pos].AcessorExcluir)
                {
                    if (vetfuncionario[pos].MudarCargo == "vendedor")
                    {

                        Console.WriteLine(" [{0}] = RG: {1}\n Nome: {2} \nSalario base: {3} \nReajuste de Salario: {4} ", vetfuncionario[pos].MostrarRG, vetfuncionario[pos].ChecarNome,
                            vetfuncionario[pos].MudarSalario, vetfuncionario[pos].CalculaSalario());

                    }
                    else
                        Console.WriteLine("  RG: {0} \n Nome: {1} \n Salario: {2} \nReajuste de Salario: {3} ", vetfuncionario[pos].MostrarRG, vetfuncionario[pos].ChecarNome,
                            Convert.ToString(vetfuncionario[pos].MudarSalario), Convert.ToString(vetfuncionario[pos].CalculaSalario()));
                }
                else Console.Write("Funcionario excluido ");



            }
            else Console.WriteLine("Funcionario nao encontrado");
            Console.WriteLine("Digite qualquer tecla para voltar para o menu.");
            Console.ReadKey();
        }



        public static int acharFuncionario(string nome)
        {
            for (int i = 0; i < vetfuncionario.Length; i++)
            {
                if (vetfuncionario[i].ChecarNome == nome)
                {
                    return (i);
                }
            }
            return -1;
        }

        public static int acharRG(string RG)
        {
            for (int i = 0; i < vetfuncionario.Length; i++)
            {
                if (vetfuncionario[i].MostrarRG == RG)
                {
                    return (i);
                }
            }
            return -1;
        }


    }// fim da classe Program
}