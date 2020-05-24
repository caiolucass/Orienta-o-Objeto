using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_3
{
    abstract class Pessoa
    {
        protected string nome;
        protected string endereco;
        protected int nasc;

        public abstract void informaNome( );

    }
}
