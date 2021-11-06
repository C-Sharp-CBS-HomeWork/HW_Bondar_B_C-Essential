using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 3, 45, 9, -1, 0, 28, 32, 3, 7, 100 };
            test.AscendingSort();
            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }
            Console.ReadKey();
        }
    }
}
