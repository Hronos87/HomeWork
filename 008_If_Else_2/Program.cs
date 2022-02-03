using System;


namespace _008_If_Else_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            {
                {
                    Console.WriteLine("Введите сторону а:");
                    a = Convert.ToDouble(Console.ReadLine());
                }
                {
                    Console.WriteLine("Введите сторону b:");
                    b = Convert.ToDouble(Console.ReadLine());
                }
                {
                    Console.WriteLine("Введите сторону c:");
                    c = Convert.ToDouble(Console.ReadLine());
                }
            }
            bool triangAvalable;                                                      // Проверка возможности треугольника
            {                               
                triangAvalable = (a + b >= c) ^ (b + c >= a) ^ (c + a >= b);                

                if (triangAvalable)
                {
                    Console.WriteLine("Треугольник возможен");
                    {
                        bool rightTriangle;                                           // Прямоугольный треугольник
                        {
                            bool squadAC, squadAB, squadBC;
                            {
                                squadAC = (Math.Pow(a, 2) + Math.Pow(c, 2)) == (Math.Pow(b, 2));
                                squadAB = (Math.Pow(a, 2) + Math.Pow(b, 2)) == (Math.Pow(c, 2));
                                squadBC = (Math.Pow(b, 2) + Math.Pow(c, 2)) == (Math.Pow(a, 2));
                            }

                            rightTriangle = squadAC ^ squadAB ^ squadBC;
                            if (rightTriangle)
                            {
                                Console.WriteLine("Треугольник прямоугольный");
                            }
                            else
                            {
                                Console.WriteLine("Треугольник непрямоугольный");
                            }
                        }

                        bool equilateralTriangle;                                      // Равностороний треугольник
                        {
                            equilateralTriangle = (a == b) && (a == c) && (b == c);

                            if (equilateralTriangle)
                            {
                                Console.WriteLine("Треугольник равностороний");
                            }
                            else
                            {
                                Console.WriteLine("Треуголник неравносторонний");
                            }
                        }

                        bool isoscelesTriangle;                                        // Равнобедренный треугольник
                        {
                            isoscelesTriangle = (a == b) ^ (a == c) ^ (b == c);

                            if (isoscelesTriangle)
                            {
                                Console.WriteLine("Треугольник равнобедренный");
                            }
                            else
                            {
                                Console.WriteLine("Треугольник неравнобедренный");
                            }
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Треугольник невозможен");
                }
            }            
            // Delay
            Console.ReadKey();
        }
    }
}
