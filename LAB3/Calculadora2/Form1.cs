using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int operacao = 1;
        double a, b,resu;

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 2;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 3;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1,num2,resu=0;

            try
            {

                num1 = Double.Parse(textBox1.Text);
                num2 = Double.Parse(textBox3.Text);

                if (operacao == 1)
                {
                    resu = num1 + num2;
                    textBox2.Text = resu.ToString();
                }
                else if (operacao == 2)
                {
                    resu = num1 - num2;
                    textBox2.Text = resu.ToString();
                }
                else if (operacao == 3)
                {
                    resu = num1 * num2;
                    textBox2.Text = resu.ToString();
                }
                else if (operacao == 4 && num2 != 0)
                {
                    resu = num1 / num2;
                    textBox2.Text = resu.ToString();
                }
                else MessageBox.Show("Impossivel efetuar divisao por 0.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Operadores nao identificado.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
            textBox3.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                b = Double.Parse(textBox1.Text);
                a = Double.Parse(textBox3.Text);
                resu = a * b;
                textBox2.Text = resu.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Operadores nao identificado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                a = Double.Parse(textBox1.Text);
                b = Double.Parse(textBox3.Text);
                resu = a - b;
                textBox2.Text = resu.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Operadores nao identificado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                a = Double.Parse(textBox1.Text);
                b = Double.Parse(textBox3.Text);
                resu = a / b;
                if (b != 0)
                {
                    textBox2.Text = resu.ToString();
                }
                else MessageBox.Show("Impossivel efetuar divisao por 0.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException x)
            {
                MessageBox.Show(x.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //catch ( DivideByZeroException z)
            //{
            //    MessageBox.Show(z.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
           
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                b = Double.Parse(textBox1.Text);
                a = Double.Parse(textBox3.Text);
                resu = a + b;
                textBox2.Text = resu.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Operadores nao identificado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
