using System;

namespace Ex46_Lab2{
	
public class Velho : Imovel {

	private double valorDesc = 50;

	public override void criaImovel( ){
		Price -= valorDesc;
		ValorDesc = Price;
        GetAdress();
	}//end criaImovel( )
	
	public double ValorDesc{
		get{ return valorDesc; }
		set{
			if ( value > 0 ){
				valorDesc = value;
			}
		}
	}//end ValorDesc
	
	public void printVelho( ){
		Console.WriteLine( "Valor do imovel velho: " + ValorDesc );
	}
	
}//end class
}//end namespace