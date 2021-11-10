using System;

namespace Task2
{
    enum Colors
    {
        red = 1,
        yellow = 2,
        green = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text: ");
            string input = Console.ReadLine();
            Console.WriteLine("Choose color (red, yellow, green): ");
            object userInput = Enum.Parse(typeof(Colors), Console.ReadLine().ToLower());
            int userColor = (int)userInput;
            Printer.Print(input, userColor);
            Console.ReadKey();
        }
    }
}
