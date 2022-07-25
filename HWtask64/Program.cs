// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

namespace GB.Task64
{
    class Program
    {
        static void Main(string[] asgs)
        {
            Console.WriteLine("Введите значение M: ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            if(M>N)
            {
                int min = N;
                int max = M;
                while(min<=max)
                {
                    Console.Write(min + " | ");
                    min++;
                }
            }
            else
            {
                int min = M;
                int max = N;
                while(min<=max)
                {
                    Console.Write(min + " | ");
                    min++;
                }
            }
        }

        
        
    }
}