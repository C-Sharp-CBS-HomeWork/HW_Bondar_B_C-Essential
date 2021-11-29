using System;
using System.Threading;

namespace AdditionalTask
{

    class Program
    {
        static public void NewThread()
        {
            Console.WriteLine("Current thread: {0}", Thread.CurrentThread.GetHashCode());
            Thread.Sleep(1000);
            ThreadStart newOne = new ThreadStart(NewThread);
            Thread test = new Thread(newOne);
            test.Start();
        }
        static void Main(string[] args)
        {
            NewThread();
            Console.ReadKey();
        }
    }
}
