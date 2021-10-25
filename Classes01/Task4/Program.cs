using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point exA = new Point(3, 7, "A");
            Point exB = new Point(5, -2, "B");
            Point exC = new Point(-8, 2, "C");
            Point exD = new Point(4, 5, "D");
            Point exE = new Point(6, 3, "E");

            Figure triangle = new Figure(exA, exB, exC);
            double perim = triangle.Perimeter;
            // проверочная часть
            {
                double a = triangle.LengthSide(exA, exB);
                double b = triangle.LengthSide(exB, exC);
                double c = triangle.LengthSide(exC, exA);
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(perim);
            }
            Console.WriteLine($"Название фигуры: {triangle.Name}");
            Console.WriteLine($"Периметр фигуры равен: {triangle.Perimeter} ед. измерения \n");

            Figure square = new Figure(exA, exB, exC, exD);
            Console.WriteLine($"Название фигуры: {square.Name}");
            Console.WriteLine($"Периметр фигуры равен: {square.Perimeter} ед. измерения \n");

            Figure pentagon = new Figure(exA, exB, exC, exD, exE);
            Console.WriteLine($"Название фигуры: {pentagon.Name}");
            Console.WriteLine($"Периметр фигуры равен: {pentagon.Perimeter} ед. измерения");

            Console.ReadKey();
        }
    }
}
