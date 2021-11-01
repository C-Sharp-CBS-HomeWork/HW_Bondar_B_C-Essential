using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Vehicle
    {
        protected decimal price;
        protected string speed, productionYear;
        public void Stats()
        {
            Console.WriteLine(price);
            Console.WriteLine(speed);
            Console.WriteLine(productionYear);
        }
    }
    class Car : Vehicle
    {
        public Car()
        {
            price = 120000; //$
            speed = "250 km/h";
            productionYear = "2021";
        }
        public void Stats()
        {
            Console.WriteLine($"Стоимость автомобиля: {price:C}");
            Console.WriteLine($"Максимальная скорость: {speed}");
            Console.WriteLine($"Год выпуска: {productionYear} год");
        }
    }
    class Plane : Vehicle
    {
        string flyHeight = "11 000 m", seats = "180";

        public Plane ()
        {
            price = 60000000; //$
            speed = "800 km/h";
            productionYear = "2019";
        }
        public void Stats()
        {
            Console.WriteLine($"Стоимость воздушного судна: {price:C}");
            Console.WriteLine($"Крейсерская скорость передвижения: {speed}");
            Console.WriteLine($"Год выпуска: {productionYear} год");
            Console.WriteLine($"Максимальная высота полета: {flyHeight}");
            Console.WriteLine($"Количество пассажиров: {seats} чел.");
        }

    }
    class Ship : Vehicle
    {
        string passangers = "3700", homeport = "Генуя";
        public Ship()
        {
            price = 570000000; //$
            speed = "36 km/h";
            productionYear = "2006";
        }
        public void Stats()
        {
            Console.WriteLine($"Стоимость судна: {price:C}");
            Console.WriteLine($"Скорость передвижения: {speed}");
            Console.WriteLine($"Год выпуска: {productionYear} год");
            Console.WriteLine($"Места для пассажиров: {passangers} чел.");
            Console.WriteLine($"Порт приписки: {homeport}");

        }
    }
}
