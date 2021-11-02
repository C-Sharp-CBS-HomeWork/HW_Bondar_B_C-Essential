using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayable test = new Player();
            test.Play();
            test.Pause();
            test.Stop();

            Console.WriteLine(new string('-', 30));

            IRecordable test2 = new Player();
            test2.Record();
            test2.Pause();
            test2.Stop();

            Console.WriteLine(new string('-', 30));

            Player test3 = new Player();
            test3.Play();
            test3.Record();
            ((IPlayable)test3).Pause(); // явное применение
            ((IPlayable)test3).Stop();
            ((IRecordable)test3).Pause();
            ((IRecordable)test3).Stop();

            Console.ReadKey();
        }
    }
}
