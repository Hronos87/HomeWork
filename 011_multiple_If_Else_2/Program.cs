using System;

namespace _011_multiple_If_Else_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputNumberOne, inputNumberTwo, inputNumberThree, inputNumberFour;
            {
                Console.WriteLine("Введите число:");
                inputNumberOne = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите число:");
                inputNumberTwo = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите число:");
                inputNumberThree = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите число:");
                inputNumberFour = Convert.ToDouble(Console.ReadLine());
            }

            double evenNumberOne, evenNumberTwo, evenNumberThree, evenNumberFour;
            {
                if (inputNumberOne % 2 == 0)
                {
                    evenNumberOne = inputNumberOne;
                }
                else
                {
                    evenNumberOne = 0;
                }
                if (inputNumberTwo % 2 == 0)
                {
                    evenNumberTwo = inputNumberTwo;
                }
                else
                {
                    evenNumberTwo = 0;
                }
                if (inputNumberThree % 2 == 0)
                {
                    evenNumberThree = inputNumberThree;
                }
                else
                {
                    evenNumberThree = 0;
                }
                if (inputNumberFour % 2 == 0)
                {
                    evenNumberFour = inputNumberFour;
                }
                else
                {
                    evenNumberFour = 0;
                }
            }

            bool maxEvenNumberOne, maxEvenNumberTwo, maxEvenNumberThree, maxEvenNumberFour;
            {
                maxEvenNumberOne = (evenNumberOne > evenNumberTwo) & (evenNumberOne > evenNumberThree) & (evenNumberOne > evenNumberFour);
                maxEvenNumberTwo = (evenNumberTwo > evenNumberOne) & (evenNumberTwo > evenNumberThree) & (evenNumberTwo > evenNumberFour);
                maxEvenNumberThree = (evenNumberThree > evenNumberOne) & (evenNumberThree > evenNumberTwo) & (evenNumberThree > evenNumberFour);
                maxEvenNumberFour = (evenNumberFour > evenNumberOne) & (evenNumberFour > evenNumberTwo) & (evenNumberFour > evenNumberThree);
            }
            double maxEvenNumber;
            {
                if (maxEvenNumberOne)
                {
                    maxEvenNumber = evenNumberOne;
                }
                else if (maxEvenNumberTwo)
                {
                    maxEvenNumber = evenNumberTwo;
                }
                else if (maxEvenNumberThree)
                {
                    maxEvenNumber = evenNumberThree;
                }
                else if (maxEvenNumberFour)
                {
                    maxEvenNumber = evenNumberFour;
                }
                else
                {
                    maxEvenNumber = 0;
                    Console.WriteLine("Not found");
                }
            }
            Console.WriteLine($"Максимальное четное число:{maxEvenNumber}");            

            Console.ReadKey();
        }
    }
}
