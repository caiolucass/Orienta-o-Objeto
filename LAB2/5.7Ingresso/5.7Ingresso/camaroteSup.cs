using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ingresso
{
    class camaroteSup: VIP
    {
        //declaração de variavel privada
        private double adcional = 50.0;

        //metodos get e set
        public double Adcional
        {
            get { return adcional+adcionalVip; }
            set { this.adcional = value; }
        }
    }
}
