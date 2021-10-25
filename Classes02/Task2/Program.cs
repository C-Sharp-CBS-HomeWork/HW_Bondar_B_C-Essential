using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal usdRate = 26.45M, eurRate = 30.30M, rubRate = 0.35M;
            Convertor test = new Convertor(usdRate, eurRate, rubRate);

        value:
            Console.WriteLine("Введите сумму:");
            decimal value;
            {
                bool input = decimal.TryParse(Console.ReadLine(), out value);
                if (!input)
                {
                    Console.WriteLine("Значение неверно");
                    goto value;
                }
            }
            currency:
            Console.WriteLine("Укажите базовую валюту (uah, usd, eur, rub):");
                string baseCurrency = Console.ReadLine();
                if (baseCurrency == "uah")
                {
                    Console.WriteLine("Укажите валюту конвертирования (usd, eur, rub):");
                    string quoteCurrency = Console.ReadLine();
                    decimal result = test.ConvertTo(quoteCurrency, value);
                    Console.WriteLine($"Сумма в валюте конвертации равна: {result}");
                }
                else if (baseCurrency == "usd")
                {
                    decimal result = test.ConvertFrom(baseCurrency, value);
                    Console.WriteLine($"За {value} USD вы получите: {result} UAH.");
                }
                else if (baseCurrency == "eur")
                {
                    decimal result = test.ConvertFrom(baseCurrency, value);
                    Console.WriteLine($"За {value} EUR вы получите: {result} UAH.");
                }
                else if (baseCurrency == "rub")
                {
                    decimal result = test.ConvertFrom(baseCurrency, value);
                    Console.WriteLine($"За {value} RUB вы получите: {result} UAH.");
                }
                else
                {
                    Console.WriteLine("Вы указали неверное значение");
                goto currency;
                }
            Console.ReadKey();
        }
    }
}
