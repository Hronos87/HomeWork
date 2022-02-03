using System;

namespace _014_whileDo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number;
            Console.WriteLine("Введите число:");
            number = Convert.ToInt32(Console.ReadLine());


            while (number >= 0)
            {
                Console.WriteLine($"{number}");
                number--;
            }




            int numberOne, numberTwo;
            Console.WriteLine("Введите первое (большие) число:");
            numberOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе (меньшие) число:");
            numberTwo = Convert.ToInt32(Console.ReadLine());

            int index = numberOne;

            do
            {
                bool notEven = (index % 2) != 0;
                while (notEven)
                {
                    Console.WriteLine($"{index}");
                    break;
                }
                --index;
            }
            while (index != numberTwo);
            // Delay
            Console.ReadKey();
        }
    }
}
