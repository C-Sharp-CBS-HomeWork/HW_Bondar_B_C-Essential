using System;

namespace Additional_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime creation = DateTime.Now;
            string formData = creation.ToString("d");

            User testUser = new User("login21", "Тест", "Пользователь", 21, formData);
            testUser.UserData();

            Console.WriteLine("\nПроверка\n");

            testUser.Login = "newLogin";
            testUser.Name = "Chenged";
            testUser.Surname = "Example";
            testUser.Age = 22;

            testUser.UserData();


            Console.ReadKey();
        }
    }
}
