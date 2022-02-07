using System;

namespace _026_Kata
{
    class Program
    {
        static string Replace (string s)
        {
            return s.Replace("!", "") + "!";  // Метод Replace заменяет один символ в строке другим
        }
        static void Main(string[] args)
        {// Мое решение
            string s = "!Hi!!Hi! Hi!";
            char[] separetor = {'!'};
            string[] arrayHi = s.Split(separetor, StringSplitOptions.RemoveEmptyEntries);

            string Hi = null;
            for (int i = 0; i < arrayHi.Length; i++)
            {
              Hi += arrayHi[i];               
            }
            string clear = Hi + "!";
            Console.WriteLine($"{clear}");            
            Console.ReadKey();
        }
    }
}
