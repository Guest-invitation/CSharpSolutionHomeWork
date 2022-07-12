// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Задача состоит в том чтобы сложить все цифры числа, например если у нас число 123, то
// 1+2+3 = 6, 6 - это конечный результат

namespace GB.Task27
{
    class Program
    {
        static void Main(string[] asgs)
        {
            // Выводим сообщение, что должен делать пользователь и просим ввести число
            Console.WriteLine("Любое число и мы посчитаем сумму цифр из которого оно состоит: ");
            // тип строка
            int number = Convert.ToInt32(Console.ReadLine());
            // Вводим переменную length, в которую положим значения размера введенной строки
            string str = Convert.ToString(number);
            int length = str.Length;
            // Создаем массив, в который будем присваивать полученный с помощью метода GetArray
            // массив собирающий значения цифр введенного числа
            int [] array = GetArray(number, length);
            Console.WriteLine($"Сумма цифр введенного числа {number} равна {GetSum(array, length)}");
        }
        public static int [] GetArray(int num, int size)
        {
            
            int [] arrayA = new int [size];
            for (int i = 0; i < size; i++)
            {
                arrayA[size - i - 1] = num%10;
                num = num - arrayA[size - i - 1];
                num = num/10;
            }
            return arrayA;
        }

        public static int GetSum(int [] arrayS, int size)
        {
            int result = 0;
            for (int i = 0; i < size; i++)
            {
                result = result + arrayS[i];
            }
            return result;
        }
    }
}        