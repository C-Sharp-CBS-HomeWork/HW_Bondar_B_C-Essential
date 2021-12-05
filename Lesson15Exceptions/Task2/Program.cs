using System;
using System.Linq;
namespace Task2
{
    struct Worker
    {
        string surname, post;
        int yearStarted;
        public Worker(string surname, string post, int year)
        {
            this.surname = surname;
            this.post = post;
            yearStarted = year;
        }

        public string Surname
        {
            get
            {
                return surname;
            }
        }
        public string Post
        {
            get
            {
                return post;
            }
        }
        public int YearStarted
        {
            get { return yearStarted; }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[5];
            string name, post;
            int year;
            for (int i = 0; i < workers.Length; i++)
            {
                Console.Write("Enter name: ");
                name = Console.ReadLine();
                Console.Write("Enter post: ");
                post = Console.ReadLine();
                while (true)
                {
                    Console.Write("Enter year of employment: ");
                    try
                    {
                        year = Int32.Parse(Console.ReadLine());
                        workers[i] = new Worker(name, post, year);
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Wrong year format!");
                    }
                }
            }
            Array.Sort(workers, new Comparison<Worker>((a,b) => a.Surname.CompareTo(b.Surname))); // сортирует по
            // алфавиту строки в структуре
            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine($"Name: {workers[i].Surname} / Post: {workers[i].Post} /" +
                    $" Year of employment: {workers[i].YearStarted}");
            }
            /*foreach (var item in workers.OrderBy(worker => worker.Surname)) // сортировка с использованием Linq
            {
                Console.WriteLine(item.Surname + item.Post + item.YearStarted);
            }*/

            //years check
            while (true)
            {
                Console.Write("Enter years worked: ");
                try
                {
                    int expirience = Int32.Parse(Console.ReadLine());
                    for (int i = 0; i < workers.Length; i++)
                    {
                        if(expirience < DateTime.Now.Year - workers[i].YearStarted)
                        {
                            Console.WriteLine(workers[i].Surname);
                        }
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Wrong years format! Please, try again");
                }
            }
            
            Console.ReadKey();
        }
    }
}
