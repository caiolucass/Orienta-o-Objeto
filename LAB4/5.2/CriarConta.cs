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
    public partial class CriarConta : Form
    {
        public CriarConta()
        {
            InitializeComponent();
        }

        private void Button1_cadastro_Click(object sender, EventArgs e)
        {
            Controle.CriarConta(textBox1_cadastro.Text);
        }
    }
}
