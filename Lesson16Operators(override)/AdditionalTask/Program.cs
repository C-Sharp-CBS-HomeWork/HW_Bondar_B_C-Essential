using System;

namespace AdditionalTask
{
    class Program
    {
        struct Point
        {
            int x, y, z;
            public Point(int x, int y, int z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
            public int X { get { return x; } }
            public int Y { get { return y; } }
            public int Z { get { return z; } }

            public static Point operator +(Point a, Point b)
            {
                return new Point(a.x + b.x, a.y + b.y, a.z + b.z);
            }
        }
        static void Main(string[] args)
        {
            Point A = new Point(1, 2, 3);
            Point B = new Point(2, 1, 3);
            Point C = A + B;
            Console.WriteLine($"X: {C.X}, Y: {C.Y}, Z: {C.Z}");
            Console.ReadKey();
        }
    }
}
