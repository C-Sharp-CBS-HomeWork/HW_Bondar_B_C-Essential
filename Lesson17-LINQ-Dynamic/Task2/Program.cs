using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Program
    {
        class Car
        {
            public string CarBrand { get; set; }
            public string CarModel { get; set; }
            public string ProdYear { get; set; }
            public string Color { get; set; }
        }
        class Customer
        {
            public string CarModel { get; set; }
            public string CustomerName { get; set; }
            public string PhoneNumber { get; set; }

        }
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Car{ CarBrand = "Mercedes", CarModel = "G500", Color = "Black", ProdYear = "2020" },
                new Car{ CarBrand = "Audi", CarModel = "A8", Color = "Silver", ProdYear = "2021" },
                new Car {CarBrand = "BMW", CarModel = "M5", Color = "Blue", ProdYear = "2019"}
            };
            var customers = new List<Customer>
            { 
                new Customer {CarModel = "G500", CustomerName = "Trevor", PhoneNumber = "7777777"},
                new Customer {CarModel = "M5", CustomerName = "Franklin", PhoneNumber = "3333333" },
                new Customer {CarModel = "A8", CustomerName = "Michael", PhoneNumber = "1111111" } 
            };
            var query = from cust in customers
                        join car in cars
                        on cust.CarModel equals car.CarModel
                        //where car.CarModel == "G500" // опциональная строка поиска по конкретному параметру
                        select new
                        {
                            cust.CarModel,
                            cust.CustomerName,
                            cust.PhoneNumber,
                            car.CarBrand,
                            car.Color,
                            car.ProdYear
                        };
            foreach (var item in query)
            {
                Console.WriteLine($"{item.CarModel}, {item.CustomerName}, {item.PhoneNumber}, {item.CarBrand}, " +
                    $"{item.Color}, {item.ProdYear}");
            }
            Console.ReadKey(); 
        }
    }
}
