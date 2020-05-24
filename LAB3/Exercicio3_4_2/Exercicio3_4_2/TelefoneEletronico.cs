using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_4_2
{
    class TelefoneEletronico: Telefone
    {
        public TelefoneEletronico( )
        {
            TipoDoTelefone = "Digital";
        }

        public override void ring()
        {
            Console.WriteLine("Tocando o "+ TipoDoTelefone + " na classe TelefoneEletronico." );
        }

    }
}
