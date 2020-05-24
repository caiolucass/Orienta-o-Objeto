using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Veiculo carro = new Veiculo ();
            int KM = 0;
            Console.WriteLine("Abasteçer o tanque com 30 litros");
            carro.getMotor.getTanque.Abastecer(30);
            Console.ReadKey();
            Console.WriteLine("Carro abastecido com sucesso !");
            Console.ReadKey();
            Console.WriteLine("\t\n-----------------Estado atual do Veiculo---------------\t\n");
            Console.WriteLine( "Gasolina Atual: "+ carro.getMotor.getTanque.Estado);
            Console.WriteLine( "Lb Pneu Dianteiro Direito: "+carro.getPneuDiaDir.Estado);
            Console.WriteLine("Lb Pneu Dianteiro Esquerdo: " + carro.getPneuDiaEsq.Estado);
            Console.WriteLine("Lb Pneu Traseiro Esquerdo: " + carro.getPneuTraEsq.Estado);
            Console.WriteLine("Lb Pneu Traseiro Direito: " + carro.getPneuTraDir.Estado);
            Console.WriteLine("HP do motor: " + carro.getMotor.Estado);
            Console.ReadKey();
            Console.WriteLine("Avançar  300 Km");
           
            Console.ReadKey();
            
           
            if (carro.Avanco(300) != -1)
            {
                Console.WriteLine("Avanço ocorrido");
                KM += 300;
                Console.WriteLine("kM percorrido: " +  KM );
                Console.WriteLine("Gasolina Atual: " + carro.getMotor.getTanque.Estado);
            }
            else
            {
                Console.WriteLine("Avanço ocorrido");
                Console.WriteLine("Combustivo vazio");
                Console.WriteLine("O veiculo nao conseguiu chegar local");
                Console.WriteLine("Gasolina Atual: 0" );

            }
            //format(carro.getMotor.getTanque.Estado, "0.00");
          
            Console.ReadKey();

            Console.WriteLine(" Reduzir a pressão do pneu traseiro esquerdo para 17 lb ");
            Console.ReadKey();
            carro.getPneuTraEsq.Calibragem(17,false);
            Console.WriteLine(  " Reduçao do pneu feita!!");
            Console.ReadKey();
            Console.WriteLine("Avançar  100 Km");

            Console.ReadKey();


            if (carro.Avanco(100) != -1)
            {
                Console.WriteLine("Avanço ocorrido");
                KM += 100;
                Console.WriteLine("kM percorrido: " + KM);
                Console.WriteLine("Gasolina Atual: " + carro.getMotor.getTanque.Estado);
            }
            else
            {
                Console.WriteLine("Avanço ocorrido");
                Console.WriteLine("Combustivo vazio");
                Console.WriteLine("O veiculo nao conseguiu chegar local");
                Console.WriteLine("Gasolina Atual: 0" );

            }
          
            Console.ReadKey();
            Console.WriteLine(" Reduzir a pressão do pneu traseiro esquerdo para 17 lb ");
            Console.ReadKey();
            carro.getPneuDiaDir.Calibragem(18, false);
            Console.WriteLine(" Reduçao do pneu feita!!");
            Console.ReadKey();

            Console.WriteLine("Abasteçer o tanque com 10 litros");
            carro.getMotor.getTanque.Abastecer(10);
            Console.ReadKey();

            Console.WriteLine("Avançar  200 Km");

            Console.ReadKey();


            if (carro.Avanco(200) != -1)
            {
                Console.WriteLine("Avanço ocorrido");
                KM += 200;
                Console.WriteLine("kM percorrido: " + KM);
                Console.WriteLine("Gasolina Atual: " + carro.getMotor.getTanque.Estado);
            }
            else
            {
                Console.WriteLine("Avanço ocorrido");
                Console.WriteLine("Combustivo vazio");
                Console.WriteLine("O veiculo nao conseguiu chegar local");
                Console.WriteLine("Gasolina Atual: 0" );

            }
           
            Console.ReadKey();

        }
    }
}
