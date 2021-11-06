using System;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 7;
            Console.WriteLine(Calculator.PlusMethod(x, y));
            Console.WriteLine(Calculator.MinusMethod(x, y));
            Console.WriteLine(Calculator.MultiplyMetod(x, y));
            Console.WriteLine(Calculator.DivideMethod(x, y));

            Console.ReadKey();
        }
    }
}
