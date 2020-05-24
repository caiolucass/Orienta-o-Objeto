using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro
{
    class TanquedeCombustível
    {
        double total, atual;
     

        public TanquedeCombustível(double atual, double total)
        {

            this.total = total;
            this.atual = atual;
        }

        public double Abastecer(double abastecimento)
        {
            double verificar = atual + abastecimento;



            if (verificar > total)
            {
                return (-1);
            }
            else
            {
                atual = verificar;
                return (atual);
            }
        }
        public double Estado {
            get { return atual; }
        }

        //public double Gastar
        //{
        //    set { atual -= value; }
        //}
        public double Gastar (double KM)
        {
            double verificar = atual - KM;
           /* atual = verificar;*/ //verificar se a gasolina chegou a 0

            if (verificar <= 0)
            {
                atual = 0;
                return (0);
            }

            else
            {
                atual = verificar;
                return verificar;
            }
        } 


    }
}
