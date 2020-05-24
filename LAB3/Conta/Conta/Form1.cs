using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Depositar_Click(object sender, EventArgs e)
        {
            Depósito C1 = new Depósito();
            C1.Show();
        }

        private void button_Saque_Click(object sender, EventArgs e)
        {
            Saque C1 = new Saque();
            C1.Show();
        }

        private void button_Extrato_Click(object sender, EventArgs e)
        {
            Extrato C1 = new Extrato();
            C1.Show();
        }

        private void button_Transferência_Click(object sender, EventArgs e)
        {
            Transferência C1 = new Transferência();
            C1.Show();
        }

        private void button_Saldo_Click(object sender, EventArgs e)
        {
            Saldo C1 = new Saldo();
            C1.Show();
        }

        private void button_Excluir_Click(object sender, EventArgs e)
        {
            Excluir C1 = new Excluir();
            C1.Show();
        }

        private void button_Criar_Click(object sender, EventArgs e)
        {
            CriarConta C1 = new CriarConta();
            C1.Show();
        }

        private void label_CaixaEletronico_Click(object sender, EventArgs e)
        {

        }
    }
}
