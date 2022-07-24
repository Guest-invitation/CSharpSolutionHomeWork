// Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

namespace GB.Task62
{
    class Program
    {
        static void Main(string[] asgs)
        {
            int[,] matrix = new int[4, 4];
            FillMatrix(matrix);
            Console.WriteLine("Сгенерирован случайный массив размера 4х4: ");
            PrintMatrix(matrix);
            GetSpiralSort(matrix);
            Console.WriteLine();
            PrintMatrix(matrix);
        }

        public static int[,] FillMatrix(int[,] matrixF)
        {
            for (int i = 0; i < matrixF.GetLength(0); i++)
            {
                for (int j = 0; j < matrixF.GetLength(1); j++)
                {
                    matrixF[i, j] = new Random().Next(1, 100);
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
                    Console.WriteLine(matrixP[i, j] + " | ");
                }
                Console.WriteLine();
            }
            return matrixP;
        }

        public static int [,] GetSpiralSort(int [,] matrixSS)
        {
            
        }
    }
}