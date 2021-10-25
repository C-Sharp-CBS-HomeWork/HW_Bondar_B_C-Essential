namespace Task2
{
    class Convertor
    {
        decimal usd, eur, rub;
        public Convertor(decimal usd, decimal eur, decimal rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public decimal ConvertTo(string currency, decimal ammount)
        {
            if (currency == "usd")
            {
                return ammount / usd;
            }
            if (currency == "eur")
            {
                return ammount / eur;
            }
            if (currency == "rub")
            {
                return ammount / rub;
            }
            else
            {
                return 0;
            }
        }

        public decimal ConvertFrom(string currency, decimal ammount)
        {
            if (currency == "usd")
            {
                return ammount * usd;
            }
            if (currency == "eur")
            {
                return ammount * eur;
            }
            if (currency == "rub")
            {
                return ammount * rub;
            }
            else
            {
                return 0;
            }
        }
    }
}
