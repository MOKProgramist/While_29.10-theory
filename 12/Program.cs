using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double n, x, min, max;
            min = 23232; max = 0; n = 1; // начальные значения
            Console.Write("Введите количество чисел: ");
            x = int.Parse(Console.ReadLine()); // считывает значение с консоли
            Console.WriteLine(); // красивый отступ

            while (n <= x)
            {
                Console.WriteLine($"Введите число №{n}");
                // var a = rnd.Next(-1, 12321); // рандом
                var a = double.Parse(Console.ReadLine()); // считываем значение
                // Console.WriteLine(a);

                min = a < min ? a : min; // проверка числа на минимум из измеющегося значения
                max = a > max ? a : max; // проверка числа на максимум из измеющегося значения

                n++; // шаг +1
            }
            Console.WriteLine($"max = {max} min = {min}");

            Console.ReadLine(); // задерживаем консоль
        }
    }
}
