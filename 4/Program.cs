using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = -2, y, max; // переменные с плавующей точкой, x присваеваем сразу
            max = -1 * (x * x) + 3 * x + 1.15; // нахрдим max в первом значение переменной x (-2)

            while (x < 2) // перебираем значения пока x < 2 
            {
                y = -1 * (x * x) + 3 * x + 1.15; // вычисляем новый (предпологаемый максимум)
                Console.WriteLine("x={0:0.0} y={1:0.00}", x, y); // вывод в консоль
                x += 0.1; // шаг +0,1 цикла
                if (y > max) max = y; // смотрим больше ли новое значение y прошлого max, есди да, то изменяем на новое
            }
            Console.WriteLine("Максимально значение y = {0:.00}", max); //  вывод
            Console.ReadKey(); // задеоживаем консоль
        }
    }
}
