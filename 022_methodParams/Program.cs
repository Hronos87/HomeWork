using System;

namespace _022_methodParams
{
    class Program
    {
        /// <summary>
        /// Суммирует три целочисленные величины и возвращает сумму
        /// </summary>
        /// <param name="argyment1">первый аргумент</param>
        /// <param name="argyment2">второй аргумент</param>
        /// <param name="argyment3">третий аргумент</param>
        /// <returns></returns>
        static int Summary(int argyment1, int argyment2, int argyment3)
        {
            return argyment1 + argyment2 + argyment3;
        }
        /// <summary>
        ///Инкрементирует каждый аргумент и все полученные значения складывает
        /// </summary>
        /// <param name="argyment1"></param>
        /// <param name="argyment2"></param>
        /// <param name="argyment3"></param>
        /// <returns>сумма сложения аргументов</returns>
        static int Increment(int argyment1, int argyment2, int argyment3)
        {
            int argymentOne = ++argyment1, argymentTwo = ++argyment2, argynentThird = ++argyment3;
            return argymentOne + argymentTwo + argynentThird;
        }
        /// <summary>
        /// Метод выбора решения
        /// </summary>
        /// <param name="argyment1"></param>
        /// <param name="argyment2"></param>
        /// <param name="argyment3"></param>
        /// <param name="logicArgyment">по умолчанию false</param>
        /// <returns>целочисленную величина в зависимости от выбранного метода</returns>
        static void Choice(int argyment1, int argyment2, int argyment3, bool logicArgyment)
        {
            int choiceResult;
            if (logicArgyment == true)
            {
                choiceResult = Summary(argyment1, argyment2, argyment3);
            }
            else
            {
                choiceResult = Increment(argyment1, argyment2, argyment3);
            }
            Console.WriteLine($"Результат:{choiceResult}, первое число:{argyment1}, второе число:{argyment2}, третье число:{argyment3}, условие:{logicArgyment}.");
        }
        /// <summary>
        /// ввод чисел
        /// </summary>
        /// <returns>три целочисленных числа</returns>
        static (int firstNumber, int secondNumber, int thirdNumber) InputNumbers()
        {
            Console.WriteLine("Введите первое число:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            return (firstNumber, secondNumber, thirdNumber);
        }

        static void Main(string[] args)
        {
            string inputString;
            string[] arrayAnsver = new string[] { "true", "false" };
            bool resultCheck = false;
            do
            {
                Console.WriteLine("Выберети true или false!");
                inputString = Console.ReadLine();
                for (int i = 0; i < arrayAnsver.Length; i++)
                {
                    string inputStr;
                    inputStr = arrayAnsver[i];
                    if (inputStr == inputString)
                    {
                        resultCheck = true;
                        break;
                    }
                }
                if (resultCheck != true)
                {
                    Console.WriteLine("Неправильно написанно условие!");
                }
            }
            while (resultCheck == false);

            var inputNumbers = InputNumbers();
            int firstNum = inputNumbers.Item1, secondNum = inputNumbers.Item2, thirdNum = inputNumbers.Item3;

            Choice(argyment1: firstNum, argyment2: secondNum, argyment3: thirdNum, logicArgyment: Convert.ToBoolean(inputString));
            Console.ReadKey();
        }
    }
}