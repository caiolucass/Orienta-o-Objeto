using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_3
{
    class Cliente: Pessoa
    {
        private string cartao;
        private double debito;

        public void informarCartao( )
        {
            Console.WriteLine("O numero do cartao da pessoa "+ this.nome + "e': "+ Cartao);
        }

        public void informarDebito( )
        {
            Console.WriteLine("A pessoa "+ this.nome+ " possui um debito total de: " );
        }

        public string Cartao
        {
            get { return cartao; }
            set
            {
                if (value != null)
                {
                    cartao = value;
                }
            }
        }
    }
}
