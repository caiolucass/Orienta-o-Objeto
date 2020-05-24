using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_1
{
    class Televisor : iControleRemoto
    {
        private int volume, canal = 1;
        private bool on = false;
        public void ligar( )
        {
            On = true;
            Console.WriteLine("TV ligada.");
        }

        public void desligar( )
        {
            On = false;
            Console.WriteLine("TV desligada.");
        }

        public void aumentarVolume( )
        {
            if ( On && (volume >= 0 && volume <= 100) ){
                 volume++;
                 Console.WriteLine("Volume: "+ Volume);
            }
            else
            {
               Console.WriteLine("ERRO: Impossivel aumentar volume com TV desligada.");
            }
        }
           
        public void diminuirVolume( )
        {   
            if ( On && (volume > 0 && volume <= 100) ){
                 volume--;
                 Console.WriteLine("Volume: "+ Volume);
            }
            else
            {
               Console.WriteLine("ERRO: Impossivel diminuir volume com TV desligada.");
            }
        }

        public void subirCanal( )
        {
            if ( On && (canal > 0 && canal < 83) ){
                 canal++;
                 Console.WriteLine("Canal: "+ Canal);
            }
            else
            {
                Console.WriteLine("ERRO: Impossivel aumentar canal com TV desligada.");
            }
        }

        public void baixarCanal( )
        {
            if ( On && (canal > 0 && canal < 83) ){
                 canal--;
                 Console.WriteLine("Canal: "+ Canal);
            }
            else
            {
                Console.WriteLine("ERRO: Impossivel baixar canal com TV desligada.");
            }
        }

        public int Canal
        {
            get{ return canal;}
            set { if ( value > 0 && value < 83 )
                {
                    canal = value;
                }
            }
        }

         public int Volume
        {
            get{ return volume;}
            set { if ( value >= 0 && value <= 100 )
                {
                    volume = value;
                }
            }
        }

        public bool On
        {
            get { return on; }
            set
            {
                on = value;
            }
        }
    }
}
