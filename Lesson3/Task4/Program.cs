using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать! Введите ваш ключ:");
            string key = Console.ReadLine();
            DocumentWorker test = null;
            switch (key)
            {
                case "pro1":
                    {
                        Console.WriteLine("Поздравляю! Вам доступна версия Про!");
                        test = new ProDocumentWorker();
                        break;
                    }
                case "expert2":
                    {
                        Console.WriteLine("Поздравляю! Вам доступна версия Эксперт!");
                        test = new ExpertDocumentWorker();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Вам доступна версия базовая версия программы.");
                        test = new DocumentWorker();
                        break;
                    }
            }
            test.OpenDocument();
            test.EditDocument();
            test.SaveDocument();
            Console.ReadKey();
        }

    }
}
