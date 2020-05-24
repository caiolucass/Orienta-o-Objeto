using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro
{
    class Motor
    {
        TanquedeCombustível tanque;
    
        int hp, taxa;
        double cheio = 50, atual = 0;
        public Motor ( int hp, int taxa)
        {
            tanque = new TanquedeCombustível(atual,cheio);
            this.hp = hp;
            this.taxa = taxa;

        }

        public double Taxa
        {
            get { return taxa; }
        }
        public double Estado
        {
            get { return hp; }
        }
        public TanquedeCombustível getTanque { get { return tanque; } set { tanque = value; } }

      public void getCombustivel ( double gastar)
        {
            tanque.Gastar(gastar);
        }

    }
}
