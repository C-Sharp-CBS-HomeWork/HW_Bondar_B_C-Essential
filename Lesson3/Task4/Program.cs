using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать! Введите ваш ключ:");
            string key = Console.ReadLine();
            switch (key)
            {
                case "pro1":
                    {
                        Console.WriteLine("Поздравляю! Вам доступна версия Про!");
                        DocumentWorker test = new ProDocumentWorker();
                        test.OpenDocument();
                        test.EditDocument();
                        test.SaveDocument();
                        break;
                    }
                case "expert2":
                    {
                        Console.WriteLine("Поздравляю! Вам доступна версия Эксперт!");
                        DocumentWorker test = new ExpertDocumentWorker();
                        test.OpenDocument();
                        test.EditDocument();
                        test.SaveDocument();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Вам доступна версия базовая версия программы.");
                        DocumentWorker test = new DocumentWorker();
                        test.OpenDocument();
                        test.EditDocument();
                        test.SaveDocument();
                        break;
                    }
            }
            Console.ReadKey();
        }

    }
}
