using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_5
{
    class Endereco
    {
        string logradouro;
        int numero;
        string bairro;
        string cidade;
        string estado;
        string cep;

        public Endereco( )
        {

        }

        public Endereco( string log, int number, string br, string city, string state, string cp)
        {
            this.logradouro = log;
            this.numero = number;
            this.bairro = br;
            this.cidade = city;
            this.estado = state;
            this.cep = cp;
        }

        public string Logradouro
        {
            get { return logradouro; }
            set
            {
                logradouro = value;
            }
        }
        public int Numero
        {
            get { return numero; }
            set
            {
                numero = value;
            }
        }
        public string Bairro
        {
            get { return bairro; }
            set
            {
                bairro = value;
            }
        }
        public string Cidade
        {
            get { return cidade; }
            set
            {
                cidade = value;
            }
        }
        public string Estado
        {
            get { return estado; }
            set
            {
                estado = value;
            }
        }
        public string Cep
        {
            get { return cep; }
            set
            {
                cep = value;
            }
        }
    }
}
