using System;

namespace While_29._10
{
    class Program
    {
        static void Main(string[] args)
         {
                byte x = 0; // переменная для цикла
                double y; // переменная для функции

                while (x <= 6) // пока значение х меньше или равно конечному
                {
                    y = Math.Pow(x, 2) - 8; //нахождение функции
                    Console.WriteLine($"y = {Math.Round(y,1)} x = {x}"); //вывод
                    x += 1; //шаг +1 

                }

                Console.ReadKey(); // задержать консоль
        }
    }
}
