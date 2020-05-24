using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro
{
    class Veiculo
    {
        Motor motor;
        Pneu pneuTraEsq;
        Pneu pneuTraDir;
        Pneu pneuDiaDir;
        Pneu pneuDiaEsq;


        public Veiculo()
        {
            motor = new Motor(71, 12);
            pneuTraEsq = new Pneu(23);
            pneuTraDir = new Pneu(23);
            pneuDiaEsq = new Pneu(27);
            pneuDiaDir = new Pneu(27);
        }
        public Motor getMotor { get { return motor; } set { motor = value; } }
        public Pneu getPneuTraEsq { get { return pneuTraEsq; } set { pneuTraEsq = value; } }
        public Pneu getPneuTraDir { get { return pneuTraDir; } set { pneuTraDir = value; } }
        public Pneu getPneuDiaEsq { get { return pneuDiaEsq; } set { pneuDiaEsq = value; } }
        public Pneu getPneuDiaDir { get { return pneuDiaDir; } set { pneuDiaDir = value; } }



        public bool Calibragem()
        {
            int cont = 0;
            if (pneuDiaDir.Verificar())
            {
                cont++;
            }
            else if(pneuTraDir.Verificar())
            {
                cont++;
            }
            else if(pneuDiaEsq.Verificar())
            {
                cont++;
            }
            else if (pneuTraEsq.Verificar())
            {
                cont++;
            }
            if (cont >= 2)
            {
                return (false);
            }
            else return true;
        }
        public int Avanco(double Km)
        {
            int i = 0;
            for (i = 0; i < Km; i++)
            {

                if (motor.getTanque.Estado > 0)
                {
                    if (Calibragem())
                    {

                        motor.getCombustivel(1/motor.Taxa);
                    }
                    else motor.getCombustivel((1/ motor.Taxa) + (motor.Taxa * 0.3));

                }
                else
                {
                    Console.WriteLine("KM percorridos: " + i);
                    return -1;
                }
            }
            return (i);
        }


    }
}
