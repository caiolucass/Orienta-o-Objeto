using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_3
{
#pragma warning disable
    class Conta
    { 
      private string nome;
      private double saldo;
      private int agencia;
      private int tipoConta;
      private int numConta;
      public double Saldo{ get; set; }
        public string Nome
        {
            get { return nome; }
            set
            {
                nome = value;
            }
        }

        public int Agencia
        {
            get { return agencia; }
            set
            {
                agencia = value;
            }
        }

        public int TipoConta
        {
            get { return tipoConta; }
            set
            {
                tipoConta = value;
            }
        }

        public int NumConta { get { return numConta; } set => numConta = value; }
    }//fim class Conta
}//fim namespace Exercicio3_2
