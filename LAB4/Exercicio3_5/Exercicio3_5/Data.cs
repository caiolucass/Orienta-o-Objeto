using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_5
{
    class Data
    {
        int dia;
        int mes;
        int ano;

        public Data()
        {

        }

        public Data( int day, int month, int year)
        {
            this.Dia = day;
            this.Mes = month;
            this.Ano = year;
        }

        public int Dia
        {
            get { return dia; }
            set
            {
                dia = value;
            }
        }
        public int Mes
        {
            get { return mes; }
            set
            {
                mes = value;
            }
        }
        public int Ano
        {
            get { return ano; }
            set
            {
                ano = value;
            }
        }
    }
}
