using System;

namespace _2_
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y; // переменные
            x = 0; // начальное значение 

            while (x <= 3) // пока x не будет = 2
            {
                y = Math.Pow(Math.E, -x) * x; // решаем функцию
                Console.WriteLine($"x = {x:0.00} y = {Math.Round(y, 2)}"); // вывод в консоль
                x += 0.2; // шаг действия x = x + 0.2
            }
            Console.ReadLine(); // задерживаем консоль
        }
    }
}
