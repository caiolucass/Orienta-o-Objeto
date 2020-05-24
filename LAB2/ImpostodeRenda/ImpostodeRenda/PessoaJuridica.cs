using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostodeRenda
{
    class PessoaJuridica : Contribuinte  //inicialização das variaveis
    {
        public PessoaJuridica(double f, string c, string end, string n, int t) : base(n, end, t, c, f) //construtor da classe pessoa juridica
        {
        }

        public override string Documento //documento
        {
            get { return documento; }
            set { documento = value; }
        }

        public override double CalculoImposto()//metodo para verificar o salario da pessoa jurifica
        {
            if (salario > 0)
            {
                return Salario * 0.10;
            }
            else return -1.0;
        }
    }
}
