using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._2
{
    class Controle
    {
        const int Contas = 100;
        static Conta[] vetContas = new Conta[Contas];
        static int cont = 0;

        public static void CriarConta(string titular) //método para criar uma conta
        {
            try
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
            catch (FormatException)
            {
                MessageBox.Show("Formato de entrada errado.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void ExcluirConta(int contC)//metodo para excluir uma conta
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Formato de entrada errado.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Depositar(double valor, int contC)//metodo para depositar em uma conta
        {
            try
            {
                if (contC > 0 && contC <= cont)
                {
                    if (vetContas[contC - 1].AcessorExcluir)
                    {
                        vetContas[contC - 1].Deposita(valor);

                        if (valor <= 0)
                        {
                            throw new ArgumentException("Impossivel depositar valor negativo.");
                        }
                        else MessageBox.Show("Valor depositado com sucesso!" + valor, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else MessageBox.Show("Conta não existente.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Formato de entrada errado.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Saque(double valor, int contC)//metodo para sacar em uma conta
        {
            try
            {
                if (contC > 0 && contC <= cont)
                {
                    if (vetContas[contC - 1].AcessorExcluir)
                    {
                        vetContas[contC - 1].Retira(valor);

                        if (valor <= 0)
                        {
                            throw new ArgumentException("Impossivel sacar valor negativo.");
                        }
                        else MessageBox.Show("Valor sacado com sucesso!" + valor, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else MessageBox.Show("Conta não existente.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Formato de entrada errado.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static void Transferir(int contC, double valor, int contS) //metodo para transferir dinheiro
        {
            try
            {
                if (vetContas[contC - 1].AcessorExcluir)
                {
                    if (vetContas[contC - 1].Retira(valor) != -1)
                    {
                        vetContas[contS - 1].Deposita(valor);

                        MessageBox.Show("Valor transferido com sucesso!" + valor, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else throw new ArgumentException("Impossivel transferir valor negativo.");
                }
                else MessageBox.Show("Conta não existente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Formato de entrada errado.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
}

