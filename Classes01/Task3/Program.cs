using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book instance = new Book("Старик и море", "Э. Хемингуэй", "Повесть");
            instance.Show();

            Console.ReadKey();

        }
    }
}
