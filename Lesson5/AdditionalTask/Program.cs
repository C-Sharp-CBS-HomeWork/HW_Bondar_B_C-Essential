using System;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Dictionary advanceDictionary = new Dictionary();
            Console.WriteLine(advanceDictionary["клубника"]);
            Console.WriteLine(advanceDictionary["house"]);
            Console.WriteLine(advanceDictionary["пошта"]);
            Console.WriteLine(advanceDictionary["авто"]);
            Console.WriteLine(advanceDictionary["улица"]);

            Console.WriteLine(new string('-', 30));

            Console.WriteLine(advanceDictionary["неделя"]);
            Console.WriteLine(advanceDictionary["тиждень"]);
            Console.WriteLine(advanceDictionary["week"]);

            Console.WriteLine(new string('-', 30));

            Console.WriteLine(advanceDictionary[0]);
            Console.WriteLine(advanceDictionary[7]);
            Console.ReadKey();
        }
    }
}
