using System;
using System.Text;

namespace AdditionalTask
{
    class Calculator
    {
        public void Add( int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);
        }
        public void Sub(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);
        }
        public void Mul (int x, int y)
        {
            int result = x * y;
            Console.WriteLine(result);
        }
        public void Div(double x, double y)
        {
            try
            {
                double result = x / y;
                if (y == 0)
                {
                    throw new DivideByZeroException();
                }
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Calculator test = new Calculator();
            int x;
            int y;
            while (true)
            {
                //1st number
                while (true)
                {
                    Console.Write("Type first digit: ");
                    string inputX = Console.ReadLine();
                    if (!Int32.TryParse(inputX, out x))
                    {
                        Console.WriteLine("Incorrect symbol! Please, try again");
                    }
                    else
                    {
                        break;
                    }
                }
                //2nd number
                while (true)
                {
                    Console.Write("Type second digit: ");
                    string inputY = Console.ReadLine();
                    if (!Int32.TryParse(inputY, out y))
                    {
                        Console.WriteLine("Incorrect symbol! Please, try again");
                    }
                    else
                    {
                        break;
                    }
                }
                // operator;
                bool operatorChoosen = false;
                while (!operatorChoosen)
                {
                    Console.WriteLine("Choose operation (+, -, *, /): ");
                    string operation = Console.ReadLine();
                    switch (operation)
                    {
                        case "+":
                            {
                                test.Add(x, y);
                                operatorChoosen = true;
                                break;
                            }
                        case "-":
                            {
                                test.Sub(x, y);
                                operatorChoosen = true;
                                break;
                            }
                        case "*":
                            {
                                test.Mul(x, y);
                                operatorChoosen = true;
                                break;
                            }
                        case "/":
                            {
                                test.Div(x, y);
                                operatorChoosen = true;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Incorrect symbol! Please, try again");
                                break;
                            }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
