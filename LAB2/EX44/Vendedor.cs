using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX44
{
    class Vendedor : Funcionario
    {
        double vendas, novaVenda;


        double resu;
        public Vendedor(string nome, string RG, double vendas, double salario) : base(nome, RG, salario)
        {
            this.vendas = vendas;

        }


        public override double CalculaSalario()
        {
            double aux = salario + (vendas * 0.05);
            vendas = 0;
            return aux;

        }
        public double AcumulaVendas(double novaVenda)
        {

            return vendas = vendas + novaVenda;
        }
    }
}