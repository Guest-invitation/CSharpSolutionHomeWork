// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Точкой пересечения двух прямых являются координаты x и y

namespace GB.Task43
{
    class Program
    {
        static void Main(string[] asgs)
        {
            // Даем пользователю инструкцию 
            Console.WriteLine("Поиск точки пересечения двух прямых y = k1 * x + b1 и y = k2 * x + b2.");
            // Далее пользователь должен ввести значения b1, k1, b2, k2
            Console.Write("Введите k1: ");
            double k1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b1: ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите k2: ");
            double k2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b2: ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            // Создаем метод, который будет нам искать точку пересечения и подставлять введенные 
            // пользователем данные в функции, введем значения в массив
            double [] arrayXY = GetPoint(k1, b1, k2, b2); 
            // Выводим значения массива в сообщение на консоли
            Console.WriteLine($"Найдены координаты точки пересечения x = {arrayXY[0]}, y = {arrayXY[1]}");
        }

        // Создаем метод, который найдет нам x и yб и запишет значения в массив

        public static double [] GetPoint(double k1, double b1, double k2, double b2)
        {
            // Создаем массив размерности 2
            double [] arrayPoint = new double [2];
            // Вводим переменные x и y
            double x;
            double y;
            // y = k1 * x + b1
            // y = k2 * x + b2 
            // Нам нужно вывести из функций x, для это приравниваем 2 функции друг к другу и выводим x
            // k1 * x + b1 = k2 * x + b2
            // Выносим значения с x слева от знака равно, а остальные переносим направо
            // k1 * x - k2 * x = b2 - b1
            // Выносим x за скобки
            // x(k1 - k2) = b2 - b1
            // Переносим запись в скобках направо
            // x = (b2 - b1)/(k1 - k2)
            // Выписываем то что у нас получилось, сначала чему равно x, затем любую функцию y
            x = (b2 - b1)/(k1 - k2);
            y = k1 * x + b1;
            // Заполняем массив, а именно записываем туда x и y
            arrayPoint[0] = x;
            arrayPoint[1] = y;
            // Возвращаем массив
            return arrayPoint;
        }
    }
}    