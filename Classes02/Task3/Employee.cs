using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Employee
    {
        string name, surname;
        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        string Name
        {
            get
            {
                return name;
            }
        }
        string Surname
        {
            get
            {
                return surname;
            }
        }
        public void Payment(int expirience, string rank)
        {
            decimal payment = 0;
            switch (rank)
            {
                case "junior":
                    {
                        const decimal SALARY = 1000;
                        if (expirience < 2)
                        {
                            const decimal EXP_BONUS = 1.2M;
                            payment = SALARY * EXP_BONUS;
                        }
                        else if (expirience >= 2 && expirience < 5)
                        {
                            const decimal EXP_BONUS = 1.3M;
                            payment = SALARY * EXP_BONUS;
                        }
                        else
                        {
                            const decimal EXP_BONUS = 1.5M;
                            payment = SALARY * EXP_BONUS;
                        }
                        break;
                    }
                case "middle":
                    {
                        const decimal SALARY = 3000;
                        if (expirience < 3)
                        {
                            const decimal EXP_BONUS = 1.2M;
                            payment = SALARY * EXP_BONUS;
                        }
                        else if (expirience >= 3 && expirience < 5)
                        {
                            const decimal EXP_BONUS = 1.3M;
                            payment = SALARY * EXP_BONUS;
                        }
                        else
                        {
                            const decimal EXP_BONUS = 1.5M;
                            payment = SALARY * EXP_BONUS;
                        }
                        break;
                    }
                case "senior":
                    {
                        const decimal SALARY = 5000;
                        if (expirience < 3)
                        {
                            const decimal EXP_BONUS = 1.2M;
                            payment = SALARY * EXP_BONUS;
                        }
                        else if (expirience >= 3 && expirience < 5)
                        {
                            const decimal EXP_BONUS = 1.3M;
                            payment = SALARY * EXP_BONUS;
                        }
                        else
                        {
                            const decimal EXP_BONUS = 1.5M;
                            payment = SALARY * EXP_BONUS;
                        }
                        break;
                    }
                default:
                    Console.WriteLine("Неверно указана должность");
                    break;

            }
            const decimal TAX = 0.2M;
            decimal taxPayment = payment * TAX;
            Console.WriteLine($"Должность: {rank}");
            Console.WriteLine($"Оклад: {payment} USD");
            Console.WriteLine($"Сумма налога к оплате: {taxPayment} USD");
        }
        public void NameSurname()
        {
            Console.WriteLine(Name + " " + Surname);
        }
        
    }
}
