using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Exercicio 3.2
//	Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704).


namespace Exercicio3_2
{
    public class Program 
    {
        public static void Main( string [] args )
        {
			names( );
            Conta corrente = new ContaCorrente( );
            Conta poupanca = new ContaPoupanca( );
            GeradorDeExtrato g = new GeradorDeExtrato( );
            g.imprimeExtratoBasico(corrente); //saldo 0
            g.imprimeExtratoBasico(poupanca); //saldo 0
            Console.WriteLine( );
            corrente.Saldo = 150;
            poupanca.Saldo = 250;
            g.imprimeExtratoBasico(corrente); //saldo 150
            g.imprimeExtratoBasico(poupanca); //saldo 250
            Console.WriteLine( );
            Console.ReadKey( );

        }//fim main( )
		
		public static void names( ){
			Console.WriteLine( );
			Console.WriteLine("Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704).");
			Console.WriteLine( );
		}
    }//end class Program
}//end namespace
