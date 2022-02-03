using System;


namespace _018_array2D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayA, arrayB;
            int numberLineOfArrayA, numberColumnOfArrayA, numberLineOfArrayB, numberColumnOfArrayB;
            {
                Console.WriteLine("Ввдите количество строк в массиве A");
                numberLineOfArrayA = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ввдите количество столбцов в массиве A");
                numberColumnOfArrayA = Convert.ToInt32(Console.ReadLine());

                arrayA = new int[numberLineOfArrayA, numberColumnOfArrayA];

                Console.WriteLine("Ввдите количество строк в массиве B");
                numberLineOfArrayB = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ввдите количество столбцов в массиве B");
                numberColumnOfArrayB = Convert.ToInt32(Console.ReadLine());
                arrayB = new int[numberLineOfArrayB, numberColumnOfArrayB];
            }

            // chektAvalableMultiplication
            bool multiplicationAvailable = false;

            if ((numberLineOfArrayA == numberColumnOfArrayB) || (numberLineOfArrayB == numberColumnOfArrayA))
            {
                multiplicationAvailable = true;
            }
            else
            {
               Console.WriteLine("Умножение невозможно");
            }

            if (multiplicationAvailable)
            {
                for (int i = 0; i < arrayA.GetLength(0); i++)
                {
                    for (int j =0; j < arrayA.GetLength(1); j++)
                    {
                        Console.WriteLine($"Введите значение по адресу строки{i + 1} и  столбца{j + 1}:");
                        arrayA[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                for (int i = 0; i < arrayB.GetLength(0); i++)
                {
                    for (int j = 0; j < arrayB.GetLength(1); j++)
                    {
                        Console.WriteLine($"Введите значение по адресу строки{i + 1} и  столбца{j + 1}:");
                        arrayB[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                int resultMultiplicationArray = 0;

                for (int i = 0; i < arrayA.GetLength(0); i++)
                {
                    for (int j = 0; j < arrayA.GetLength(1); j++)
                    {
                        resultMultiplicationArray = arrayA[i, j] * arrayB[i, j];
                        Console.Write($"{resultMultiplicationArray} ");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
