using System;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress Example = new Adress();
            Example.Index = "NW1 6XE";
            Example.Country = "United Kingdom";
            Example.City = "London";
            Example.Street = "Baker Street";
            Example.House = "221b";
            Example.Apartment = "7";
            
            Console.WriteLine(Example.Index);
            Console.WriteLine(Example.Country);
            Console.WriteLine(Example.City);
            Console.WriteLine(Example.Street);
            Console.WriteLine(Example.House);
            Console.WriteLine(Example.Apartment);

            Console.ReadKey();
        }
    }

    class Adress
    {
        string index, country, city, street, house, apartment;
        public string Index
        {
            get
            {
                return index;
            }
            set
            {
                index = Convert.ToString(value);
            }
        }

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }

        public string House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }

        public string Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
        }

    }
}
