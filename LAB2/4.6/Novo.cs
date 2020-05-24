using System;

namespace Ex46_Lab2{
	
public class Novo : Imovel {

	private double valorAdd = 50;

        public double ValorAdd
        {
            get
            {
                return valorAdd;
            }
			set{
				if (value > 0){
					valorAdd = value;
				}
			}
        }

        public override void criaImovel( ){
		Price += valorAdd;
		ValorAdd = Price;
        GetAdress();
	}//end criaImovel( )
	
	public void printNovo( ){
		Console.WriteLine( "Valor do imovel novo: " + ValorAdd );
	}
	
 }//end class
}//end namespace