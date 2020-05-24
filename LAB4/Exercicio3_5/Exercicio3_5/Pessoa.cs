using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_5
{
    class Pessoa 
    {
        string nome;
        Data dataNasc;
        Endereco endereco;
        Contato contato;

        public Pessoa()
        {
            dataNasc = new Data();
            endereco = new Endereco();
            contato = new Contato();
        }

        public Pessoa( string name, Data date, Endereco adress, Contato contact )
        {
            this.Nome = name;
            this.DataNasc = date;
            this.Endereco = adress;
            this.Contato = contact;
        }

        public string Nome
        {
            get { return nome; }
            set
            {
                nome = value;
            }
        }

        internal Data DataNasc
        {
            get { return dataNasc; }
            set
            {
                dataNasc = value;
            }
        }
        internal Endereco Endereco
        {
            get { return endereco; }
            set
            {
                endereco = value;
            }
        }
        internal Contato Contato
        {
            get { return contato; }
            set
            {
                contato = value;
            }
        }
    }
}
