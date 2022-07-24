// Задайте две матрицы. Напишите программу, которая выведет матрицу 
// произведения элементов двух предыдущих матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

namespace GB.Task58
{
    class Program
    {
        static void Main(string[] asgs)
        {
            int[,] matrixFirst = new int[4, 4];
            int[,] matrixSecond = new int[4, 4];
            FillMatrix(matrixFirst);
            FillMatrix(matrixSecond);
            Console.WriteLine("Сгенерирована первая матрица размера 4х4: ");
            PrintMatrix(matrixFirst);
            Console.WriteLine("Сгенерирована вторая матрица размера 4х4: ");
            PrintMatrix(matrixSecond);
            int [,] matrixProduct = GetProductMatrix(matrixFirst, matrixSecond);
            Console.WriteLine();
            PrintMatrix(matrixProduct);
        }

        public static int[,] FillMatrix(int[,] matrixF)
        {
            for (int i = 0; i < matrixF.GetLength(0); i++)
            {
                for (int j = 0; j < matrixF.GetLength(1); j++)
                {
                    matrixF[i, j] = new Random().Next(1, 10);
                }
            }
            return matrixF;
        }

        public static int[,] PrintMatrix(int[,] matrixP)
        {
            for (int i = 0; i < matrixP.GetLength(0); i++)
            {
                for (int j = 0; j < matrixP.GetLength(1); j++)
                {
                    Console.Write(matrixP[i, j] + " | ");
                }
                Console.WriteLine();
            }
            return matrixP;
        }

        public static int[,] GetProductMatrix(int[,] matrix1, int [,] matrix2)
        {
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[i,j] = matrix1[i,j] * matrix2[i,j];
                }
            }
            return matrix1;
        }
    }
}