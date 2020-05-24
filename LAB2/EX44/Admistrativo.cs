
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX44
{
    class Admistrativo : Funcionario
    {
        double horasExtra;


        public Admistrativo(String nome, string RG, double horasExtra, double salario) : base(nome, RG, salario)
        {
            this.horasExtra = horasExtra;
        }
        public override double CalculaSalario()
        {
            double aux = salario + ((salario * 0.01) * (horasExtra));
            horasExtra = 0;
            return aux;


        }
        public double AcumulaHoraExtra(double quant)
        {
            return horasExtra = horasExtra + quant;
        }

    }
}