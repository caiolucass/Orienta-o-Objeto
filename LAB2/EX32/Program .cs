using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*

programadores:  Wernen, Caio, Bernado e Cleber
data: 20/08/2018
descricao: obter/armazenar dados de contas bancarias
O programa deve apresentar inicialmente na tela um menu com as seguintes opções:
1. Criar um conta nova.
2. Excluir uma conta existente
3. Depositar em uma conta
4. Sacar de em uma conta
5. Imprimir saldo de uma conta
6. Imprimir uma relação das contas existentes informando o numero da conta e o nome do
titular da conta
7. Sair do programa

O programa deve obter a opção do usuário, chamar o método correspondente, apresentar o resultado e sempre voltar ao menu inicial, exceto quando for selecionada a opção 7 (Sair do programa).
Deve-se usar as técnicas de encapsulamento e ocultação explicadas nas aulas teóricas.
Criar objetos da classe Conta e simular seu uso.
Outras especificações adicionais podem ser fornecidas pelo professor durante as aulas

entrada(s): opcoes de operacao e no dados de contas obtidos via teclado 

saida(s): exibe tela menus de opcoes e resultados das operacoes

*/
using System;

namespace Conta_Ex32_LAB2_s218
{

    class Testa_Conta
    {

        const int MAXCONTAS = 100; // máximo de contas suportado
        static Conta[] vetContas = new Conta[MAXCONTAS];  //cria o vetor de contas

        static void Main(string[] args)
        {

            int cont = 0;                 // contador de contas existentes
            int op;                     // obter a opcao  do usuario
                                        // Inserir dados da conta 1 ag 1 saldo 2000 para teste
            cont++; //incrementa o contador de contas
            vetContas[cont - 1] = new Conta(1, cont, " Maria Jose"); // criar conta 1
                                                                     // Deposita 2000 para teste
            vetContas[cont - 1].Deposita(2000);
            // Inserir dados da conta 2 ag 1 saldo 5000 para teste
            cont++;     //incrementa o contador de contas
            vetContas[cont - 1] = new Conta(1, cont, " Mateus Maria"); // criar conta 2
                                                                       // Deposita 5000 para teste
            vetContas[cont - 1].Deposita(5000);
            cont++;

            Console.WriteLine ("Progamadores : Paulo, Wernen, Caio, Bernado e Cleber");

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
                        Console.WriteLine("1. Criar uma nova conta ");

                        CriarConta(ref cont);

                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("2. Excluir uma conta existente");
                        ExcluirConta(ref cont);
                        Console.ReadKey();
                        break;

                    case 3:
                        fazDeposito(ref cont); //chama o metodo de depositos, usando o contador de contas como parâmetro
                        break;

                    case 4:
                        fazSaque(ref cont);   //chama o metodo de saque, usando o contador de contas como parâmetro
                        break;

                    case 5:
                        ImprimeSaldo(ref cont); //chama imprimir saldo, usando o contador de contas como parâmetro
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("6. Imprimir relação das contas existentes informando os dados das contas ");
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("\nOpcao nao implementada - Digite qualquer tecla para sair.");
                        Console.ReadKey();
                        break;

                    case 7:
                        Console.Clear();
                        Console.WriteLine("7. Buscar conta e mostrar informações");
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("\nOpcao nao implementada - Digite qualquer tecla para sair.");
                        Console.ReadKey();
                        break;

                    case 8:
                        Console.Clear();
                        Console.WriteLine("\n 8. Finalizar o programa \n");
                        Console.WriteLine("----------------------------------------------");
                        break;

                    default: break;
                } // switch end
            } while (op != 8); // do end  

            Console.WriteLine("\n Programa terminado");
            Console.WriteLine("\n Aperte qq tecla para sair");
            Console.ReadKey();

        }// fim do  main


        //metodo menu
        //Objetivo: imprimir menu de opcoes
        //Saída: void

        public static void menu()
        {

            Console.Clear();
            Console.WriteLine("Gerencia de contas");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("1. Criar uma nova conta ");
            Console.WriteLine("2. Excluir uma conta existente");
            Console.WriteLine("3. Depositar em uma conta");
            Console.WriteLine("4. Sacar de uma conta");
            Console.WriteLine("5. Imprimir saldo de uma conta");
            Console.WriteLine("6. Imprimir relação das contas existentes informando os dados das contas ");
            Console.WriteLine("7. Buscar conta e mostrar informações");
            Console.WriteLine("8. Finalizar o programa");

        }



        static void CriarConta(ref int contador)
        {
            string titular;

            if (contador <= MAXCONTAS)
            {
                Console.Write("Nome do titular da conta:");
                titular = (Console.ReadLine());
                vetContas[contador - 1] = new Conta(1, contador, titular);
                contador++;
                Console.WriteLine("Conta Criada com sucesso !!!");
                Console.WriteLine("Numero da agencia: 1 " + "\nNumero da conta: " + (contador - 1));


            }
            else Console.WriteLine("ERRO: LIMITE DE CONTA JA ALCANÇADA");

            Console.WriteLine("Digite qualquer tecla para voltar para o menu.");

        }
        static void ExcluirConta(ref int contas)
        {
            int num;
            Console.WriteLine("Qual o numero da conta que deseja excluir");
            num = int.Parse(Console.ReadLine());

            if (num > 0 && num <= contas)
            {
                if (vetContas[num - 1].AcessorExcluir)
                {
                    vetContas[num - 1].Excluir();
                    Console.WriteLine("Conta Excluida com sucesso");
                }
                else Console.WriteLine("Conta ja excluida");
            }
            else Console.WriteLine("Conta nao existe");
            Console.WriteLine("Digite qualquer tecla para voltar para o menu.");
        }

        //Metodo fazDeposito
        //Objetivos: recebe o  numero de contas e faz deposito na conta informada pelo usuario
        //Entrada: contador do vetor de contas
        //Saída: void


        static void fazDeposito(ref int quantasContas)
        {
            int cc;
            double valor, depositado;
            Conta aux;
            Console.Clear();
            Console.WriteLine("Deposito em conta");
            Console.WriteLine("----------------------------------------------");
            Console.Write("Entre com o numero da conta: ");
            cc = int.Parse(Console.ReadLine());
            if (cc > 0 && cc <= quantasContas)
            {
                if (vetContas[quantasContas - 1].AcessorExcluir)
                {
                    Console.Write("Informe  o valor a ser depositado: ");
                    valor = double.Parse(Console.ReadLine());   //ler o valor do depósito
                    aux = vetContas[cc - 1];                      //copia dados do vetor
                    depositado = aux.Deposita(valor);//chama o método de depósito na conta


                    if (depositado < 0)
                        Console.WriteLine(" VALOR DE DEPOSITO INVALIDO, DEPOSITO NÃO EFETUADO! ");
                    else
                        Console.WriteLine("\nValor depositado: " + depositado);
                }
                else Console.WriteLine("Conta excluida");
                
            }
            else
            {
                Console.WriteLine("Conta invalida, operacao nao efetuada! ");
            }
            Console.WriteLine("Digite qualquer tecla para voltar para o menu.");
            Console.ReadKey();

        }

        //Metodo fazSaque
        //Objetivos: recebe o  numero da conta e faz saque na conta informada pelo usuario
        //Entrada: contador do vetor de contas
        //Saída: void
        static void fazSaque(ref int quantasContas)
        {
            int cc;
            double valor, retirado;
            Conta aux;
            Console.Clear();
            Console.WriteLine("Saque em conta");
            Console.WriteLine("----------------------------------------------");
            Console.Write("Entre com o numero da conta: ");
            cc = int.Parse(Console.ReadLine());
            if (cc > 0 && cc <= quantasContas)
            {
                if (vetContas[quantasContas - 1].AcessorExcluir)
                {
                    Console.Write("Digite o valor a ser Sacado: ");
                    valor = double.Parse(Console.ReadLine());   // ler valor do saque
                    aux = vetContas[cc - 1];                     // copia dados do vetor
                    retirado = aux.Retira(valor);  // chama metodo para sacar da conta
                    if (retirado == valor)
                        Console.WriteLine("\nValor retirado: " + valor);
                    else
                        Console.WriteLine(" SALDO INSUFICIENTE OU VALOR INVALIDO, RETIRADA NÃO EFETUADA! ");
                }
                else
                {
                    Console.WriteLine("Conta invalida, operacao nao efetuada! ");
                }
            }
            else Console.WriteLine("Conta excluida");
            
            Console.WriteLine(" Digite qualquer tecla para voltar para o menu.");
            Console.ReadKey();

        }

        // Metodo ImprimeSaldo
        // Objetivos: recebe o  numero de contas e Imprime saldo da conta informada pelo usuario
        // Entrada: contador do vetor de contas
        // Saida: void
        static void ImprimeSaldo(ref int quantasContas)
        {
            int cc;
            Conta aux;
            Console.Clear();
            Console.WriteLine("Imprimir saldo de uma conta");
            Console.WriteLine("----------------------------------------------");
            Console.Write("Entre com o numero da conta: ");
            cc = int.Parse(Console.ReadLine());
            if (cc > 0 && cc <= quantasContas)
            {
                if (vetContas[quantasContas - 1].AcessorExcluir)
                {
                    aux = vetContas[cc - 1];    //copia dados do vetor
                    Console.WriteLine(" SALDO : " + aux.Saldo);
                    Console.WriteLine("Saldo impresso.");
                }
                else Console.WriteLine("Conta excluida");
               
            }
            else
            {
                Console.WriteLine("Conta invalida, operacao nao efetuada! ");
            }


            Console.WriteLine("Digite qualquer tecla para voltar para o menu.");
            Console.ReadKey();

        }
    }// fim da classe Program
}


