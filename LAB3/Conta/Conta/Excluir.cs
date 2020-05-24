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
    public partial class Excluir : Form
    {
        public Excluir()
        {
            InitializeComponent();
        }

        private void button1_excluir_Click(object sender, EventArgs e)
        {
            Controle.ExcluirConta(Convert.ToInt32(textBox1_excluir.Text));
        }
    }
}
