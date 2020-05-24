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
    public partial class Extrato : Form
    {
        public Extrato()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //metodo vazio,inutil
        }

        private void button1_Extrato_Click(object sender, EventArgs e)
        {
            string guardaExtrato;
            guardaExtrato = Controle.Extrato(Convert.ToInt32(textBox1_Extrato.Text));
            listBox1_Extrato.Text = guardaExtrato;
        }
    }
}
