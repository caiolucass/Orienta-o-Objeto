using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_2
{
    class Circulo
    {
        private double raio;
        public Circulo( int raio )
        {
            Raio = raio;

        }

        public double Raio
        {
            get { return raio; }
            set
            {
                raio = value;
            }
        }
    }
}
