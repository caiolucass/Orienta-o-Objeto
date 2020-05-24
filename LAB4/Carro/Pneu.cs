using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro
{
    class Pneu
    {
        int lb;
        public Pneu(int lb)
        {
            this.lb = lb;

        }

        public int Calibragem (int calibragem, bool verificar)
        {
            int total;
            if (verificar)
            {
                total = calibragem + lb;
            }
            else total = calibragem - lb;
            lb = total;
            return (lb);
        }
        public bool Verificar()
        {
            if (lb < 20)
            {
                return (false);
            }
            else return (true);
        }
        public int Estado
        {
            get { return lb; }
        }

    }
}
