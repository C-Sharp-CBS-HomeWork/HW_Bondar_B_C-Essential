using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee worker1 = new Employee("Ivan", "Ivanov");
            Employee worker2 = new Employee("Petr", "Petrov");
            Employee worker3 = new Employee("James", "Bond");

            worker1.NameSurname();
            worker1.Payment(1,"junior");

            worker2.NameSurname();
            worker2.Payment(2, "middle");

            worker3.NameSurname();
            worker3.Payment(10, "senior");

            Console.ReadKey();
        }
    }
}
