using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dop1
{
    public interface ICalculatable
    {
        double Add(double a, double b);

        double Subtract(double a, double b);

        double Multiply(double a, double b);

        double Divide(double a, double b);
    }
    public class SimpleCalculator : ICalculatable
    {
        public double Add(double a, double b)
        {
            double result = a + b;
            PrintResult("Addition", a, b, result);
            return result;
        }

        public double Subtract(double a, double b)
        {
            double result = a - b;
            PrintResult("Subtraction", a, b, result);
            return result;
        }

        public double Multiply(double a, double b)
        {
            double result = a * b;
            PrintResult("Multiplication", a, b, result);
            return result;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                return 0;
            }

            double result = a / b;
            PrintResult("Division", a, b, result);
            return result;
        }

        private void PrintResult(string operation, double operand1, double operand2, double result)
        {
            Console.WriteLine($"{operation} of {operand1} and {operand2} is: {result}");
        }
    }
    public class AdvancedCalculator : ICalculatable
    {
        public double Add(double a, double b)
        {
            double result = a + b;
            PrintResult("Addition", a, b, result);
            return result;
        }

        public double Subtract(double a, double b)
        {
            double result = a - b;
            PrintResult("Subtraction", a, b, result);
            return result;
        }

        public double Multiply(double a, double b)
        {
            double result = a * b;
            PrintResult("Multiplication", a, b, result);
            return result;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                return 0;
            }

            double result = a / b;
            PrintResult("Division", a, b, result);
            return result;
        }

        public double Power(double baseValue, double exponent)
        {
            double result = Math.Pow(baseValue, exponent);
            PrintResult("Power", baseValue, exponent, result);
            return result;
        }

        public double SquareRoot(double value)
        {
            if (value < 0)
            {
                Console.WriteLine("Error: Cannot calculate square root of a negative number.");
                return 0;
            }

            double result = Math.Sqrt(value);
            PrintResult("Square Root", value, 0.5, result);
            return result;
        }

        private void PrintResult(string operation, double operand1, double operand2, double result)
        {
            Console.WriteLine($"{operation} of {operand1} and {operand2} is: {result}");
        }
    }

}
