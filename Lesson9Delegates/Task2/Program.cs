using System;

namespace Task2
{
    public delegate int Mathematic(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            Mathematic Add = (a, b) => { return a + b; };
            Mathematic Sub = (a, b) => a - b;
            Mathematic Mul = (a, b) => a * b;
            Mathematic Div = (a, b) => b != 0 ? a / b : 0;
            Console.Write("Enter first number: ");
            int number1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int number2 = Int32.Parse(Console.ReadLine());
            Console.Write("Choose action (+, -, *, /): ");
            string action = Console.ReadLine();
            int result = 0;
            switch(action)
            {

                case "+":
                    {
                        result = Add(number1, number2);
                        break;
                    }
                case "-":
                    {
                        result = Sub(number1, number2);
                        break;
                    }
                case "*":
                    {
                        result = Mul(number1, number2);
                        break;
                    }
                case "/":
                    {
                        result = Div(number1, number2);
                        break;
                    }
                default: break;
            }
            Console.Write($"Result: {result}");
            Console.ReadKey();
        }
    }
}
