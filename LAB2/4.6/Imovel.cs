using System;

namespace Ex46_Lab2{
	
public abstract class Imovel{
	private string adress = "endereco do imovel.";
	private double price = 1500;

        public double Price { get{ return price; }
		 set {
			 if ( value > 0 ){
			  price = value; 
			  }
		 }//fim set 
		}//end Price

        public string GetAdress()
        {
            return adress;
        }

        public abstract void criaImovel( );
	
	

	

}

}