using System;

namespace _4_
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y; // переменные
            x = -1; // начальное значение 

            while (x <= 2) // пока x не будет = 2
            {
                y = Math.Pow(Math.E, -x) - x; // решаем функцию
                Console.WriteLine($"y = {Math.Round(y, 2)} x = {x:0.00} "); // вывод в консоль
                x += 0.2; // шаг действия x = x + 0.2
            }
            Console.ReadLine(); // задерживаем консоль
        }
    }
}
