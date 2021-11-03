using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = new int[10];

            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-25, 25);
            }

            Console.Write("Значения массива: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine($"\nMax: {MaxValue(array)}");
            Console.WriteLine($"Min: {MinValue(array)}");
            int summ = ArraySumm(array);
            Console.WriteLine($"Summ: {summ}");
            Console.WriteLine($"Average: {ArrayAverage(array)}");

            Console.WriteLine("Нечетные значения:");
            ShowOdd(array);


            Console.ReadKey();
        }
        static int MaxValue(int[] array)
        {
            int maxValue = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                    maxValue = array[i];
            }
            return maxValue;
        }
        static int MinValue(int[] array)
        {
            int minValue = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue)
                    minValue = array[i];
            }
            return minValue;
        }
        static int ArraySumm(int[] array)
        {
            int arraySumm = 0;
            for (int i = 0; i < array.Length; i++)
            {
                arraySumm += array[i];
            }
            return arraySumm;
        }
        static double ArrayAverage(int[] array)
        {
            double summ = ArraySumm(array);
            double average = summ / array.Length;
            return average;
        }
        static void ShowOdd(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] % 2 != 0)
                    Console.Write(array[i] + ", ");
        }
    }
}
