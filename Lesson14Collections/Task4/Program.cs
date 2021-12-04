using System;
using System.Collections;
using System.Collections.Generic;

namespace Task4
{
    public static class ExtensionMethod
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            int capacity = 0;
            T[] array = new T[capacity];
            foreach (T item in list)
            {
                T[] newArray = new T[array.Length + 1];
                array.CopyTo(newArray, 0);
                newArray[array.Length] = item;
                array = newArray;
            }
            return array;
        }
    }
    class MyList<T> : IEnumerable<T>
    {
        T[] array = new T[0];

        int position = -1;
        // реализация IEnumerator
        public object Current
        {
            get
            {
                return array[position];
            }
        }
        public bool MoveNext()
        {
            if (position < array.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }
        public void Reset()
        {
            position = -1;
        }
        //реализация IEnumerable

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in array)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.GetEnumerator();
        }
        // методы из задания
        public void AddElement(T element)
        {
            T[] newArray = new T[array.Length +1];
            array.CopyTo(newArray, 0);
            newArray[array.Length] = element;
            array = newArray;
        }
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                    return array[index];
                else
                    Console.WriteLine("Array out-of-bounds!");
                return default;
            }
        }
        public int Count
        {
            get
            {
                return array.Length;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> test2 = new MyList<int>();
            Console.WriteLine("Count: " + test2.Count);
            test2.AddElement(1);
            test2.AddElement(2);
            test2.AddElement(3);


            Console.WriteLine("\n" + test2.MoveNext());
            Console.WriteLine(test2.Current);
            Console.WriteLine(test2.MoveNext());
            Console.WriteLine(test2.Current);
            Console.WriteLine(test2.MoveNext());
            Console.WriteLine(test2.Current);
            Console.WriteLine(test2.MoveNext());
            Console.WriteLine("Count: " + test2.Count + "\n");

            foreach (int item in test2)
            {
                Console.WriteLine($"foreach test {item}");
            }

            Console.WriteLine("\nindexer test");
            Console.WriteLine(test2[0]);
            Console.WriteLine(test2[1]);
            Console.WriteLine(test2[2]);
            Console.WriteLine(test2[3] + "\n");

            int[] testArray = test2.GetArray();
            for (int i = 0; i < test2.Count; i++)
                Console.WriteLine("Method test: " + testArray[i]);
            Console.ReadKey();

        }
    }
}
