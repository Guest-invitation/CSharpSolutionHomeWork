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
            // Создаем 2 пустых массива одинакового размера
            int[,] matrixFirst = new int[4, 4];
            int[,] matrixSecond = new int[4, 4];
            // Заполняяем каждый из них случайными числами
            FillMatrix(matrixFirst);
            FillMatrix(matrixSecond);
            // Печатаем заполненные массивы в консоль
            Console.WriteLine("Сгенерирована первая матрица размера 4х4: ");
            PrintMatrix(matrixFirst);
            Console.WriteLine("Сгенерирована вторая матрица размера 4х4: ");
            PrintMatrix(matrixSecond);
            // Создаем новый массив, в который мы запишем произведение двух первых
            int [,] matrixProduct = GetProductMatrix(matrixFirst, matrixSecond);
            Console.WriteLine();
            // Печатаем массив произведения двух первых массивов
            PrintMatrix(matrixProduct);
        }

        // Создаем метод, который заполянет массив
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

        // Создаем метод, который умножает 2 массива друг на друга
        public static int[,] GetProductMatrix(int[,] matrix1, int [,] matrix2)
        {
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    // С помощью цикла пробегаемся по массиву и умножаем его значение
                    // на значение на такой же позиции (с такими же индексами) у другого массива
                    matrix1[i,j] = matrix1[i,j] * matrix2[i,j];
                }
            }
            // Возвращаем перезаписанный первый массив
            return matrix1;
        }
    }
}