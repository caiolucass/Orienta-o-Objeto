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
    public partial class Depósito : Form
    {
        public Depósito()
        {
            InitializeComponent();
        }

        private void button1_Depositar_Click(object sender, EventArgs e)
        {
            Controle.Depositar(Convert.ToDouble(textBox1.Text),Convert.ToInt32(textBox2_Nconta.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //METODO VAZIO
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //METODO VAZIO
        }

        private void label1_Depósito_Click(object sender, EventArgs e)
        {
            //METODO VAZIO
        }

        private void textBox2_Nconta_TextChanged(object sender, EventArgs e)
        {
            //METODO VAZIO
        }
    }
}
