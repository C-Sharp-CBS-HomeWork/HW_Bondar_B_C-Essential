using System;
using System.Collections;


namespace Task2
{
    public class MyList<T> : IEnumerable, IEnumerator
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
            if(position < array.Length - 1)
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
        public IEnumerator GetEnumerator()
        {
            return this;
        }
        // методы из задания
        public void Add(T element)
        {
            T[] newArray = new T[array.Length + 1];
            array.CopyTo(newArray, 0);
            newArray[array.Length] = element;
            array = newArray;
        }
        public T this [int index]
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
        public int Capacity
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
            MyList<int> test = new MyList<int>();
            Console.WriteLine("Capacity: " + test.Capacity);
            test.Add(1);
            test.Add(2);
            test.Add(3);


            Console.WriteLine("\n" + test.MoveNext());
            Console.WriteLine(test.Current);
            Console.WriteLine(test.MoveNext());
            Console.WriteLine(test.Current);
            Console.WriteLine(test.MoveNext());
            Console.WriteLine(test.Current);
            Console.WriteLine(test.MoveNext() + "\n");

            Console.WriteLine("Capacity: " + test.Capacity + "\n");

            foreach (int item in test)
            {
                Console.WriteLine($"foreach test {item}");
            }

            Console.WriteLine("\nindexer test");
            Console.WriteLine(test[0]);
            Console.WriteLine(test[1]);
            Console.WriteLine(test[2]);
            Console.WriteLine(test[3]);


            Console.ReadKey();
            
        }
    }
}
