using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_2
{
    interface iForma
    {
        string name;
        //metodos para calculo do perimetro e area
        double perimetro( );

        double area( );

        string Name { get; set; }
    }
}
