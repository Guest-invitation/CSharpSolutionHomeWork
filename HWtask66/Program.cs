// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

namespace GB.Task66
{
    class Program
    {
        static void Main(string[] asgs)
        {
            Console.WriteLine("Введите значение M: ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if(M>N)
            {
                int min = N;
                int max = M;
                
                while(min<=max)
                {
                    sum = sum + min;
                    min++;
                }
            }
            else
            {
                int min = M;
                int max = N;
                while(min<=max)
                {
                    sum = sum + min;
                    min++;
                }
                
            }
            Console.WriteLine($"Сумма элементов от {M} до {N} равна {sum}");
        }
    }
}