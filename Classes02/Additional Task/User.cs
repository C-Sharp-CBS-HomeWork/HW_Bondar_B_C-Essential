using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    class User
    {
        string login, name, surname;
        int age;
        readonly string formData;

        public User(string login, string name, string surname, int age, string formData)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.formData = formData;
        }

        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public void UserData()
        {
            Console.WriteLine($"Логин: {login}");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Фамилия: {surname}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Дата создания: {formData}");
        }
    }
}
