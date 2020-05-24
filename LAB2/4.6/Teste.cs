    /* 
      Nome do programa: Teste.cs // Imovel.cs // Novo.cs //Velho.cs
      
       Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)
       Data: 26/03/2019
       Entrada(s): sem entrada pela LC
       Para executar e testar digite: 
       Exemplo: Teste
       Descricao: O programa utiliza dos conceitos de heranca e encapsulamento para a criacao de um imovel( velho ou novo ); 
    */
    using System;

    namespace Ex46_Lab2 {

        public static class Teste {
            public static void menu () {
                Console.Clear ();
                Console.WriteLine (" Nome do programa: Teste.cs ");
                Console.WriteLine ("Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)");
                Console.WriteLine ();
            } //end MENU
            public static void Main (string[] args) {
                menu( );
                int opt = 0;
                do {
                    menu ();
                    opt = int.Parse (Console.ReadLine ());
                    switch (opt) {
                        case 1:
                            Novo i = new Novo ();
                            i.criaImovel ();
                            i.printNovo ();
                            Console.WriteLine ("\nDigite qualquer tecla para voltar ao menu ");
                            Console.ReadKey ();
                            break;

                        case 2:
                            Velho x = new Velho ();
                            x.criaImovel ();
                            x.printVelho ();
                            Console.WriteLine ("\nDigite qualquer tecla para voltar ao menu ");
                            Console.ReadKey ();
                            break;

                        case 3:
                            Console.WriteLine ("\nPrograma terminado!!!");
                            Console.WriteLine ("\nDigite qualquer tecla para sair ");
                            Console.ReadKey ();
                            break;

                        default:
                            Console.Write ("Opcao invalida!!");
                            Console.WriteLine ("\nDigite qualquer tecla para voltar ao menu ");
                            Console.ReadKey ();
                            break;
                    }
                } while (opt != 3);
            } //end main( )

            public static void menu () {
                Console.Clear ();
                Console.WriteLine ("Qual o tipo do imovel desejado? ");
                Console.WriteLine (" 1 - Novo \t  2 - Velho ");
                Console.WriteLine (" 3. Sair do programa.");
                Console.Write ("Digite sua opcao: ");
            } //end MENU
        } //end class Teste

    }