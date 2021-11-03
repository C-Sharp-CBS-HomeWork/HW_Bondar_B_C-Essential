using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Article apple = new Article("Apple", "Silpo", 27.99M);
            Article peach = new Article("Peach", "Auchan", 35M);
            Article kiwi = new Article("Kiwi", "Novus", 31.50M);
            Article banana = new Article("Banana", "Auchan", 21.49M);
            Article orange = new Article("Orange", "Novus", 29.99M);

            Store fruits = new Store(apple, peach, kiwi, banana, orange);

            // Доступ по имени екземпляра класса ARTICLE
            /*Console.WriteLine(fruits[apple]);
            Console.WriteLine(fruits[peach]);
            Console.WriteLine(fruits[kiwi]);
            Console.WriteLine(fruits[banana]);
            Console.WriteLine(fruits[orange]);
            Console.WriteLine(fruits[lime]);*/

            Console.WriteLine(new string('-', 30));

            Console.WriteLine(fruits["Apple"]);
            Console.WriteLine(fruits["Peach"]);
            Console.WriteLine(fruits["Kiwi"]);
            Console.WriteLine(fruits["Banana"]);
            Console.WriteLine(fruits["Orange"]);
            Console.WriteLine(fruits["Strawberry"]);

            Console.WriteLine(new string('-', 30));

            Console.WriteLine(fruits[0]);
            Console.WriteLine(fruits[1]);
            Console.WriteLine(fruits[2]);
            Console.WriteLine(fruits[3]);
            Console.WriteLine(fruits[4]);
            Console.WriteLine(fruits[5]);

            Console.WriteLine(new string('-', 30));

            // Ввод с клавиатуры
            Console.Write("Enter item name: ");
            string userInput = Console.ReadLine();
            Console.WriteLine(fruits[userInput]);


            Console.ReadKey();


        }
    }
}
