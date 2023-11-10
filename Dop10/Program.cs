using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Dop10
{
    public interface ICalculatable
    {
        double Add(double a, double b);
        double Subtract(double a, double b);
        double Multiply(double a, double b);
        double Divide(double a, double b);
    }

    public interface IStorable
    {
        void SaveState(string fileName);
        void LoadState(string fileName);
    }

    public class SimpleCalculator : ICalculatable
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero!");
                return double.NaN;
            }
            return a / b;
        }

        public void DisplayResult(double result)
        {
            Console.WriteLine($"Result: {result}");
        }
    }

    public class AdvancedCalculator : ICalculatable, IStorable
    {
        private double result;
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero!");
                return double.NaN;
            }
            return a / b;
        }

        public double Power(double a, double exponent) => Math.Pow(a, exponent);
        public double SquareRoot(double a) => Math.Sqrt(a);

        public void DisplayResult(double result)
        {
            Console.WriteLine($"Result: {result}");
        }

        public void SaveState(string fileName)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, this);
                }
                Console.WriteLine("State saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving state: {ex.Message}");
            }
        }

        public void LoadState(string fileName)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    AdvancedCalculator loadedCalculator = (AdvancedCalculator)formatter.Deserialize(fs);
                    CopyState(loadedCalculator);
                }
                Console.WriteLine("State loaded successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading state: {ex.Message}");
            }
        }

        private void CopyState(AdvancedCalculator other)
        {
            this.result = other.result;
        }
    }

    class Program
    {
        static void Main()
        {
            SimpleCalculator simpleCalculator = new SimpleCalculator();
            double result1 = simpleCalculator.Add(5, 3);
            simpleCalculator.DisplayResult(result1);

            AdvancedCalculator advancedCalculator = new AdvancedCalculator();
            double result2 = advancedCalculator.Power(2, 3);
            advancedCalculator.DisplayResult(result2);

            //Сохранение ошибка
            advancedCalculator.SaveState("calculator_state.txt");
            advancedCalculator.LoadState("calculator_state.txt");
            Console.ReadKey();
        }
    }
}
