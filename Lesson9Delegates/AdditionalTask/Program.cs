using System;

namespace AdditionalTask
{
    public delegate double Average(int a, int b, int c);
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 2, number2 = 1, number3 = 4; 
            double result;
            Average averageNumber = delegate (int a, int b, int c) { return (double)(a + b + c) / 3; };
            result = averageNumber(number1, number2, number3);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
