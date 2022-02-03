using System;

namespace _024_Recurse
{
    class Program
    {
        static int Factorial(int argument)
        {
            if (argument == 0 || argument == 1)
            {
                return 1;
            }
            else
            {
                return argument * Factorial(argument - 1);
            }
        }

        static int FactorialLoop(int argument)
        {
            int resultLoop = 1;

            for (int i = 2; i <= argument; i++)
            {
                resultLoop = resultLoop * i;
            }
            return resultLoop;
        }

        static void Main()
        {
            int number = 3;
            int factorial = FactorialLoop(number);
            Console.WriteLine($"{number}! = {factorial}");

            // Delay
            Console.ReadKey();
        }
    }
}
