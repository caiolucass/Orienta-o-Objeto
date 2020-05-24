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
    public partial class CriarConta : Form
    {
        public CriarConta()
        {
            InitializeComponent();
        }

        private void label1_Criar_Click(object sender, EventArgs e)
        {
     
        }

        private void textBox1_Criar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Criar_Click(object sender, EventArgs e)
        {
            Controle.CriarConta(textBox1_Criar.Text);
        }
    }
}
