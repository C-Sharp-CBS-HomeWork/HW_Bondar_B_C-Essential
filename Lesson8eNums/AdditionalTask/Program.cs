using System;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthday: ");
            DateTime birthdayUser = DateTime.Parse(Console.ReadLine());
            DateTime birthdayDate = new DateTime(DateTime.Today.Year, birthdayUser.Month, birthdayUser.Day);
            DateTime today = DateTime.Now;
            TimeSpan timeLeft2 = birthdayDate.AddYears(1) - today;
            int age = birthdayDate.AddYears(1).Year - birthdayUser.Year;
            Console.WriteLine($"До дня рождения осталость: {timeLeft2.Days} дней!");
            Console.WriteLine($"Вам исполнится: {age} лет!");
            Console.ReadKey();
        }
    }
}
