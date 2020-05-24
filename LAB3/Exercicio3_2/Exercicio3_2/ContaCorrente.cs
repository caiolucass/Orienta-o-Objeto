using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_2
{
    class ContaCorrente : Conta
    {
        private double limite;
        public double Limite {
            get { return limite; }
            set
            {
                 if ( value > 0 )
                 {
                    limite = value;
                 }//end if
            }//end set
        }//end Limite
    }//end class
}//end namespace
