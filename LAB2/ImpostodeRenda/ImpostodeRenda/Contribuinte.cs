using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostodeRenda
{
    class Contribuinte  //classe contribuinte
    {
        protected string nome;
        protected string endereço;
        bool excluir = false; // variavel para dar valor de iniciaçao excluir conta
        static int contador = 0;//contar o numero de contribuintes
        int tipo;
        protected string documento;
        protected double salario,imposto = 0;
       
        public Contribuinte(string nome, string endereço, int tipo, string cp, double salario)//construtor classe contribuinte
        {
            this.nome = nome;
            this.endereço = endereço;
            this.tipo = tipo;
            contador++;
            excluir = true;
            documento = cp;
            this.salario = salario;
        }

        public Contribuinte() //construtor
        {
            nome = null;
            endereço = null;
            tipo = 0;
            documento = null;
            salario = 0;
        }
        
        public string GetNome(string nome)
        {
            return nome;
        }

        public string Nome  //capturar e devolver o nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Endereço //capturar e devolver o endereço
        {
            get { return endereço; }
            set { endereço = value; }
        }

        public bool Excluir()//metodo para excluir um contribuinte
        {
            excluir = false;
            return (excluir);
        }

        public virtual double CalculoImposto() //metodo virtual para calcular impostos
        {
            return 0;
        }

        public virtual string Documento //cpf
        {
            get { return documento; }
            set { documento = value; }
        }


        public bool AcessorExcluir//capturar a condiçao para excluir a conta
        {
            get { return excluir; }
        }

        public int Tipo // tipo de contribuinte
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public double Salario //obter e retornar salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public double Faturamento
        {
            get { return Faturamento; }
            set { Faturamento = value; }
        }

        public double Imposto
        {
            get { return imposto;}
            set { imposto = value;}
        }
    }
}
