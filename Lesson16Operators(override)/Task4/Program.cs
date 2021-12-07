using System;

namespace Task4
{
    class Date
    {
        DateTime date;
        public Date(DateTime date)
        {
            this.date = date;
        }
        public DateTime ContainDate { get { return date; } set { date = value; } }
        static public int operator -(Date a, Date b)
        {
            TimeSpan result = a.ContainDate.Subtract(b.ContainDate);
            return result.Days;
        }
        static public Date operator +(Date a, int days)
        {
            DateTime result = a.ContainDate.AddDays(days);
            return new Date(result);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DateTime birth = new DateTime(1998, 01, 19);
            DateTime now = DateTime.Now;

            Date a = new Date(now);
            Date b = new Date(birth);
            int difference = a - b;
            Console.WriteLine($"Difference in days: {difference}");
            Date c = a + 30;
            Console.WriteLine($"Days addition result: {c.ContainDate}");
            Console.ReadKey();
        }
    }
}
