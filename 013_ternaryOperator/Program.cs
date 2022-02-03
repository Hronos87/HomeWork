using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            int x = 0, y = 0;

            string quadrant = (x == 0) || (y == 0) ? "По оси значение равно нулю" : x > 0 ? y > 0 ? "I квадрант" : "IV квадрант" : y > 0 ? "II квадрант" : "III квадрант";

            Console.WriteLine(quadrant);

            // Delay
            Console.ReadKey();*/
            #endregion

            int x, y;
            {
                Console.WriteLine("Введите число Х");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите число Y");
                y = Convert.ToInt32(Console.ReadLine());
            }

            x = x % 2 == 0 ? x : ++x;
            y = y % 2 == 0 ? y : ++y;

            string result = (x + y) % 4 == 0 ? $"Сумма значений {x} + {y} делиться на 4" : $"Сумма значений {x} + {y} не делиться на 4";


            Console.WriteLine($"{result}");

            int a, b;
            {
                Console.WriteLine("Введите число a");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите число b");
                b = Convert.ToInt32(Console.ReadLine());
            }

            (a > b ? ref a : ref b) = 100;


            Console.WriteLine($"{a} {b}");


            Console.ReadKey();
        }
    }
}