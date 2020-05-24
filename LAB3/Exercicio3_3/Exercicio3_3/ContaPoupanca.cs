using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_3
{
    class ContaPoupanca : Conta, IConta
    {
        private int diaAniv;
        private int tipo;
        public double Saldo { get ; set ; } 
        public void deposita ( double valor )
        { 
            this.Saldo += valor ; 
        }
        public void saca ( double valor ) { 
            this.Saldo -= valor ; 
        }

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

        public int Tipo
        {
            get { return tipo; }
            set
            {
                tipo = value;
            }
        }
    }//end class
}//end namespace
