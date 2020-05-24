using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Exercicio 2.1
//	Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704).


namespace Exercicio2_1
{
    class Program
    {
        static void Main(string[] args)
        {
			names( );
            Televisor tv = new Televisor( );
            tv.ligar( );    //ligar TV
            tv.aumentarVolume( );   //volume 1
            tv.diminuirVolume( );  //volume 0
            tv.subirCanal( );  //canal 2
            tv.subirCanal( );  //canal 3
            tv.baixarCanal( ); //canal 2
            tv.desligar( ); //desligar TV
            tv.aumentarVolume( );   //nao aumenta, tv esta' desligada
            tv.subirCanal( );   //nao aumenta tv esta' desligada
            Console.WriteLine( );

            DVD dvd = new DVD( );
            dvd.ligar( );
            dvd.desligar( );
            Console.WriteLine("Pressione qualquer tecla para finalizar.");
            Console.ReadKey( );
        }
		
			public static void names( ){
			Console.WriteLine( );
			Console.WriteLine("Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704).");
			Console.WriteLine( );
		}
    }
}
