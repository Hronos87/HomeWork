using System;

namespace _006_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            {
                int a = 10, b = 20, c = 30;
                sum = a + b + c;
            }
            
            int dif;
            {
                int x = 50, y = 150, z = 300;
                dif = z - y - x;
            }

            double quontient = (double)sum / dif;
            Console.WriteLine($"Значение частного равно:{quontient}");

            // Delay
            Console.ReadKey();
        }
    }
}
