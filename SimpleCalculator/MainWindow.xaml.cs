/**
 * GUI interaction for a simple calculator program.
 * 
 * @author - Jeffrey Bromen
 * @date   - 4/28/2017
 */

using System.ComponentModel;
using System.Windows;

namespace SimpleCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Calculator calc;

        private string display;

        public string Display
        {
            get { return display; }
            set
            {
                display = value;
                RaisePropertyChanged("Display");
            }
        }

        private void RaisePropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public MainWindow()
        {
            InitializeComponent();

            calc = new Calculator();

            this.DataContext = this;

            Display = calc.Display;
        }

        private void Click_Button_CE(object sender, RoutedEventArgs e)
        {
            calc.ClearAll();
            Display = calc.Display;
        }

        private void Click_Button_Back(object sender, RoutedEventArgs e)
        {
            calc.Backspace();
            Display = calc.Display;
        }

        private void Click_Button_Mod(object sender, RoutedEventArgs e)
        {
            calc.Operation(CalculatorOperations.Modulo);
            Display = calc.Display;
        }

        private void Click_Button_Plus(object sender, RoutedEventArgs e)
        {
            calc.Operation(CalculatorOperations.Add);
            Display = calc.Display;
        }

        private void Click_Button_7(object sender, RoutedEventArgs e)
        {
            calc.AppendDigit("7");
            Display = calc.Display;
        }

        private void Click_Button_8(object sender, RoutedEventArgs e)
        {
            calc.AppendDigit("8");
            Display = calc.Display;
        }

        private void Click_Button_9(object sender, RoutedEventArgs e)
        {
            calc.AppendDigit("9");
            Display = calc.Display;
        }

        private void Click_Button_Minus(object sender, RoutedEventArgs e)
        {
            calc.Operation(CalculatorOperations.Subtract);
            Display = calc.Display;
        }

        private void Click_Button_4(object sender, RoutedEventArgs e)
        {
            calc.AppendDigit("4");
            Display = calc.Display;
        }

        private void Click_Button_5(object sender, RoutedEventArgs e)
        {
            calc.AppendDigit("5");
            Display = calc.Display;
        }

        private void Click_Button_6(object sender, RoutedEventArgs e)
        {
            calc.AppendDigit("6");
            Display = calc.Display;
        }

        private void Click_Button_Mul(object sender, RoutedEventArgs e)
        {
            calc.Operation(CalculatorOperations.Multiply);
            Display = calc.Display;
        }

        private void Click_Button_1(object sender, RoutedEventArgs e)
        {
            calc.AppendDigit("1");
            Display = calc.Display;
        }

        private void Click_Button_2(object sender, RoutedEventArgs e)
        {
            calc.AppendDigit("2");
            Display = calc.Display;
        }

        private void Click_Button_3(object sender, RoutedEventArgs e)
        {
            calc.AppendDigit("3");
            Display = calc.Display;
        }

        private void Click_Button_Div(object sender, RoutedEventArgs e)
        {
            calc.Operation(CalculatorOperations.Divide);
            Display = calc.Display;
        }

        private void Click_Button_Sign(object sender, RoutedEventArgs e)
        {
            calc.ChangeSign();
            Display = calc.Display;
        }

        private void Click_Button_0(object sender, RoutedEventArgs e)
        {
            calc.AppendDigit("0");
            Display = calc.Display;
        }

        private void Click_Button_Decimal(object sender, RoutedEventArgs e)
        {
            calc.AppendDecimal();
            Display = calc.Display;
        }

        private void Click_Button_Equal(object sender, RoutedEventArgs e)
        {
            calc.Equals();
            Display = calc.Display;
        }
    }
}
