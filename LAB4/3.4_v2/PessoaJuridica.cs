using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4
{
    class PessoaJuridica:Agenda
    {
        protected string data;

        public PessoaJuridica(string t, string cp, string n, string end, string data) : base(t, cp, n, end,data)//construtor da classe pessoa juridica
        {
            this.data = data;
        }
        
        public PessoaJuridica()
        {
            data = null;
        }

        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        public override string Documento // obter e retornar documento
        {
            get { return documento; }
            set { documento = value; }
        }
    }
}
