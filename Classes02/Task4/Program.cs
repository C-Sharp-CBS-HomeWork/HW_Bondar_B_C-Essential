using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice test = new Invoice(1, "Покупатель", "Поставщик");
            test.Payment("v", 5);

            // проверка ввода
            Console.WriteLine("\nУкажите артикул (a, b, c):");
            string article = Console.ReadLine();
            Console.WriteLine("Введите количество:");
            int quantity = Convert.ToInt32(Console.ReadLine());
            test.Payment(article, quantity);

            Console.ReadKey();
        }
    }
}
