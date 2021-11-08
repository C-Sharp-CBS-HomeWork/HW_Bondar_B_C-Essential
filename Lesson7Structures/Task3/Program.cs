using System;

namespace Task3
{
    struct MyStruct
    {
        public string change;
    }
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Изменено";
        }
        static void StructTaker(ref MyStruct myStruct)
        {
            myStruct.change = "ИзмененоСтруктура";
        }
        static void Main(string[] args)
        {
            MyClass testClass = new();
            testClass.change = "Не изменено";
            Console.WriteLine(testClass.change);
            ClassTaker(testClass);
            Console.WriteLine(testClass.change);

            MyStruct testStruct;
            testStruct.change = "не изменено, структура";
            Console.WriteLine(testStruct.change);
            StructTaker(ref testStruct);
            Console.WriteLine(testStruct.change);

            // создание экземпляра структурного типа возможно без вызова конструктора по-умолчанию.
            // стуктуры передаются не по ссылке, а по значению. для работы метода StructTaker необходимо использовать 
            //ключевое слово ref.
            Console.ReadKey();
        }
    }
}
