using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Exercicio 3.5
//	Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704).

namespace Exercicio3_5
{
    class Program
    {
        static void Main(string[] args)
        { 
			names( );
            iOperacaoMatematica fazConta;
            int op;
            do
            {
                menu( );
                Console.WriteLine("\nQual a operacao desejada?");
                op = int.Parse( Console.ReadLine( ));
                int a, b;
                switch ( op )
                {
                    case 1:
                        Console.WriteLine("Entre com dois numeros inteiros: ");
                        Console.Write("a: ");
                        a = int.Parse ( Console.ReadLine( ) );
                        Console.Write("b: ");
                        b = int.Parse( Console.ReadLine( ) );
                        
                        fazConta = new Soma( );
                        Console.WriteLine( "Resultado = " +fazConta.calcula(a,b) );
                        break;

                    case 2:
                        Console.WriteLine("Entre com dois numeros inteiros: ");
                        Console.Write("a: ");
                        a = int.Parse ( Console.ReadLine( ) );
                        Console.Write("b: ");
                        b = int.Parse( Console.ReadLine( ) );
                        
                        fazConta = new Subtracao( );
                        Console.WriteLine( "Resultado = " +fazConta.calcula(a,b) );
                        break;

                    case 3:
                        Console.WriteLine("Entre com dois numeros inteiros: ");
                        Console.Write("a: ");
                        a = int.Parse ( Console.ReadLine( ) );
                        Console.Write("b: ");
                        b = int.Parse( Console.ReadLine( ) );
                        
                        fazConta = new Multiplicacao( );
                        Console.WriteLine( "Resultado = " +fazConta.calcula(a,b) );
                        break;

                    case 4:
                        Console.WriteLine("Entre com dois numeros inteiros: ");
                        Console.Write("a: ");
                        a = int.Parse ( Console.ReadLine( ) );
                        Console.Write("b: ");
                        b = int.Parse( Console.ReadLine( ) );
                        
                        fazConta = new Divisao( );
                        Console.WriteLine( "Resultado = " +fazConta.calcula(a,b) );
                        break;

                    case 5:
                        Console.WriteLine("Fim do programa.");
                        Console.ReadKey( );
                        break;
                }
            }
            while (  (op > 0 && op < 5) && op!=5  );
        }
       public static void menu( )
        {
            Console.WriteLine("\n------ OPERACOES ARITMETICAS ------\n");
            Console.WriteLine("1. Soma                  \t 2.Subtracao");
            Console.WriteLine("3. Multiplicacao          \t 4.Divisao");
            Console.WriteLine("5.Sair do programa");
        }
		
				public static void names( ){
			Console.WriteLine( );
			Console.WriteLine("Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704).");
			Console.WriteLine( );
		}
    }
}
