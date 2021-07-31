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

namespace Calculator1._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber, result;

        public MainWindow()
        {
            InitializeComponent();

            buttonAC.Click += buttonAC_Click;
        }

        private void buttonAC_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() != "0" || 
                (resultLabel.Content.ToString() == "0" && resultLabel.Content.ToString().Length >= 2))
            {
                resultLabel.Content = "0";
            }            
        }

        private void buttonNegative_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * -1;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void buttonPercent_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber / 100;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void buttonDivide_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonMult_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonEqual_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonSeven_Click(object sender, RoutedEventArgs e)
        {
            if(resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "7";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}7";
            }
        }

        private void buttonFour_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "4";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}4";
            }
        }

        private void buttonOne_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "1";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}1";
            }
        }

        private void buttonZero_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString().Length >= 1 && resultLabel.Content.ToString() != "0")
            {
                resultLabel.Content = $"{resultLabel.Content}0";
            }
            else
            {
                
            }
        }

        private void buttonEight_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "8";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}8";
            }
        }

        private void buttonFive_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "5";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}5";
            }
        }

        private void buttonTwo_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "2";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}2";
            }
        }

        private void buttonNine_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "9";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}9";
            }
        }

        private void buttonSix_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "6";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}6";
            }
        }

        private void buttonThree_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "3";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}3";
            }
        }

        private void buttonComma_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "0,";
            }
            else if (resultLabel.Content.ToString().Contains(","))
            {
                resultLabel.Content = resultLabel.Content;
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content},";
            }
        }
    }
}
