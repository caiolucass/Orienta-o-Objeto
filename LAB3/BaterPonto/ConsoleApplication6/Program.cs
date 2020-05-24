using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{

    class Program
    {
        const int MAX = 100;
        static Funcionario[] vetfuncionario = new Funcionario[MAX];
        static void Main(string[] args)
        {
			names( );
            //for ( int i =0; i < vetfuncionario.Length; i++ )
            //{
            //    vetfuncionario[i] = ;
            //}
            int cont = 0;
            int op;
            //if (vetfuncionario[0].GetType() == typeof (Telefonista))
           do {  
                menu();
                Console.Write("\nEntre com a opcao: ");
                op = int.Parse(Console.ReadLine());



                switch (op)
                {

                    case 1:
                        Console.Clear();
                        Console.WriteLine("1 -  Incluir Funcionario ");

                        AdicionarFuncionario(ref cont);

                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("2 -  Bater ponto");
                        BaterPonto(ref cont);
                        Console.ReadKey();
                      
                        break;
                    case 3:
                        Console.WriteLine("3 - Registro de entrada e saida");
                        Registro(cont);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("4 - Sair do programa");
                        break;
                    default:
                        break;



                }

                
            } while (op != 4) ;


            Console.ReadKey();
        }

        public static void menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Adicionar Funcionario");
            Console.WriteLine("2 - Bater Ponto");
            Console.WriteLine("3 - Registro de entrada e saida");
            Console.WriteLine("4 - Sair do programa");
        }
        static void AdicionarFuncionario(ref int cont)
        {
            int codigo;
            char cargo;
            Console.Write("Codigo do novo funcionario: ");
            codigo = Convert.ToInt32(Console.ReadLine());
            if ((acharFuncionario(cont,codigo)) == -1)
            {
                Console.WriteLine("Cargo do funcionario ");
                Console.WriteLine("T - Telefonista G-Gerente");
                cargo = Convert.ToChar(Console.ReadLine().ToUpper());

                if (cargo == 'T')
                {
                    vetfuncionario[cont] = new Telefonista(codigo);
                    cont++;
                    Console.WriteLine("FUNCIONARIO REGISTRADO COM SUCESSO!!");
                }
                else if (cargo == 'G')
                {
                    vetfuncionario[cont] = new Admistrativo
                    {
                        Codigo = codigo
                    };
                    cont++;
                    Console.WriteLine("FUNCIONARIO REGISTRADO COM SUCESSO!!");
                }
                else Console.WriteLine("Cargo nao existe");

            }

            else Console.WriteLine("Codigo ja utilizado");


        }

        static void BaterPonto(ref int cont)
        {

            int codigo;
            int contador;
            char turno;
            Console.Write("Codigo do funcionario: ");
            codigo = Convert.ToInt32(Console.ReadLine());

            if ((contador = acharFuncionario(cont,codigo)) != -1)
            {

                Console.WriteLine("SAIDA OU ENTRADA? ");
                Console.WriteLine(" S - saida  E - entrada");
                turno = Convert.ToChar(Console.ReadLine().ToLower());
                if (turno == 's')
                {

                    ControleDePonto.RegistraSaida(vetfuncionario[contador]);
                    Console.WriteLine("HORARIO REGISTRADO");
                }
                else if (turno == 'e')
                {
                    ControleDePonto.RegistraEntrada(vetfuncionario[contador]);
                    Console.WriteLine("HORARIO REGISTRADO");
                }
                else Console.WriteLine("ERRO: Comando nao identificado");
            }
            else Console.WriteLine("Funcionario nao existe");
        }
        static void Registro(int cont)
        {
            for (int i = 0; i < cont; i++)
            {
                if (vetfuncionario[0].GetType() == typeof(Telefonista))
                    Console.WriteLine("Telefonista " + vetfuncionario[i].Codigo + "\nENTRADA:" + vetfuncionario[i].Entrada + "\nSAIDA:" + vetfuncionario[i].Saida);
                else
                    Console.WriteLine("Gerente " + vetfuncionario[i].Codigo + "\nENTRADA:" + vetfuncionario[i].Entrada + "\nSAIDA:" + vetfuncionario[i].Saida);
            }
        }
        static int acharFuncionario(int cont, int codigo)
        {
            for (int i = 0; i < cont; i++)
            {
                if (vetfuncionario[i].Codigo == codigo)
                {
                    return (i);
                }
            }
            return -1;
        }
		
		public static void names( ){
			Console.WriteLine( );
			Console.WriteLine("Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704).");
			Console.WriteLine( );
		}

    }
}
