using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_2
{
    class ContaPoupanca : Conta
    {
        private int diaAniv;

        public int DiaDoAniversario {
            get { return diaAniv ; }
            set
            {
                if ( value > 0 && value < 32 )
                {
                    diaAniv = value;
                }//end if 
            }//end set
        }//end diaDoAniversario
    }//end class
}//end namespace
