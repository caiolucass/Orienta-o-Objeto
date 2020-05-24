using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_1
{
    class DVD: iControleRemoto
    { 
        private bool on = false;

        public bool On
        {
            get { return on; }
            set
            {
                on = value;
            }
        }

        public void ligar( )
        {
            On = true;
            Console.WriteLine("DVD ligado.");
        }

        public void desligar( )
        {
            On = false;
            Console.WriteLine("DVD desligado.");
        }
            
    }
}
