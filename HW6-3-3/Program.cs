using System;

namespace PerfectNumbers
{
    class Program
    {
        static bool IsPerfectNumber(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            return sum == number;
        }

        static void FindPerfectNumbers(int start, int end)
        {
            Console.WriteLine($"Совершенные числа в интервале от {start} до {end}:");
            for (int i = start; i <= end; i++)
            {
                if (IsPerfectNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите начало интервала:");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите конец интервала:");
            int end = Convert.ToInt32(Console.ReadLine());

            FindPerfectNumbers(start, end);
        }
    }
}
