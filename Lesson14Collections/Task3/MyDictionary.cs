

namespace MyDictionary
{
    using System;
    using System.Collections.Generic;
    class MyDictionary <Tkey, Tvalue>
    {
        KeyValuePair<Tkey, Tvalue>[] array = new KeyValuePair<Tkey, Tvalue>[0];

        int position = -1;

        // IEnumerable
        public IEnumerator<KeyValuePair<Tkey,Tvalue>>GetEnumerator()
        {
            while (true)
            {
                if (position < array.Length - 1)
                {
                    position++;
                    yield return array[position];
                }
                else
                {
                    Reset();
                    yield break;
                }
            }
        }
        
        //IEnumerator
        public object Current
        {
            get { return array[position]; }
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

        //user methods
        public void AddPair(Tkey key, Tvalue value)
        {
            KeyValuePair<Tkey, Tvalue>[] newArray = new KeyValuePair<Tkey, Tvalue>[array.Length + 1];
            array.CopyTo(newArray, 0);
            newArray[array.Length] = new KeyValuePair<Tkey, Tvalue>(key, value);
            array = newArray;
        }

        public (Tkey, Tvalue) this [int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                {
                    return (array[index].Key, array[index].Value);
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
            get { return array.Length; }
        }

        public Tkey[] GetKeys()
        {
            Tkey[] keys = new Tkey[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                keys[i] = array[i].Key;
            }
            return keys;
        }

        public Tvalue[] GetValues()
        {
            Tvalue[] values = new Tvalue[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                values[i] = array[i].Value;
            }
            return values;
        }


    }
}
