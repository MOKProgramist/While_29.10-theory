using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = -3, y;// присваивание начального значения Х

            while (x <= 3) // пока значение х меньше конечного
            {
                if (x == 0) // Проверка значение на нуло
                {
                    Console.WriteLine($"при x = {x} Деление на ноль запрещено!");
                }
                else // если переменная не равна нулю, продолжаем вывод до x <=3
                {
                    y = Math.Round(1 / x, 3); // делим и сокращаем сразу
                    Console.WriteLine($"x = {x} y = {y}"); // вывод
                }
                x += 1; //шаг +1
            }

            Console.ReadKey(); // задержать консоль 
        }
    }
}
