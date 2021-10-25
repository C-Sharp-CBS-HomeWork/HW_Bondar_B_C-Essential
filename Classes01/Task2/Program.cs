using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону 1:");
            variable1:
            string input1 = Console.ReadLine();
            double side1;
            bool result1 = double.TryParse(input1, out side1);
            if (!result1 || side1 <= 0)
            {
                Console.WriteLine("Недопустимое значение. Повторите ввод:");
                goto variable1;
            }

            Console.WriteLine("Введите сторону 2:");
        variable2:
            string input2 = Console.ReadLine();
            double side2;
            bool result2 = double.TryParse(input2, out side2);
            if (!result2 || side2 <= 0)
            {
                Console.WriteLine("Недопустимое значение. Повторите ввод:");
                goto variable2;
            }

            Rectangle Figure = new Rectangle(side1, side2);
            Figure.AreaCalculator();
            Figure.PerimeterCalculator();

            Console.WriteLine($"Площадь прямоугольника равна:{Figure.Area} кв. ед.");
            Console.WriteLine($"Периметр прямоугольника равен:{Figure.Perimeter} ед.");

            Console.ReadKey();
        }
    }

    class Rectangle
    {
        double side1, side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            double area = side1 * side2;
            return area;
        }

        public double PerimeterCalculator()
        {
            double perimeter = side1 * 2 + side2 * 2;
            return perimeter;
        }

        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }

        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }
    }
}
