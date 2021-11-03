using System;

namespace Task4
{
    class Invoice
    {
        readonly int account;
        readonly string customer, provider;
        string article;
        int quantity;

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public void Payment(string article, int quantity)
        {
            decimal summ = 0;
            switch(article)
            {
                case "a":
                    {
                        const decimal PRICE_A = 125.12M;
                        summ = quantity * PRICE_A;
                        break;
                    }
                case "b":
                    {
                        const decimal PRICE_B = 37;
                        summ = quantity * PRICE_B;
                        break;
                    }
                case "c":
                    {
                        const decimal PRICE_C = 70;
                        summ = quantity * PRICE_C;
                        break;
                    }
                default:
                    Console.WriteLine("Артикул не найден");
                    break;
            }
            const decimal VAT = 0.2M;
            decimal summIncVAT = summ + summ * VAT;
            Console.WriteLine($"Сумма к оплате (без НДС): {summ} грн.");
            Console.WriteLine($"Сумма к оплате (включая НДС) {summIncVAT} грн.");
        }

    }
}
