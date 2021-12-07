using System;

namespace Task2
{
    class Block
    {
        int sideA, sideB, sideC, sideD;
        public Block (int a, int b, int c, int d)
        {
            sideA = a;
            sideB = b;
            sideC = c;
            sideD = d;
        }
        public override bool Equals(Object obj)
        {
            if(obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            Block block = (Block)obj;
            return (sideA == block.sideA) && (sideB == block.sideB) && (sideC == block.sideC)
                && (sideD == block.sideD);
        }

        public override int GetHashCode()
        {
            return 2 * sideA ^ 8 * sideD ^ 22 * sideC ^ 15*sideB;
        }
        public override string ToString()
        {
            return $"Side A: {sideA}, Side B: {sideB}, Side C: {sideC}, Side D: {sideD}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Block A = new Block(2, 7, 8, 3);
            Console.WriteLine(A.GetHashCode());
            Console.WriteLine(A.ToString());
            Console.ReadKey();
        }
    }
}
