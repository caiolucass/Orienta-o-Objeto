using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Ex32_LAB2_s218
{
    class Conta
    {
        // atributos
        private int numero;
        private double saldo = 0;
        private int agencia;
        string titular;
        static int cont = 0;
        bool excluir= false;
        // metodos

        public Conta(int agencia, int numero, string titular)
        { // construtor
            this.agencia = agencia;
            this.numero = numero;
            this.titular = titular;
            cont++;
            excluir = true;
        }


        public double Deposita(double valor)
        {
            if (valor <= 0)
                return -1;
            else
            {
                saldo += valor;
                return valor;
            }
        }





        public double Retira(double valor)
        {
            if ((saldo >= valor) && (valor > 0))
            {
                saldo -= valor;
                return valor;
            }
            else
                return -1;
        }


        // Propriedades: getters e setters


        public double Saldo
        {
            get { return saldo; }
            set
            {
                if (value > 0.0) saldo = value;
                else saldo = 0.0;
            }
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



    } // fim da classe Conta
}
