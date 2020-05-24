using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_3
{
    class ContaCorrente : Conta, IConta
    {
        private double limite;
        private int tipo;
        public double Saldo { get ; set ; } 
        private double taxaPorOperacao = 0.45; 
        public void deposita ( double valor )
        { 
           this . Saldo += valor - this . taxaPorOperacao ; 
        } 
        public void saca ( double valor )
        { 
           this . Saldo -= valor + this . taxaPorOperacao ; 
        } 

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
