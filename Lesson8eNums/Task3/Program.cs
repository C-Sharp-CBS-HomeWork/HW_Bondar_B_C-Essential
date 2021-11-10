using System;

namespace Task3
{
    enum Post
    {
        junior = 160,
        middle = 140,
        senior = 120,
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the employee's post: ");
            object inputWorker = Enum.Parse(typeof(Post),Console.ReadLine().ToLower());
            Post worker = (Post)inputWorker;
            Console.Write("Enter hours worked: ");
            int hours = Int32.Parse(Console.ReadLine());
            bool bonus = Accountant.AskForBonus(worker, hours);
            if (bonus)
                Console.WriteLine("Bonus payment avaliable!");
            else
                Console.WriteLine("Bonus not avaliable");
            Console.ReadKey();
        }
    }
}
