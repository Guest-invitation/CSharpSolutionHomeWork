// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

namespace GB.Task47
{
    class Program
    {
        static void Main(string[] asgs)
        {
            // Создаем массив размера 3х4 типа double
            double [,] matrix = new double [3, 4];
            PrintMatrix(matrix);
            Console.WriteLine();
            // Создаем метод и заполняем массив случайными вещественными числами (+/- и с запятой)
            FillMatrix(matrix);
            // Создаем метод и печатаем массив
            PrintMatrix(matrix);
        }

        // Создаем метод, который заполняет массив случайными числами

        public static double [,] FillMatrix(double [,] matrixNew)
        {
            // Создаем цикл, заполняем случайными числами, а затем делим на 10,
            // чтобы получились числа с запятой
            for(int i = 0; i < matrixNew.GetLength(0); i++)
            {
                for(int j = 0; j < matrixNew.GetLength(1); j++)
                {
                    matrixNew[i,j] = new Random().Next(-99, 100);
                    // Записываем новое значение путем деления текущего на 10
                    matrixNew[i,j] = matrixNew[i,j]/10;
                }
            }
            // Возвращаем заполненный массив
            return matrixNew;
        }

        // Создаем метод, который будет нам печатать массив
        public static double [,] PrintMatrix(double [,] matrix)
        {
            // Выводим массив через циклы
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " | "); // печатам строку массива через разделитель |
                }
                Console.WriteLine(); // делаем переход на другую строку
            }
            // Возвращаем массив
            return matrix; 
        }
    }
}    