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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double number1 =0;
        double number2 = 0;
        double result = 0;
        string operation = " ";

        public MainWindow()
        {
            InitializeComponent();
            radioPlus.IsChecked = true;
            operation = "+";

        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            bool number1Ok = double.TryParse(tbxNumber1.Text, out number1);
            bool number2Ok = double.TryParse(tbxNumber2.Text, out number2);

            if(number1Ok && number2Ok)
            {
                switch(operation)
                {
                    case "+":
                        
                            result = number1 + number2;
                        tbxResult.Text = result.ToString();
                        break;
                        
                    case "-":
                        
                            result = number1 - number2;
                        tbxResult.Text = result.ToString();
                        break;
                        
                }

            }
            else
            {
                MessageBox.Show("You need to introduce an actual number");
            }

        }

        private void BtnResult_Click(object sender, RoutedEventArgs e)
        {
            tbxNumber1.Text = " ";
            tbxNumber2.Text = " ";
            tbxResult.Text = "  ";

        }

        private void RadioPlus_CheckedChanged(object sender, RoutedEventArgs e)
        {
            operation = "+";

        }

        private void RadioMinus_Checked(object sender, RoutedEventArgs e)
        {
            operation = "-";
        }
    }
}
