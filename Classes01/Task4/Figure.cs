using System;

namespace Task4
{
    class Figure
    {
        string name;
        double perimeter;
        Point[] points;

        public Figure (Point A, Point B, Point C)
        {
            name = A.Name + B.Name + C.Name;
            points = new Point[3] { A, B, C };
        }

        public Figure (Point A, Point B, Point C, Point D)
        {
            name = A.Name + B.Name + C.Name + D.Name;
            points = new Point[4] { A, B, C, D };
        }

        public Figure (Point A, Point B, Point C, Point D, Point E)
        {
            name = A.Name + B.Name + C.Name + D.Name + E.Name;
            points = new Point[5] { A, B, C, D, E };
        }
        public double LengthSide(Point A, Point B)
        {
            double differenceX = B.X - A.X;
            double differenceY = B.Y - A.Y;
            double powX = Math.Pow(differenceX, 2);
            double powY = Math.Pow(differenceY, 2);
            double lenght = Math.Sqrt(powX + powY);

            return lenght;
        }

        public double Perimeter
        {
            get
            {
                double perimeter = 0;
                for (int i = 1; i < points.Length; i++)
                {
                    perimeter += LengthSide(points[i-1], points[i]);
                }
                perimeter += LengthSide(points[0], points[points.Length-1]);
                return perimeter;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}
