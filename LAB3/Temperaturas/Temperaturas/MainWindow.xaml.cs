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

// Porgrama Temperaturas xaml
//	Programador(es): Bernardo M.( 613081 ), Caio Lucas(604365),Wernen Rodrigues(597704).


namespace Temperaturas
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
         //Celsius para Fahrenheit
         private void bClick01(object sender, RoutedEventArgs e)
        {
            int temp = int.Parse( numInicial.Text );
            tBlock1.Text = Convert.ToString(  (temp*9/5)+32  )+"ºF";  
        }

        //Fahrenheit para Celsius
        private void bClick02(object sender, RoutedEventArgs e)
        { 
            int temp = int.Parse( numInicial.Text );
            tBlock2.Text = Convert.ToString(  (temp - 32)* 5/9  )+"ºC";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
