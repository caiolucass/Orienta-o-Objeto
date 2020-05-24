using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX44
{
    class Funcionario
    {
        //atributos

        string nome;
        string RG;
        protected double salario;
        bool excluir = false;
        string cargo;
        double extra;

        public Funcionario()
        {
            nome = null;
            RG = null;
            salario = 0;
            cargo = null;
            extra = 0;
            salario = 0;
        }
        public Funcionario(string nome, string RG, double salario)// costrutor
        {
            this.nome = nome;
            this.RG = RG;
            this.salario = salario;
            excluir = true;


        }
        // metodos

        public virtual double CalculaSalario()
        {
            return 0;
        }
        public bool Excluir()

        {
            excluir = false;
            return (excluir);

        }
        public bool AcessorExcluir
        {
            get { return excluir; }

        }

        public string ChecarNome
        {
            get { return nome; }

        }

        public string MudarNome
        {
            get { return nome; }
            set { nome = value; }


        }
        public string MudarRG
        {
            get { return RG; }
            set { RG = value; }
        }

        public string MostrarRG
        {
            get { return RG; }

        }

        public string MudarCargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public double MudarSalario
        {
            get { return salario; }
            set { salario = value; }
        }
        public double Extra
        {
            get { return extra; }
            set { extra = value; }
        }

        public virtual double CalculaSalario(double extra)
        {
            return 0;
        }

    }
}