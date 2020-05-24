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
    public partial class Extrato : Form
    {
        public Extrato()
        {
            InitializeComponent();
        }

        private void Button1_extrato_Click(object sender, EventArgs e)
        {
            string guardaExtrato;
            guardaExtrato = Controle.Extrato(Convert.ToInt32(textBox1_conta.Text));
            listBox1_extrato.Text = guardaExtrato;
        }
    }
}
