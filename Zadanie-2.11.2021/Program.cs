using System;

namespace Zadanie_2._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y; // переменные
            x = -2; // начальное значение 

            while (x <= 2) // пока x не будет = 2
            {
                if (x == 0) // проверка 
                {
                    Console.WriteLine($"На \"{x}\" делить нельзя");

                }
                else
                {
                    y = (Math.Pow(x, 2) + (1 / Math.Pow(x, 2))); // функция
                    Console.WriteLine($"y = {Math.Round(y, 1)} x = {x}"); // вывод в консоль 
                }
                x += 0.5; // шаг действия x = x + 2,5
            }
            Console.ReadLine(); // задерживаем консоль
        }
    }
}
