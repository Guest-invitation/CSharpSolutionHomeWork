// Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию 
// элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

namespace GB.Task54
{
    class Program
    {
        static void Main(string[] asgs)
        {
            // Создаем пустой массив размера 3х4
            int[,] matrix = new int[3, 4];
            // Обращаемся к методу, чтобы заполнить наш пустой массив
            FillMatrix(matrix);
            // Печатаем заполненный массив
            PrintMatrix(matrix);
            // Передаем наш массив в метод, который отсортирует его и перезапишет
            GetMatrixSort(matrix);
            Console.WriteLine();
            // Печатаем массив
            PrintMatrix(matrix);
        }

        // Создаем метод который заполнит массив случайными числами от 1 до 9
        public static int[,] FillMatrix(int[,] matrixF)
        {
            for (int i = 0; i < matrixF.GetLength(0); i++)
            {
                for (int j = 0; j < matrixF.GetLength(1); j++)
                {
                    matrixF[i, j] = new Random().Next(1, 10);
                }
            }
            // Возвращаем массив
            return matrixF;
        }

        // Создаем метод, который печатает массив
        public static int[,] PrintMatrix(int[,] matrixP)
        {
            for (int i = 0; i < matrixP.GetLength(0); i++)
            {
                for (int j = 0; j < matrixP.GetLength(1); j++)
                {
                    Console.Write(matrixP[i, j] + " | ");
                }
                // Строяка перехода на новую строку
                Console.WriteLine();
            }
            // Возвращаем массив
            return matrixP;
        }

        // Создаем метод, который сортирует наш массив по строчкам от мин к макс элементу
        public static int[,] GetMatrixSort(int[,] matrixS)
        {
            for (int i = 0; i < matrixS.GetLength(0); i++)
            {
                int min = matrixS[i, 0];
                for (int j = 0; j < matrixS.GetLength(1); j++)
                {
                    // i строке массива мы берем j за минимальный индекс и потом циклом сравнимаем 
                    // попарно элемент минимальный на данном этапе цикла со следующим по порядку
                    int minPos = j;
                    for (int jSecond = j + 1; jSecond < matrixS.GetLength(1); jSecond++)
                    {
                        if (matrixS[i,minPos] > matrixS[i, jSecond])
                        {
                            minPos = jSecond;
                        }
                    }
                    // после всех сравнений мы перезаписываем на позицию i,j на которой мы находимся
                    // значение самого минимального элемента и приступаем к следующему элементу строки
                    int change = matrixS[i,minPos];
                    matrixS[i,minPos] = matrixS[i,j];
                    matrixS[i,j] = change;
                }
            }
            // Возвращаем отсортированный массив
            return matrixS;
        }
    }
}