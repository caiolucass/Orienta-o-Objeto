using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button1_cadastro_Click(object sender, EventArgs e)
        {
            CriarConta C1 = new CriarConta();
            C1.Show();
        }

        private void Button2_deposito_Click(object sender, EventArgs e)
        {
            Deposito C1 = new Deposito();
            C1.Show();
        }

        private void Button3_saque_Click(object sender, EventArgs e)
        {
            Saque C1 = new Saque();
            C1.Show();
        }

        private void Button4_transferencia_Click(object sender, EventArgs e)
        {
            Transferencia C1 = new Transferencia();
            C1.Show();
        }

        private void Button1_saldo_Click(object sender, EventArgs e)
        {
            Saldo C1 = new Saldo();
            C1.Show();
        }

        private void Button1_excluir_Click(object sender, EventArgs e)
        {
            Excluir C1 = new Excluir();
            C1.Show();
        }

        private void Button1_extrato_Click(object sender, EventArgs e)
        {
            Extrato C1 = new Extrato();
            C1.Show();
        }
    }
}
