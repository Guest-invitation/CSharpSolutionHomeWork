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
            Console.WriteLine();
            int[] array = GetOneLineMatrix(matrix);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " | ");
            }
            Console.WriteLine();
            int[] arraySort = GetArraySort(array);
            Console.WriteLine();
            for (int i = 0; i < arraySort.Length; i++)
            {
                Console.Write(arraySort[i] + " | ");
            }
            Console.WriteLine();
            int[,] matrixNew = new int[matrix.GetLength(0), matrix.GetLength(1)];
            matrixNew = GetSpiralSort(matrix, arraySort);
            Console.WriteLine();
            Console.WriteLine("Спиральное заполнение матрицы!");
            PrintMatrix(matrixNew);
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
                    Console.Write(matrixP[i, j] + " | ");
                }
                Console.WriteLine();
            }
            return matrixP;
        }
        public static int[] GetOneLineMatrix(int[,] matrix)
        {
            int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
            int index = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    array[index] = matrix[i, j];
                    index++;
                }
            }
            return array;
        }
        public static int[] GetArraySort(int[] arrayS)
        {
            for (int i = 0; i < arrayS.Length; i++)
            {
                for (int j = 0; j < arrayS.Length - 1; j++)
                {
                    if (arrayS[j] > arrayS[j + 1])
                    {
                        int change = arrayS[j];
                        arrayS[j] = arrayS[j + 1];
                        arrayS[j + 1] = change;
                    }
                }
            }
            return arrayS;
        }
        public static int[,] GetTurn(int[,] matrixT)
        {
            int[,] matrixTurn = new int[matrixT.GetLength(0), matrixT.GetLength(1)];
            for (int i = 0; i < matrixTurn.GetLength(0); i++)
            {
                for (int j = 0; j < matrixTurn.GetLength(1); j++)
                {
                    matrixTurn[j, i] = matrixT[i, matrixTurn.GetLength(1) - j - 1];
                }
            }
            int[,] matrixS = new int[matrixTurn.GetLength(0), matrixTurn.GetLength(1)];
            for (int i = 0; i < matrixS.GetLength(0); i++)
            {
                for (int j = 0; j < matrixS.GetLength(1); j++)
                {
                    matrixS[i, j] = matrixTurn[i, j];
                }
            }
            return matrixS;
        }
        public static int[,] GetSpiralSort(int[,] matrixSS, int[] arraySS)
        {
            int[,] matrixSpiral = new int[matrixSS.GetLength(0), matrixSS.GetLength(1)];
            int sumCount = 0;
            int countArrayElement = 0;
            int countTurn = 0;
            while (sumCount < arraySS.Length)
            {
                if (countTurn == 4)
                {
                    for (int i = 1; i < matrixSpiral.GetLength(1) - 1; i++)
                    {
                        int j = 1;
                        matrixSpiral[j, i] = arraySS[i - 1 + sumCount];
                        countArrayElement++;
                    }
                    sumCount = 0;
                    sumCount = sumCount + countArrayElement;
                    matrixSpiral = GetTurn(matrixSpiral);
                    countTurn++;
                }
                if (countTurn >= 5 && countTurn <= 6)
                {
                    for (int i = 2; i < matrixSpiral.GetLength(1) - 1; i++)
                    {
                        int j = 1;
                        matrixSpiral[j, i] = arraySS[i - 2 + sumCount];
                        countArrayElement++;
                    }
                    sumCount = 0;
                    sumCount = sumCount + countArrayElement;
                    matrixSpiral = GetTurn(matrixSpiral);
                    countTurn++;
                }
                else
                {
                    for (int i = 0; i < matrixSpiral.GetLength(1) - 1; i++)
                    {
                        int j = 0;
                        matrixSpiral[j, i] = arraySS[i + sumCount];
                        countArrayElement++;
                    }
                    sumCount = 0;
                    sumCount = sumCount + countArrayElement;
                    matrixSpiral = GetTurn(matrixSpiral);
                    countTurn++;
                }
                
            }
            matrixSpiral = GetTurn(matrixSpiral);
            return matrixSpiral;
        }
    }
}