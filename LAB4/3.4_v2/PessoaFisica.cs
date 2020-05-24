using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4
{
    class PessoaFisica:Agenda
    {
        public PessoaFisica(string t, string cp, string n, string end, string s) : base(t, cp, n, end, s)//construtor da pessoa fisica padrao 
        {
        }

        public PessoaFisica()//construtor com valores
        {
            sexo = null;
        }

        public override string Documento // obter e retornar documento
        {
            get { return documento; }
            set { documento = value; }
        }

        public override string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public override string Genero() //metodo sobreescrito do sexo
        {
            if (sexo == "Masculino" || sexo == "masculino")
            {
                return "Masculino";
            }
            else return "Feminino";
        }

    }
}

