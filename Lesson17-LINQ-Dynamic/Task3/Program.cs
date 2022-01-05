using System;
using System.Collections;
using System.Collections.Generic;

namespace Task3
{
    class MyDictionary
    {
        public static IEnumerable GetPair()
        {
            yield return new { Key = 1, Value = "one" };
            yield return new { Key = 2, Value = "two" };
            yield return new { Key = 3, Value = "three" };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            foreach (dynamic item in MyDictionary.GetPair())
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            Console.ReadKey();
        }
    }
}
