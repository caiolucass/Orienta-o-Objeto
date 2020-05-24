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
    public partial class Transferencia : Form
    {
        public Transferencia()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            //metodo nulo e/ou vazio
        }

        private void Button1_transferir_Click(object sender, EventArgs e)
        {
            Controle.Transferir(Convert.ToInt32(textBox1.Text),
            Convert.ToDouble(textBox2.Text),
            Convert.ToInt32(textBox3_receber));
        }
    }
}
