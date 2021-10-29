using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i; // объявляем переменные
            i = 0; // задаем переменной значение

            Console.Write("Число: "); // вывод на экран
            num = Convert.ToInt32(Console.ReadLine()); // запись числа введенного пользователем

            while (num > 0) // Проверка перемеменной
            {
                i++; // Переменная i инкрементируется
                num = num / 10; // Деление переменной num на 10
                Console.WriteLine(num); // выводи суимму после действия
            }

            Console.WriteLine("Кол-во периодов: " + i); // вывод на экран
            Console.ReadKey(); // задерживаем консоль

        }
    }
}
