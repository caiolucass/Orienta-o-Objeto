using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_5
{
    class Contato
    {
        string telefoneResid;
        string celular;
        string email;

        public Contato()
        {

        }

        public Contato( string tel, string cel, string mail)
        {
            this.TelefoneResid = tel;
            this.Celular = cel;
            this.Email = mail;
        }

        public string TelefoneResid
        {
            get { return telefoneResid; }
            set
            {
                telefoneResid = value;
            }
        }
        public string Celular
        {
            get { return celular; }
            set
            {
                celular = value;
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }
    }
}
