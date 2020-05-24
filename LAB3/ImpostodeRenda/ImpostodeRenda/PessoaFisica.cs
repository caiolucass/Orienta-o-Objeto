using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostodeRenda_arquivo_
{
    class PessoaFisica : Contribuinte  //inicializaçao das variaveis
    {

        public PessoaFisica(string t, string cp, string n, string end,double s) : base(t,cp,n,end,s)//construtor da pessoa fisica padrao 
        {
        }

        public PessoaFisica()//construtor com valores
        {
            salario = 0;
        }

        public override string Documento // ober e retornar documento
        {
            get { return documento; }
            set { documento = value; }
        }

        public override double CalculoImposto()//metodo para verificar o salario da pessoa fisica
        {
            if (salario <= 1400.00)
            {
                return 0;
            }
            else if (salario >= 1400.01 && salario <= 2100.00)
            {
                return (salario - 1400) * 0.10;
            }
            else if (salario > 2100.01 && salario <= 2800.00)
            {
                return (salario - 2100) * 0.15;
            }
            else if (salario >= 2800.01 && salario <= 3600.00)
            {
                return (salario - 2800) * 0.25;
            }
            else
            {
                return (salario - 3600) * 0.30;
            }
        }
    }
}
