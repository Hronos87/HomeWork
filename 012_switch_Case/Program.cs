using System;

namespace _012_switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne, numberTwo;
            string operand;
            {
                Console.WriteLine("Введите первое число:");
                numberOne = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                numberTwo = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Напишите операцию над числами:");
                operand = Console.ReadLine();
            }


            switch (operand)
            {
                case "+":
                    {
                        double sum;
                        sum = numberOne + numberTwo;
                        Console.WriteLine($"Результат: {sum}");
                        break;
                    }
                case "-":
                    {
                        double dif;
                        dif = numberOne - numberTwo;
                        Console.WriteLine($"Результат: {dif}");
                        break;
                    }
                case "*":
                    {
                        double pro;
                        pro = numberOne * numberTwo;
                        Console.WriteLine($"Результат: {pro}");
                        break;
                    }
                case "/" when (numberOne % numberTwo) == 0:
                    {
                        double quo;
                        quo = numberOne / numberTwo;
                        Console.WriteLine($"Результат: {quo}");
                        break;
                    }
                case "/":
                    {
                        Console.WriteLine("Неверное действие");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Неверный знак операции");
                        break;
                    }
            }

            Console.ReadKey();
        }
    }
}
