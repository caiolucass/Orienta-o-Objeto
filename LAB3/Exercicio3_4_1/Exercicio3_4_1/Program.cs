using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Exercicio 3.4.1
//	Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704).


namespace Exercicio3_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
			names( );
            Telefone t = new TelefoneEletronico( );
            t.ring( );
            Console.ReadLine( );  
        }
		
		public static void names( ){
			Console.WriteLine( );
			Console.WriteLine("Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704).");
			Console.WriteLine( );
		}
		
    }
}
