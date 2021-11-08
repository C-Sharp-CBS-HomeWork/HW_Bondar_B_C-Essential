using System;

namespace AdditionalTask
{
    struct Notebook
    {
        string model, manufacturer;
        decimal price;
        public Notebook(string model, string manufacturer, decimal price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }
        public void Show()
        {
            Console.WriteLine(model);
            Console.WriteLine(manufacturer);
            Console.WriteLine(price);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Notebook book1 = new Notebook("Model1", "Manufacturer1", 21.15M);
            book1.Show();
            Console.ReadKey();
        }
    }
}
