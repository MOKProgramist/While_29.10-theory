using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, s, n, sr, min, max; // переменные
            x = 0.1; max = 0; min = 0; n = 0; s = 0; // начальные значения

            while (x <= 3)
            {
                y = 1 / (Math.Pow(x, 2) + 1); // вычисляем

                s += y; // сумма 
                min = min <= y ? y : min; // если текущая сумма меньше значения - изменяем
                max = max <= y ? y : max; // если текущая сумма больше значения - изменяем
                n += 1; // количество чисел

                Console.WriteLine($"y = {y:0.000} x = {x:0.0}");

                x += 0.2; // шаг

            }
            sr = s / n; // среднее число

            Console.WriteLine($"\nmax = {max:0.000} min = {min:0.000} s = {s:0.000}\nsr = {sr:0.000} n = {n}");
            Console.ReadLine(); // задерживаем консоль
        }
    }
}
