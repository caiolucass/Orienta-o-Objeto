﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_4_1
{
    class Telefone
    {
        protected string TipoDoTelefone { get; set; }

        public void ring( )
        {
            Console.WriteLine( "Tocando o "+ TipoDoTelefone );
        }//end ring( )
    }//end class Telefone
}//end namespace
