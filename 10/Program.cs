using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y; // переменные
            x = 0; y = 0;

            while(x <= 15) // первые 15 чисел
            {
                if (x % 2 == 1) y = Math.Pow(x, 2); // проверка на нечетность 

                Console.WriteLine($"x = {x} y = {y}");

                x++; // шаг +1 
            }
            Console.ReadLine(); // задерживаем консоль
        }
    }
}
