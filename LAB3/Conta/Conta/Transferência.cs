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
    public partial class Transferência : Form
    {
        public Transferência()
        {
            InitializeComponent();
        }

        private void button1_transferir_Click(object sender, EventArgs e)
        {
            Controle.Transferir(Convert.ToInt32(textBox2_transferir.Text),
            Convert.ToDouble(textBox1_transferir.Text),
            Convert.ToInt32(textBox1_NcontaReceber));
        }

        private void textBox1_transferir_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
