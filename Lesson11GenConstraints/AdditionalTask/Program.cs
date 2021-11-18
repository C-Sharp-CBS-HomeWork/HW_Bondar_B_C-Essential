using System;
using System.Collections;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList test = new ArrayList();
            test.Add(1);
            test.Add("one");
            int x;
            for (int i = 0; i < test.Count; i++)
            {
                x = (int)test[i];
            }
            // Т.к. ArrayList является гетерогенной коллекцией, возникают ошибки выполения при приведении типов,
            // поскольку они храняться в форме object и не известно елементы каких типов могут находится в данной
            // коллекции. При компиляции данную ошибку невозможно отследить. Работа с такими коллекциями не очевидна.
            Console.ReadKey();
        }
    }
}
