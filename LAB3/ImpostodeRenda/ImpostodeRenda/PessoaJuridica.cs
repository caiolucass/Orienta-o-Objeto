using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostodeRenda_arquivo_
{ 
    class PessoaJuridica : Contribuinte  //inicialização das variaveis
    {
        public PessoaJuridica(string t, string cp, string n, string end,double s) : base(t, cp, n,end,s) //construtor da classe pessoa juridica
        {
        }

        public PessoaJuridica() //construtor com valores
        {
            faturamento = 0;
        }

        public double Faturamento
        {
            get { return faturamento; }
            set { faturamento = value;} 
        }
        public override string Documento //documento
        {
            get { return documento; }
            set { documento = value; }
        }

        public override double CalculoImposto()//metodo para verificar o salario da pessoa jurifica
        {   
            if(faturamento > 0)
            {
                return faturamento * 0.10;
            }
            else return -1.0;
        }
    }
}
