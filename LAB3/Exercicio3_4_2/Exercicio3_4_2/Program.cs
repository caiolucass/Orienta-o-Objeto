using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Exercicio 3.4.2
//	Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704).


namespace Exercicio3_4_2
{
    class Program
    {
        public static void Main(string[] args)
        { 
			names( );
            Telefone t = new Telefone( );     
            t.ring( );
            t = new TelefoneEletronico( );
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
