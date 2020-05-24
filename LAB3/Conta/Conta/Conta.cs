using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta
{
    class Conta
    {
        // atributos
        private int numero;
        private double saldo = 0;
        private int agencia;
        string titular;
        static int cont = 0;
        string extrato;
        bool excluir = false;

        // metodos
        public Conta(int agencia, int numero, string titular)
        { 
            // construtor
            this.agencia = agencia;
            this.numero = numero;
            this.titular = titular;
            cont++;
            excluir = true;
        }

        public double Deposita(double valor) //acessor deposito
        {
            if (valor <= 0)
                return -1;
            else
            {
                saldo += valor;
                extrato += "\n Depósito:" + valor;
                return valor;
            }
        }

        public double Retira(double valor) //acessor saque
        {
            if ((saldo >= valor) && (valor > 0))
            {
                saldo -= valor;
                extrato += "\n Saque:" + valor;
                return valor;
            }
            else
                return -1;
        }

        public double Saldo() //acessor saldo
        {
            if (saldo >= 0)
            {
                extrato += "\n Saldo:" + saldo;
                return saldo;
            }
            else
                return 0.0;
        }
        

        public string Extrato //acessor extrato
        {
            get { return extrato;}
            set { value = extrato; }
        }

        public bool Excluir() //testa o valor da exclusao

        {
            excluir = false;
            return (excluir);

        }
        public bool AcessorExcluir //returna o valor da condiçao
        {
            get { return excluir; }

        }
    }
}
