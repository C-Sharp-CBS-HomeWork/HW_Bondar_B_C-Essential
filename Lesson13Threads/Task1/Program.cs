using System;
using System.Threading;

namespace Task1
{
    class Chain
    {
        object block = new object();
        private char[] ChainCreator()
        {

            Random rnd = new Random();
            int chainLenght = rnd.Next(3, 10);
            char[] characters = new char[chainLenght];
            return characters;
        }
        private char[] ChainFiller(char[] characters)
        {
            Random rndChar = new Random();
            for (int i = 0; i < characters.Length; i++)
            {
                char character = (char)rndChar.Next('A', 'z' + 1);
                characters[i] = character;
            }
            return characters;
        }
        private void ChainWriter(char[] characters, int column, int row)
        {
            int x = column;
            int y = row; //счетчик строки из CompleteChain(). Если поставить 0, массив не сдвигается,
                         //тк основной метод CC перевызывает данный в каждой итерации, и 0 переписывает
                         //значение строки из СС. Итог - столбец выводится только сверху, хотя курсор идет вниз
            for (int i = 0; i < characters.Length; i++)
            {
                Console.SetCursorPosition(x, y);
                if (i == characters.Length - 1)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(characters[i]);
                    Console.SetCursorPosition(x, ++y);
                }
                else if (i == characters.Length - 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(characters[i]);
                    Console.SetCursorPosition(x, ++y);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine(characters[i]);
                    Console.SetCursorPosition(x, ++y);
                }
            }
        }
        public void CompleteChain(object counter)
        {   
            int column = (int)counter; // column нужно определять в двух методах, здесь и Chainwriter()
                                       // чтоб не слетал столбец
            int row = 0; // основной счетчик строки, отвечает за перемещение всего массива characters
                         // передаем в ChainWriter для вывода столбца на 1 ниже в каждой итерации
            Console.CursorVisible = true;

            char[] characters = ChainCreator();

            for (; ; ) // для бесконечного вывода строки
            {
                for (int i = 0; i <= Console.WindowHeight; i++)
                {
                    ChainFiller(characters);
                    ChainWriter(characters, column, row); // принимает row основного метода(всего массива)
                    Console.SetCursorPosition(column, row++); //переносит строку на 1 вниз
                    Console.WriteLine(" "); //стирает предыдущий символ
                    Console.SetCursorPosition(column, row); //мб не нужно, но так не прыгает курсор
                                                               //до перевызова Chainwriter()
                    Thread.Sleep(300);

                    if (i == Console.WindowHeight - characters.Length) // определяет нижнюю границу печати, по сути - по высоте окна;
                    {
                        Console.Clear();
                        row = 0; // возвращает каретку в начало столбца(0 строка);
                        break; // заканчивает текущий цикл
                    }
                }
            }

        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 30);
            //new Chain().CompleteChain(7);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                new Thread(new Chain().CompleteChain).Start(i);
            }
            Console.ReadKey();
        }
    }
}
