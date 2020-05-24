using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_3
{
    interface IConta
    {
        void deposita ( double valor ); 
        void saca ( double valor ); 
       double Saldo { get ; set ; } 
    }//end interface 
}//end namespace
