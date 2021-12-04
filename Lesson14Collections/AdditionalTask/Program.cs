using System;
using System.Collections;
using System.Collections.Generic;

namespace AdditionalTask
{
    class YieldMethod
    {
        public static IEnumerable GetEven(int[] array)
        {
            foreach (int item in array)
            {
                if (item % 2 == 0)
                {
                    yield return item;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 4, 5, 8, 9, 12, 24, 10, 1 };
            foreach(int element in YieldMethod.GetEven(array))
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
