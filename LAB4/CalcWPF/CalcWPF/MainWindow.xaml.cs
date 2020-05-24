using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalcWPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

      private void Op1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Soma_Click(object sender, RoutedEventArgs e)
        {
            try{
            double r = ( double.Parse( op1.Text ) + double.Parse( op2.Text )); 
            Result.Text =  Convert.ToString( r );
            }catch(FormatException fe)
            { 
                MessageBox.Show(fe.Message);
            }
        }

        private void Subtracao_Click(object sender, RoutedEventArgs e)
        {   
            try{
             double r = ( double.Parse( op1.Text ) - double.Parse( op2.Text )); 
            Result.Text =  Convert.ToString( r );
           }catch(FormatException fe)
            { 
                MessageBox.Show(fe.Message);
            }
        }

        private void Multiplicacao_Click(object sender, RoutedEventArgs e)
        {
            try{
             double r = ( double.Parse( op1.Text ) * double.Parse( op2.Text )); 
            Result.Text =  Convert.ToString( r );
            }catch(FormatException fe)
            { 
                MessageBox.Show(fe.Message);
            }
        }

        private void Divisao_Click(object sender, RoutedEventArgs e)
        {

            try{   
            if ( double.Parse(op2.Text) == 0.0){
                MessageBox.Show("ERRO: Impossivel divisao por zero.");
            }
            else{
             double r = ( double.Parse( op1.Text ) / double.Parse( op2.Text )); 
            Result.Text =  Convert.ToString( r );
            }
            }catch(FormatException fe)
            { 
                MessageBox.Show(fe.Message);
            }
            }
            }

    }
