/**
 * A basic calculator class implementation.
 * 
 * @author - Jeffrey Bromen
 * @date   - 4/28/2017
 */

using System;
using System.Linq;
using System.Text;

namespace SimpleCalculator
{
    enum CalculatorOperations { NoOp, Add, Subtract, Multiply, Divide, Modulo };

    class Calculator
    {
        private double Num1 { get; set; }
        private double Num2 { get; set; }
        private double Result { get; set; }

        private StringBuilder sb = new StringBuilder();

        private string display;
        public string Display
        {
            get { return display; }
            set
            {
                display = value != "" ? value : "0";
            }
        }

        private CalculatorOperations Mode = CalculatorOperations.NoOp;

        public Calculator() { Display = "0"; }

        public void AppendDigit(string digit)
        {
            if (digit.All(Char.IsDigit))
                sb.Append(digit);

            Display = sb.ToString();
        }

        public void AppendDecimal()
        {
            if (!sb.ToString().Contains('.'))
                sb.Append('.');

            Display = sb.ToString();
        }

        public void ChangeSign()
        {
            if (sb.Length == 0)
                return;

            if (sb[0] != '-')
                sb.Insert(0, '-');
            else
                sb.Remove(0, 1);

            Display = sb.ToString();
        }

        public void ClearAll()
        {
            Num1 = 0;
            Num2 = 0;
            Result = 0;
            Mode = CalculatorOperations.NoOp;
            sb.Clear();
            Display = sb.ToString();
        }

        public void Backspace()
        {
            if (sb.Length > 0)
                sb.Remove(sb.Length - 1, 1);

            Display = sb.ToString();
        }

        public void Operation(CalculatorOperations mode)
        {
            if (sb.Length == 0)
            {
                Mode = mode;
                return;
            }

            Equals();

            if (Mode == CalculatorOperations.NoOp && sb.Length > 0)
            {
                Num1 = Convert.ToDouble(sb.ToString());
                sb.Clear();
                Mode = mode;
            }
        }

        public void Equals()
        {
            if (Mode == CalculatorOperations.NoOp || sb.Length == 0)
                return;

            Num2 = Convert.ToDouble(sb.ToString());
            sb.Clear();

            switch (Mode)
            {
                case CalculatorOperations.Add:
                    Result = Num1 + Num2;
                    break;

                case CalculatorOperations.Subtract:
                    Result = Num1 - Num2;
                    break;

                case CalculatorOperations.Multiply:
                    Result = Num1 * Num2;
                    break;

                case CalculatorOperations.Divide:
                    Result = Num1 / Num2;
                    break;

                case CalculatorOperations.Modulo:
                    Result = Num1 % Num2;
                    break;
            };

            Mode = CalculatorOperations.NoOp;
            sb.Append(Result.ToString());

            Display = Result.ToString();
        }
    }
}
