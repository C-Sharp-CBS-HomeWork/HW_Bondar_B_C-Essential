using System;

namespace Task3
{
    public delegate int ForMethod();
    public delegate double Functional(ForMethod[] item);
    class Program
    {
        public static int RandomNumber()
        {
            Random number = new Random();
            int x = number.Next(0, 100);
            return x;
        }
        static void Main(string[] args)
        {
            ForMethod item1 = new ForMethod(RandomNumber);
            ForMethod item2 = new ForMethod(RandomNumber);
            ForMethod item3 = new ForMethod(RandomNumber);

            ForMethod[] items = { item1, item2, item3 };

            Functional mainDelegate = delegate (ForMethod[] item) 
            {
                int x = 0;
                for (int i = 0; i < item.Length; i++)
                {
                    x += item[i].Invoke();
                }
                double result = (double)x / item.Length;
                return result;
            };
            double resultNum = mainDelegate(items);
            Console.WriteLine(resultNum);
            Console.ReadKey();
        }
    }
}
