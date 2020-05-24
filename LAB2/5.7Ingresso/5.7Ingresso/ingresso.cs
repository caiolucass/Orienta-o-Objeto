using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ingresso
{
    class ingresso
    {

        //declaração de varialvel privada
        private double valor = 100.0;

        //metodos get e set
        public double Valor
        {
            get { return valor; }
            set { this.valor = value; }
        }

        //metodo de impressão de valor do ingresso
        public void imprimeValor()
        {
            Console.Write("Valor: " + this.valor);
        }
    }
}
