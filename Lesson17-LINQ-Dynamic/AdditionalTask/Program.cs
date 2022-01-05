using System;

namespace AdditionalTask
{
    class DynamicCalculator
    {
        public dynamic Add (dynamic x, dynamic y)
        {
            try
            {
                dynamic result = x + y;
                return result;
            }
            catch
            {
                Console.WriteLine("Incompatible types!");
                return 0;
            }
        }
        public dynamic Sub (dynamic x, dynamic y)
        {
            try
            {
                dynamic result = x - y;
                return result;
            }
            catch
            {
                Console.WriteLine("Incompatible types!");
                return 0;
            }
        }
        public dynamic Mul (dynamic x, dynamic y)
        {
            try
            {
                dynamic result = x * y;
                return result;
            }
            catch
            {
                Console.WriteLine("Incompatible types!");
                return 0;
            }
        }
        public dynamic Div (dynamic x, dynamic y)
        {
            try
            {
                dynamic result = x / y;
                return result;
            }
            catch
            {
                Console.WriteLine("Incompatible types!");
                return 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new DynamicCalculator();
            Console.WriteLine(calculator.Add(1, "w"));
            Console.WriteLine(calculator.Sub(1, 0.5));
            Console.WriteLine(calculator.Mul(1, 'f'));
            Console.WriteLine(calculator.Div(1, "string"));
            Console.ReadKey();
        }
    }
}
