using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            Form2 OutroForm = new Form2();
            OutroForm.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 OutroForm2 = new Form3();
            OutroForm2.ShowDialog();
        }
    }
}
