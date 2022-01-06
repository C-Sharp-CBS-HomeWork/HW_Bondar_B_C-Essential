using System;

namespace Task3
{
    class MyMatrix
    {
        int[,] matrix = null;
        public MyMatrix(int row, int col)
        {
            matrix = new int [Math.Abs(row), Math.Abs(col)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Fill();
                }
            }
        }

        public int Fill()
        {
            Random random = new Random();
            int element = random.Next(10, 95);
            return element;
        }

        public void ChangeSize(int row, int col)
        {
            if (row <=0 || col <=0)
            {
                Console.WriteLine("Matrix size cant be lower or equal to 0!");
                return;
            }

            int[,] newMatrix = new int[row, col];
            for (int i = 0; i < newMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < newMatrix.GetLength(1); j++)
                {
                    if (i >= matrix.GetLength(0) || j >= matrix.GetLength(1))
                    {
                        newMatrix[i, j] = 99;
                    }
                    else
                    {
                        newMatrix[i, j] = matrix[i, j];
                    }
                }
            }
            matrix = newMatrix;
        }

        public void ShowMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
