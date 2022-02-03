using System;


namespace _017_for
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 0;
            
            for (int i = 0; i <= 100; i++)
            {
                a = i;
                Console.Write($"{a},");                
            }

            for (int i = 1001; i <= 2500; i += 3)
            {
                a = i;
                Console.Write($"{a},");
            }
            
            for (int i = 100; i >= 0; i -= 4)
            {
                a = i;
                Console.Write($"{a},");
            }
            */
            double a = 0;
            for (double i = 1; i <= 5; i += .2)
            {
                a = i;
                Console.Write($"{a:F}\n");
            }

            Console.ReadKey();
        }
    }
}
