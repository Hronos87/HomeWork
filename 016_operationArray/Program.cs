using System;


namespace _016_operationArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:");
            int arrayLenght = Convert.ToInt32(Console.ReadLine());
            int index = arrayLenght;

            int[] arrayNumber = new int[index];

            int i = 0;
            while (i < arrayNumber.Length)
            {
                Console.WriteLine($"Напишите значение элемента:");
                arrayNumber[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            Array.Reverse(arrayNumber);
            Array.Resize(ref arrayNumber, arrayNumber.Length + 1);

            Console.WriteLine("Значение нового элемента:");
            arrayNumber[arrayNumber.Length - 1] = Convert.ToInt32(Console.ReadLine()); 

            Console.ReadKey();
        }
    }
}
