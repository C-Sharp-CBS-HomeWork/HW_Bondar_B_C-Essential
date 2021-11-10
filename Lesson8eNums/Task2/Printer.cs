using System;

namespace Task2
{
    static class Printer
    {
        public static void Print(string stroka, int color)
        {
            Colors userChoice = (Colors)color;
            switch (userChoice) 
            {
                case Colors.red:
                {
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                }
                case Colors.yellow:
                {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                }
                case Colors.green:
                {
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }
            }
            Console.WriteLine(stroka);
            Console.ResetColor();
        }
    }
}
