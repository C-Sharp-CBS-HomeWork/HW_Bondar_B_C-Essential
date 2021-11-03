using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rowInput = false, columnInput = false;
            int rowNumber = 0, columnNumber = 0;
            while (!rowInput)
            {
                Console.Write("Enter number of rows:");
                rowInput = int.TryParse(Console.ReadLine(), out rowNumber);
            }
            while (!columnInput)
            {
                Console.Write("Enter number of columns:");
                columnInput = int.TryParse(Console.ReadLine(), out columnNumber);
            }
            

            MyMatrix test = new MyMatrix(rowNumber, columnNumber);
            test.ShowMatrix();
            Console.ReadKey();

        }
    }
}
