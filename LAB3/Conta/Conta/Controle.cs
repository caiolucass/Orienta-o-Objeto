using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Conta
{
    class Controle
    {
        const int Contas = 100;
        static Conta[] vetContas = new Conta[Contas];
        static int cont = 0;

        public static void CriarConta(string titular) //método para criar uma conta
        {
            if (cont < Contas)
            {
                vetContas[cont] = new Conta(1, cont, titular);
                cont++;

                MessageBox.Show("Conta criada com sucesso!\n Número da agência: 1 + \n Número da Conta:" + (cont),
                 "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Número máximo de contas já atingido.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void ExcluirConta(int contC)//metodo para excluir uma conta
        {
            if (contC > 0 && contC <= cont)
            {
                if (vetContas[contC - 1].AcessorExcluir)
                {
                    vetContas[contC - 1].Excluir();
                    MessageBox.Show("Conta excluida com êxito.", "Excluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Conta já se encontra excluida.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else MessageBox.Show("Conta não existente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Depositar(double valor, int contC)//metodo para depositar em uma conta
        {
            if (contC > 0 && contC <= cont)
            {
                if (vetContas[contC - 1].AcessorExcluir)
                {
                    vetContas[contC - 1].Deposita(valor);

                    if (valor < 0)
                    {
                        MessageBox.Show("Impossível depositar um valor negativo.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Valor depositado com sucesso!" + valor, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("Conta não existente.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        public static void Saque(double valor, int contC)//metodo para sacar em uma conta
        {
            if (contC > 0 && contC <= cont)
            {
                if (vetContas[contC - 1].AcessorExcluir)
                {
                    vetContas[contC - 1].Retira(valor);

                    if (valor <= 0)
                    {
                        MessageBox.Show("Impossível sacar um valor negativo.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Valor sacado com sucesso!" + valor, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("Conta não existente.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void Transferir(int contC, double valor, int contS) //metodo para transferir dinheiro
        {
            if (vetContas[contC - 1].AcessorExcluir)
            {
                if (vetContas[contC - 1].Retira(valor) != -1)
                {
                    vetContas[contS - 1].Deposita(valor);
                }
                else MessageBox.Show("Impossível transferir valor negativo.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Conta não existente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static string Extrato(int Contc) //funçao para gerar extrato de toda movimentação da conta
        {
            if (vetContas[Contc - 1].AcessorExcluir)
            {
                return vetContas[Contc - 1].Extrato;
            }
            else return "Erro:Conta não existente.";
        }

        public static double Saldo(int contC) //metodo para mostrar o saldo
        {
            if (vetContas[contC - 1].AcessorExcluir)
            {
                return vetContas[contC - 1].Saldo();
            }
            else return 0.0;
        }

    }//fim classe controle
}//fim conta




