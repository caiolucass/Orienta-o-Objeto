/* 
  Nome do programa: PMain.cs
  
   Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)
   Data: 22/03/2019
   Entrada(s): sem entrada pela LC
   Para executar e testar digite: 
   Exemplo: PMain.exe
   Descricao: Programa para a inclusao de pessoas, com atributos como data de nascimento, peso, altura, e metodos
	 para acessar essas caracteristicas e informar o IMC de cada pessoa registrada e alterar atributos.
*/

using System;

namespace Ex33Lab2 {
	public class PMain {

		const int MAXPESSOAS = 100; //numero maximo de pessoas suportado no vetor
		static Pessoa[] vetPessoas = new Pessoa[MAXPESSOAS]; //vetor de Pessoas
		static int cont = 0;
		public static void Main (string[] args) {
			int option = -1, aux = 0;
			string leitura = "";

			do {
				menu ();
				aux = 0;
				//testar se o  valor lido pelo teclado e' um numero para evitar erros
				leitura = Console.ReadLine ();
				if (isNumber (leitura)) {
					option = int.Parse (leitura);
				} else { option = 7; }

				switch (option) {
					case 1:
						Console.WriteLine (" Adicionar uma nova pessoa...\n");
						novaPessoa ();
						break;

					case 2:
						//Alterar a data de nascimento de uma pessoa
						Console.WriteLine ("Alteracao de data ... ");
						Console.WriteLine ("De qual pessoa deseja alterar a data de nascimento? ");
						aux = int.Parse (Console.ReadLine ());
						vetPessoas[aux - 1].mudaData ();
						Console.ReadKey ();
						break;

					case 3:
						//Alterar o peso de uma pessoa 
						Console.WriteLine ("Alteracao de peso ...");
						Console.WriteLine ("De qual pessoa deseja alterar o peso? ");
						aux = int.Parse (Console.ReadLine ());
						vetPessoas[aux - 1].mudaPeso ();
						Console.ReadKey ();
						break;

					case 4:
						//Alterar a altura de uma pessoa
						Console.WriteLine ("Alteracao de altura ...");
						Console.WriteLine ("De qual pessoa deseja alterar a altura? ");
						aux = int.Parse (Console.ReadLine ());
						vetPessoas[aux - 1].mudaAltura ();
						Console.ReadKey ();
						break;

					case 5:
						//Informar a idade de uma pessoa
						Console.WriteLine ("Mostrar a idade de qual pessoa? ");
						aux = int.Parse (Console.ReadLine ());
						vetPessoas[aux - 1].informaIdade ();
						Console.ReadKey ();
						break;

					case 6:
						//Informar o IMC de uma pessoa 
						Console.WriteLine ("Informar o IMC de qual pessoa? ");
						aux = int.Parse (Console.ReadLine ());
						vetPessoas[aux - 1].IMC ();
						Console.ReadKey ();
						break;

					case 7:
						Console.WriteLine ("\nPrograma terminado!!!");
						Console.WriteLine ("\nDigite qualquer tecla para sair ");
						Console.ReadKey ();
						break;

					default:
						Console.Write ("Opcao invalida!!");
						Console.WriteLine ("\nDigite qualquer tecla para voltar ao menu ");
						Console.ReadKey ();
						break;

				} //end switch 
			} while (option != 7);

		} //end main( )

		public static void novaPessoa () {
			cont++;
			Console.WriteLine ("Entre com os dados da pessoa (" + cont + "): ");
			Console.WriteLine ("Data de nascimento... ");
			Console.Write ("Dia: ");
			int d = int.Parse (Console.ReadLine ());
			Console.Write ("Mes: ");
			int m = int.Parse (Console.ReadLine ());
			Console.Write ("Ano: ");
			int a = int.Parse (Console.ReadLine ());
			Console.WriteLine ("Agora informe o peso e a altura...");
			Console.Write ("Peso: ");
			double p = double.Parse (Console.ReadLine ());
			Console.Write ("Altura: ");
			double alt = Convert.ToDouble (Console.ReadLine ());
			vetPessoas[cont - 1] = new Pessoa (d, m, a, p, alt);
		}

		public static bool isNumber (string s) {
			bool r = false;
			for (int i = 0; i < s.Length; i++) {
				if (s[i] >= '0' && s[i] <= '9') {
					r = true;
				} else {
					r = false;
					return r;
				}
			} //end for
			return r;
		} //end isNumber

		public static void menu () {
			Console.Clear ();
			Console.WriteLine (" Nome do programa: PMain.cs ");
			Console.WriteLine ("Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704), Cleber Magela(636964)");
			Console.WriteLine ();
			Console.WriteLine (" 1. Incluir uma nova pessoa.");
			Console.WriteLine (" 2. Alterar a data de nascimento de uma pessoa cadastrada.");
			Console.WriteLine (" 3. Alterar o peso de uma pessoa cadastrada.");
			Console.WriteLine (" 4. Alterar a altura de uma pessoa cadastrada");
			Console.WriteLine (" 5. Informar a idade atual de uma pessoa cadastrada.");
			Console.WriteLine (" 6. Informar IMC de uma pessoa cadastrada.");
			Console.WriteLine (" 7. Sair do programa.");
			Console.Write ("Digite sua opcao: ");
		} //end MENU

	} //end class PMain
} //end namespace