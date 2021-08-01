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
        SelectedOperator selectedOperator;

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
                result = 0;
                lastNumber = 0;                
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
            double tempNumber;

            if (double.TryParse(resultLabel.Content.ToString(), out tempNumber))
            {
                tempNumber = tempNumber / 100;
                if (lastNumber != 0)
                    tempNumber *= lastNumber;
                resultLabel.Content = tempNumber.ToString();
            }
        }       

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                resultLabel.Content = "0";
            }

            if (sender == buttonDivide)                
                selectedOperator = SelectedOperator.Division;
            if (sender == buttonMinus)
                selectedOperator = SelectedOperator.Subtraction;
            if (sender == buttonMult)
                selectedOperator = SelectedOperator.Multiplication;
            if (sender == buttonPlus)
                selectedOperator = SelectedOperator.Addition;
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

        private void buttonEqual_Click(object sender, RoutedEventArgs e)
        {
            double newNumber;
            SimpleMath simpleMath = new SimpleMath();

            if (double.TryParse(resultLabel.Content.ToString(), out newNumber))
            {
                switch(selectedOperator)
                {
                    case SelectedOperator.Addition:
                        result = simpleMath.Add(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Division:
                            result = simpleMath.Div(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Multiplication:
                        result = simpleMath.Mult(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Subtraction:
                        result = simpleMath.Sub(lastNumber, newNumber);
                        break;
                }

                resultLabel.Content = result.ToString();
            }
        }

        public enum SelectedOperator
        {
            Addition,
            Subtraction,
            Multiplication,
            Division
        }

        public class SimpleMath
        {
            public double Add(double n1, double n2)
            {
                return n1 + n2;
            }

            public double Sub(double n1, double n2)
            {
                return n1 - n2;
            }

            public double Mult(double n1, double n2)
            {
                return n1 * n2;
            }

            public double Div(double n1, double n2)
            {
                if (n2 == 0)
                    MessageBox.Show("Division by 0 is not supported", "Calculator 1.0", MessageBoxButton.OK, MessageBoxImage.Error);
                    return 0;
                
                    return n1 / n2;
            }
        }
    }
}
