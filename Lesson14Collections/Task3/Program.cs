using System;
using System.Collections.Generic;
using MyDictionary;

namespace Task3
{
    // Код ниже вынесен в отдельный клас, и теперь используется через using MyDictionary
    #region
    /*class MyDictionary<Tkey, Tvalue>
    {
        KeyValuePair<Tkey,Tvalue>[] pairs = new KeyValuePair<Tkey, Tvalue>[0];

        int position = -1;

        // реализация IEnumerable
        public IEnumerator<KeyValuePair<Tkey, Tvalue>> GetEnumerator()
        {
            while (true)
            {
                if (position < pairs.Length - 1)
                {
                    position++;
                    yield return pairs[position];
                }
                else
                {
                    Reset();
                    yield break;
                }
            }
        }

        // IEnumerator
        public object Current
        {
            get
            {
                return pairs[position];
            }
        }
        public bool MoveNext()
        {
            if (position < pairs.Length-1)
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

        // код из задания
        public void AddPair (Tkey key, Tvalue value)
        {
            KeyValuePair<Tkey, Tvalue>[] newPairs = new KeyValuePair<Tkey, Tvalue>[pairs.Length + 1];
            pairs.CopyTo(newPairs, 0);
            newPairs[pairs.Length] = new KeyValuePair<Tkey, Tvalue>(key, value);
            pairs = newPairs;
        }
        public (Tkey, Tvalue) this [int index]
        {
            get
            {
                if (index >= 0 && index < pairs.Length)
                {
                    return (pairs[index].Key, pairs[index].Value);
                }
                else
                {
                    Console.WriteLine("Array out-of-bounds!");
                    return default;
                }
            }
        }
        public int Count
        {
            get { return pairs.Length; }
        }

        // свой код
        public Tkey[] GetKeys()
        {
            Tkey[] keys = new Tkey[pairs.Length];
            for (int i = 0; i < pairs.Length; i++)
            {
                keys[i] = pairs[i].Key;
            }
            return keys;
        }
        public Tvalue[] GetValues()
        {
            Tvalue[] values = new Tvalue[pairs.Length];
            for (int i = 0; i < pairs.Length; i++)
            {
                values[i] = pairs[i].Value;
            }
            return values;
        }
    }*/
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> test = new MyDictionary<int, string>();
            Console.WriteLine("Count : " + test.Count);
            test.AddPair(1, "one");
            test.AddPair(2, "two");
            test.AddPair(3, "three");
            //test.AddPair(4, "four");


            Console.WriteLine("\n" + test.MoveNext());
            Console.WriteLine(test.Current);
            Console.WriteLine(test.MoveNext());
            Console.WriteLine(test.Current);
            Console.WriteLine(test.MoveNext());
            Console.WriteLine(test.Current);
            Console.WriteLine(test.MoveNext() + "\n");
            Console.WriteLine("Count : " + test.Count);

            foreach (KeyValuePair<int,string> item in test)
            {
                Console.WriteLine($"foreach test {item}");
            }

            Console.WriteLine("\nindexer test");
            Console.WriteLine(test[0]);
            Console.WriteLine(test[1]);
            Console.WriteLine(test[2]);
            Console.WriteLine(test[3] + "\n");

            int[] keys = test.GetKeys();
            for (int i = 0; i<keys.Length; i++)
            {
                Console.WriteLine("GetKeys() test: " + keys[i]);
            }

            string[] values = test.GetValues();
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine("GetValues() test: " + values[i]);
            }


            Console.ReadKey();
        }
    }
}
