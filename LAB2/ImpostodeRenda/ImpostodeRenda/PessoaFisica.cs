using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostodeRenda
{
    class PessoaFisica : Contribuinte  //inicializaçao das variaveis
    {

        public PessoaFisica(string n, string end, double s, string c, int t) : base(n, end, t, c, s)//construtor da pessoa fisica padrao 
        {
        }
        public override string Documento // ober e retornar documento
        {
            get { return documento; }
            set { documento = value; }
        }

        public override double CalculoImposto()//metodo para verificar o salario da pessoa fisica
        {
            if (salario <= 1903.98)
            {
                return 0;
            }
            else if (salario >= 1904 && salario <= 2826.65)
            {
                return (salario - 1904) * 0.0075;
            }
            else if (salario > 2826.66 && salario <= 3751.05)
            {
                return (salario - 2826) * 0.15;
            }
            else if (salario >= 3758.06 && salario <= 4664.68)
            {
                return (salario - 3758) * 0.225;
            }
            else
            {
                return (salario - 3758) * 0.275;
            }
        }
    }
}
