using System;

namespace _009_СomplexityCode
{
    class Program
    {
        static void Main(string[] args)
        {
            double value;
            int g = 0, x = 1, y = 2, z = 3;
            int inputValue;
            {
                Console.WriteLine("Введите число:");
                inputValue = Convert.ToInt32(Console.ReadLine());
            }

            bool conditionOne;
            {
                conditionOne = x > y || inputValue < 15;
            }
            bool conditionTwo;
            {
                conditionTwo = z != y && z < 4;
            }

            if (conditionOne)
            {
                g = y;
                value = g + Math.PI;
                Console.WriteLine("число g = {0}, значение value = {1}", g, value);
            }
            else if(conditionTwo)
            {
                g = z;
                value = g + Math.Pow(Math.PI, 2);
                Console.WriteLine($"число g = {g}, значение value {value}");
            }
            else
            {
                ;
            }           

            Console.ReadKey();
        }
    }
}




