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

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {

            }
        }       

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the value of the button
            int selectedValue = int.Parse((sender as Button).Content.ToString());          

            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = $"{selectedValue}";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}{selectedValue}";
            }
        }

        private void buttonComma_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "0,";
            }
            else if (resultLabel.Content.ToString().Contains(",") || resultLabel.Content.ToString().Contains("E"))
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
