using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Exercicio 3.3
//	Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704).

namespace Exercicio3_3
{
#pragma warning disable	//desativar avisos de variaveis nao utilizadas
    public class Program 
    {
        const int MAXCONTAS = 100; // número máximo de contas suportado 
        static Conta[ ] vetContas = new Conta[MAXCONTAS]; //vetor de contas 
        static int cont = 0;  //contas criadas
        static Conta c;
        public static void Main( string [] args )
        { 
			names( );
            int o;
            do {
            menu( );
            o = int.Parse( Console.ReadLine( ) );
            switch (o)
            { 
                case 1: 
                    novaConta( );
                break;

                case 2: 
                    excluirConta( );
                break;

                case 3: 
                    //depositar
                break;

                case 4:
                    //sacar
                break;
               
                case 5:
                    //imprimeExtrato
                break;        

                case 6:
                    print( );
                break;

                case 7:
                    Console.WriteLine("Fim do programa.");
                break;

                default:
                break;
            }
            }while( ( o > 0 && 0 < 8 ) && o != 7);
        }//fim main( )

        public static void menu ( )
        {
            Console.WriteLine("------- BANCO PUC -------");
            Console.WriteLine("1. Criar uma conta nova.");
            Console.WriteLine("2. Excluir uma conta existente.");
            Console.WriteLine("3. Depositar em uma conta.");
            Console.WriteLine("4. Sacar de em uma conta.");
            Console.WriteLine("5. Imprimir o extrato de uma conta.");
            Console.WriteLine("6. Imprimir uma relação das contas existentes informando o número da conta e o nome do titular da conta.");
            Console.WriteLine("7. Sair do programa.");  
            Console.WriteLine("Escolha uma opcao...");
        }

        public static void novaConta( )
        { 
          Console.Clear( );
          Console.WriteLine("Qual o tipo de conta a ser criada? ");
          Console.WriteLine("1. Conta Poupanca \t2.Conta Corrente");
          int tipo = int.Parse( Console.ReadLine( ) );
          Console.WriteLine(  );
          
          if ( tipo == 1 )
          {
                c = new ContaPoupanca( );
          }
            else if ( tipo == 2)
            {
                c = new ContaCorrente( );
            }
          Console.WriteLine("Entre com o seu nome completo por favor: ");
          string name = Console.ReadLine( );
          c.Nome = name;
          Random r = new Random( );
          c.NumConta = r.Next(0,100);  // num da conta
          c.Saldo = 0.0;
          Console.WriteLine("Conta "+ c.NumConta +" Ag. " + c.Agencia + " criada com sucesso.");

          Console.WriteLine("Qual a agencia escolhida para a sua conta? (1) ou (2)");
          string ag = Console.ReadLine( ) ;
          string file = ("agencia"+ag+".txt");
            if ( File.Exists(file)) 
            {
                StreamWriter s = new StreamWriter(file,true);
                s.WriteLine(c.Nome+";"+"000"+ag+";"+c.NumConta+";"+c.TipoConta+";"+c.Saldo);
                s.Close( );
            }
            else
            {
                StreamWriter sr = new StreamWriter(file);
                sr.WriteLine(c.Nome+";"+"000"+ag+";"+c.NumConta+";"+c.TipoConta+";"+c.Saldo);
                sr.Close( );
            }
          vetContas[cont] = c;
          cont++;
        }//end novaConta( )

        /* O metodo cria uma Lista<string> com todos os dados do arquivo,
         * Remove o item desejado e atualiza o arquivo e o vetor de Contas
         */
        public static void excluirConta( )
        {
            Console.WriteLine("Informe o nome completo do titular da conta a ser excluida: ");
            string n = Console.ReadLine( );
            Console.WriteLine("Informe o numero da agencia: ");
            int a = int.Parse( Console.ReadLine( ) );
            string file = ("agencia"+a+".txt");
            string[]s = File.ReadAllLines(file);
            List<string> lista = new List<string>( );
            foreach( string str in s ) lista.Add(str);
            int aux = 0;    //guardar posicao da remocao
            for ( int i = 0; i < lista.Count; i++)
            {
                if ( lista[i].Contains(n))   //procurar pelo nome na lista
                {
                    lista.Remove(lista[i]);  //se encontrado, remover todos dados nesse nome
                    aux = i;
                    i = lista.Count;
                }
            }
            StreamWriter sr = new StreamWriter(file);
            foreach ( string ss in lista) sr.WriteLine(ss); 
            sr.Close( );
            /*
            vetContas[aux] = new Conta( );
            vetContas[aux].Nome = "";
            vetContas[aux].Agencia = 0;
            vetContas[aux].NumConta = 0;
            vetContas[aux].TipoConta = 0;
            */
            if ( cont > 0 ){
                cont--;
            }
        }

        public static void print( )
        {
           Console.Clear( );
           Console.WriteLine("\nCONTAS EXISTENTES: \n");
           for( int x = 0; x < cont; x ++ ){
               Console.WriteLine(vetContas[x].Nome + " com conta de numero: " + vetContas[x].NumConta);
            }
        }
			
		public static void names( ){
			Console.WriteLine( );
			Console.WriteLine("Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704).");
			Console.WriteLine( );
		}

    }//end class Program
}//end namespace
