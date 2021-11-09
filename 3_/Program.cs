using System;

namespace _3_
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y; // переменные
            x = -5; // начальное значение 

            while (x <= 5) // пока x не будет = 2
            {
                if (x + 1 <= 0) // в случае если решения нет, корень в -
                {
                    Console.WriteLine("Решение нет при x = {0}", x);
                }
                else
                {
                    y = Math.Sqrt(x + 1); // решаем функцию

                    Console.WriteLine($"x = {x:0.00} y = {Math.Round(y, 2)}"); // вывод в консоль
                }
                x += 1.5; // шаг действия x = x + 1,5
            }
            Console.ReadLine(); // задерживаем консоль
        }
    }
}
