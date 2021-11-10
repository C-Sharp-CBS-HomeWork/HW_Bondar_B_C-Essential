using System;

namespace Task2Alternative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text: ");
            string stroka = Console.ReadLine();
            Console.WriteLine("Choose color: ");
            Array avaliableColors = Enum.GetValues(typeof(ConsoleColor));
            for (int i = 0; i < avaliableColors.Length; i++)
            {
                Console.WriteLine("{0} - {0:D}", avaliableColors.GetValue(i));
            }
            int color = Int32.Parse(Console.ReadLine());
            Print.Printer(stroka, color);
            Console.ReadKey();
        }
    }
}
