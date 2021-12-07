using System;

namespace Task3
{
    class Home : ICloneable
    {
        string street;
        int number;
        public Home(string street, int number)
        {
            this.street = street;
            this.number = number;
        }
        public string Street { get { return street; } set { street = value; } }
        public int Number { get { return number; } set { number = value; } }

        public object Clone()
        {
            return new Home(this.street, this.number);
            //retur this; - тоже самое
            //return this.MemberwiseClone(); // значительно быстрее чем через конструктор, не клонирует ассоциации
            //поверхностное копирование;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Home original = new Home("street", 1);
            Home clone = (Home)original.Clone();
            Console.WriteLine(original.Street + " " + original.Number);
            Console.WriteLine(clone.Street + " " + clone.Number);
            clone.Number = 3;
            clone.Street = "new";
            Console.WriteLine(clone.Street + " " + clone.Number);
            Console.WriteLine(original.GetHashCode());
            Console.WriteLine(clone.GetHashCode());
            Console.ReadKey();

        }
    }
}
