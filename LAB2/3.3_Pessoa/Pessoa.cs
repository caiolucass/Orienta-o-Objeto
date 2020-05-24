using System;

namespace Ex33Lab2{	
	public class Pessoa {
		private int dia, mes, ano; 
		private static int [ ] numDias  = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
		private double peso, altura;
		
		
		public Pessoa( ) { // construtor default sem parâmetros inicializados com valores validos 
			dia = 1; mes = 1; ano = 1900; peso = 0.0; altura = 0.0; 
		} 
		
		public Pessoa( int dia, int mes, int ano, double peso, double altura ) {// construtor com parâmetros passados por valor
			if (( dia > 0) && (dia <= numDias[mes - 1])){ this.dia = dia;}
			else { this.dia = 1; Console.WriteLine( "ERRO: dia informado invalido." ); }
			if (( mes > 0) && (mes <= 12)){ this.mes = mes;}
			else { this.mes = 1; Console.WriteLine( "ERRO: mes informado invalido." ); }
			if ( ano > 1900) { this.ano = ano ; }
			else { this.ano = 1900; Console.WriteLine( "ERRO: ano informado invalido." ); }
		    if ( peso > 0.0 && peso <= 600 ){ this.peso = peso; }
			else { this.peso = 0.0; Console.WriteLine( "ERRO: peso informado invalido." ); }
			if ( altura > 0 && altura < 3.0 ) { this.altura = altura; }
			else { this.altura = 0.0;	Console.WriteLine( "ERRO: altura informada invalido." ); }
		}
		
		//metodo para informar a idade da pessoa
		public void informaIdade( ){
			int idade = 0;
			idade = 2019 - this.ano;
			Console.WriteLine("A pessoa tem " + idade + " anos de idade ou vai fazer "+ idade +" ainda neste ano." );
		}//end informaIdade( )
		
		//metodo para calcular o IMC
		public void IMC ( ){
			double imc = 0.0;
			imc = this.peso /(this.altura*this.altura);
			Console.WriteLine("o seu IMC e' de: "+ imc );
		}//fim IMC( )
		
		 //metodo para alterar a data de nascimento de uma pessoa
		 public void mudaData( ){	//cont = numero identificador da pessoa
		 Console.Write( "Entre com o novo valor para o dia: " );
		 dia = int.Parse( Console.ReadLine( ));
		 Console.Write( "Entre com o novo valor para o mes: " );
		 mes = int.Parse( Console.ReadLine( ));
		 Console.Write( "Entre com o novo valor para o ano: " );
		 ano = int.Parse( Console.ReadLine( ));
		 }//end mudaData( )
		 
		 //metodo para alterar o peso de uma pessoa 
		 public void mudaPeso( ){
		 Console.Write("Entre com o novo valor para o peso: " );
		 peso = Convert.ToDouble( Console.ReadLine( ) );
		 }//end mudaPeso( )
		 
		 //metodo para alterar a altura de uma pessoa
		 public void mudaAltura( ){
		 Console.Write("Entre com o novo valor para a altura: " );
		 altura = Convert.ToDouble( Console.ReadLine( ) );
		 }//end mudaAltura( )
	
		
		public int Dia { 
			get { 
				return this.dia;
			}
			set{
				this.dia = value;
			}
		}	
		public int Mes { 
			get { 
				return this.mes ;
			}
			set{
				this.mes = value;
			}
		}
		public int Ano { 
			get {
				return this.ano;
			}
			set{
				this.ano = value;
			}
		}
		
		public double Peso{
			get{ return this.peso; }
			set {
					this.peso = value;
				}
		}
		
		public double Altura{
			get{ return this.altura; }
			set {
					this.altura = value;
				}
		}
	
	}//end class Pessoa

}//end namespace