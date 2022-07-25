// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

namespace GB.Task56
{
    class Program
    {
        static void Main(string[] asgs)
        {
            // Создаем прямоугольный пустой массив размера 5х4
            int[,] matrix = new int[5, 4];
            // С помощью метода ниже заполняем массив
            FillMatrix(matrix);
            // Печатаем заполненный массив
            PrintMatrix(matrix);
            // Создаем одномерный массив (размер кол-во строк дмумерного),
            // который будет заполняться суммами строк двумерного массива
            int [] arraySum = new int [matrix.GetLength(0)];
            Console.WriteLine();
            // Забираем в метод заполненный двумерный массив и пустой одномерный
            GetSumRow(matrix, arraySum);
            // Выводим значения одномерного массива и номер строки i+1 с помощью цикла
            for(int i = 0; i < arraySum.Length; i++)
            {
                Console.WriteLine($" Сумма элементов {i+1} строки равна {arraySum[i]}");
            }
            Console.WriteLine();
            // С помощью метода находим индекс минимальный элемента в одномерном массиве 
            // и показываем его значение
            Console.WriteLine("Минимальная сумма элементов находится на " 
                            + $"{GetMinSum(arraySum)+1} строке и равна {arraySum[GetMinSum(arraySum)]}");
        }

        // Создаем метод который заполняет массив рандомными цифрами
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
        // Создаем метод, который печатает массив

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

        // Создаем метод который находит сумму цифр в строке
        public static int [] GetSumRow(int [,] matrixMain, int [] arrayS)
        {
            for (int i = 0; i < matrixMain.GetLength(0); i++)
            {
                // Вводим переменную, которая будет складывать значения
                int resultSumRow = 0;
                for (int j = 0; j < matrixMain.GetLength(1); j++)
                {
                    // Циклично записываем и складываем элементы в строке
                    resultSumRow = resultSumRow + matrixMain[i,j];
                }
                // Записываем в одномерный массив сумму строк по порядку
                arrayS[i] = resultSumRow;
            }
            // Возвращаем одномерный массив
            return arrayS;
        }
        // Создаем метод, который ищет минимальное значение в массиве
        public static int GetMinSum(int [] array)
        {
            // Вводим переменную, и кладем в нее первый элемент массива как минимальный
            int min = array[0];
            // Вводим переменную, и кладем в нее индекс первого элемента как минимальный
            int minPos = 0;
            for(int i = 0; i < array.Length; i++)
            {
                // Пробегаемся циклом по массиву и проверяем, min элемент все так же меньше
                if(min > array[i])
                {
                    // Если нет, то записываем новый элемент
                    min = array[i];
                    // И минимальный индекс
                    minPos = i;
                }
            }
            // Возвращаем минимальный индекс
            return minPos;
        }
    }
}