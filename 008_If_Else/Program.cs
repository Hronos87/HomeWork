using System;


namespace _008_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {            
            int value;
            {
                Console.Write("Введите число:");
                string inputValue = Console.ReadLine();
                value = Convert.ToInt32(inputValue);
            }
                        
           const int MIN_NUMBER_FOR_ADDICT = 3;
           bool valueCompare = value > MIN_NUMBER_FOR_ADDICT;
            if (valueCompare)
            {
              value += 10;
            }
            else
            {
              value *= 10;
            }
           
            Console.WriteLine($"Результат:{value}");

            // Delay

            Console.ReadKey();
        }
    }
}
