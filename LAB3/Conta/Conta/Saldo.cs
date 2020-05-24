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
    public partial class Saldo : Form
    {
        public Saldo()
        {
            InitializeComponent();
        }

        private void button1_saldo_Click(object sender, EventArgs e)
        {
            Controle.Saldo(Convert.ToInt32(textBox1_saldo.Text));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //metodo vazio,inutil
        }
    }
}
