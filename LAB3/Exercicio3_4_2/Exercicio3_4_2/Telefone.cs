using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_4_2
{
    class Telefone
    {
        protected string TipoDoTelefone { get; set; }

        public virtual void ring( )
        {
            Console.WriteLine( "Tocando na classe Telefone" );
        }//end ring( )
    }//end class Telefone
}//end namespace
