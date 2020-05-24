using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_3
{
    class Funcionario: Pessoa
    {
        private double salario;

        public override void informaNome()
        {
            Console.WriteLine(this.nome);
        }

        public void informarSalario( )
        {
            Console.WriteLine("A pessoa " + informaNome( ) + " possui um salario total de: "+ Salario );
        }

        public double Salario{
        get{ return salario;}
            set
            {
                if ( value > 0)
                {
                    salario = value;
                }
            }
        }//fim SalarioPropriety

        public void calcularIdade( )
        {
            Console.WriteLine(DateTime.Now.Year - this.nasc);
        }
    }
}
