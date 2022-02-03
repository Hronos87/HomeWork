using System;


namespace _007_Const
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.141593;
            const bool MY_CONST = true;
            
            double writeValue;
            {
               Console.WriteLine("Введите значение:");
               writeValue = Convert.ToDouble(Console.ReadLine());
            }
            

            bool ISConstBigger = PI > writeValue;

            bool CompareValue = MY_CONST == ISConstBigger;

            Console.WriteLine($"Значение сравнения {CompareValue}");

            // Delay

            Console.ReadKey();
        }
    }
}
