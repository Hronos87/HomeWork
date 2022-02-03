using System;

namespace _010_multiply_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideOne, sideTwo;
            const string squareString = "площадь", perimeterString = "периметр";
            String inputWord;
            {
                Console.WriteLine("Введите первую сторону:");
                sideOne = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите вторую сторону:");
                sideTwo = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Вывести площадь или периметр?");
                inputWord = Convert.ToString(Console.ReadLine());
            }

            if (inputWord == squareString)
            {
                double square = sideOne * sideTwo;
                Console.WriteLine($"Площадь составляет:{square}");
            }
            else if (inputWord == perimeterString)
            {
                double perimetr = (sideOne + sideTwo) * 2 ;
                Console.WriteLine($"Периметр составляет:{perimetr}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неверная команда!");
            }

            bool quadrate = sideOne == sideTwo;
            if (quadrate)
            {
                Console.WriteLine("Данный прямоугольник - квадрат");
            }

            Console.ReadKey();
        }
    }
}
