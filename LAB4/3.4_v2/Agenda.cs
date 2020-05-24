using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4
{
    class Agenda:Dado
    {
        protected string nome;
        protected string endereço;
        bool excluir = false; // variavel para dar valor de iniciaçao excluir conta
        static int contador = 0;//contar o numero de contribuintes
        string tipo;
        protected string documento;
        protected string sexo;
        protected string data;

        public Agenda(string tipo, string cp, string nome, string endereço, string str) //construtor classe contribuinte
        {
            this.nome = nome;
            this.endereço = endereço;
            this.tipo = tipo;
            contador++;
            excluir = true;
            documento = cp;
            if (tipo == "PF")
            {
                this.sexo = str;
            }
            else
            {
                this.data = str;
            }
        }

        public Agenda() 
        {
            nome = null;
            endereço = null;
            tipo = null;
            documento = null;
            sexo = null;

        }

        public string GetNome(string nome)
        {
            return nome;
        }

        public string Nome 
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Endereço 
        {
            get { return endereço; }
            set { endereço = value; }
        }

        public virtual string Sexo 
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public bool Excluir()//metodo para excluir um contato
        {
            excluir = true;
            return (excluir);
        }

        public virtual string Documento
        {
            get { return documento; }
            set { documento = value; }
        }

        public virtual string Genero()
        {
            return null;
        }

        public bool AcessorExcluir//capturar a condiçao para excluir a conta
        {
            get { return excluir; }
        }

        public string Tipo() // tipo de pessoa
        {
            return tipo;
        }

        public string Data
        {
            get { return data; }
            set { data = value; }
        }

    }
}

