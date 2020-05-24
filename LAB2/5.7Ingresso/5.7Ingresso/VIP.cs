using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ingresso
{
    class VIP: ingresso
    {
        //declaração de variavel privada
        private double adcionalvip = 50.0;

        //metodos get e set
        public double adcionalVip
        {
            get { return adcionalvip+Valor; }
            set { this.adcionalvip = value; }
        }//fim adc
    }
}
