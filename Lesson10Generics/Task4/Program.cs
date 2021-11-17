using System;

namespace Task4
{
    class MyList<T>
    {
        T[] list = null;
        int existCounter = 0;
        public MyList(int capacity)
        {
            list = new T[capacity];
        }
        public void AddItem(T item)
        {
            if (existCounter >= list.Length)
            {
                Console.WriteLine($"{item} cant be added! Array is full!");
            }
            else
            {
                list[existCounter] = item;
                existCounter++;
            }
        }
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < list.Length)
                    return list[index];
                else
                    Console.WriteLine("Array out-of-bounds!");
                return default(T);
            }
        }
        public int Count
        {
            get
            {
                return existCounter;
            }
        }
    }
    // НОВЫЙ МЕТОД!!!
    static class GetArrayClass
    {
        public static T[] GetArray<T>(this MyList<T> array)
        {
            T[] newarray = new T [array.Count];
            for (int i = 0; i < array.Count; i++)
            {
                newarray[i] = array[i];
            }
            return newarray;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> test = new MyList<string>(5);
            test.AddItem("1");
            test.AddItem("2");
            test.AddItem("3");
            test.AddItem("4");
            test.AddItem("5");

            Console.WriteLine($"Total number of elements: {test.Count}");

            // ПРОВЕРКА МЕТОДА !!!
            Console.WriteLine("Method test\n" + new string('-',30));

            string[] methodTest = test.GetArray();
            for (int i = 0; i < methodTest.Length; i++)
            {
                Console.WriteLine(methodTest[i]);
            }
            Console.ReadKey();
        }
    }
}
