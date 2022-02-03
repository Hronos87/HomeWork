using System;


namespace _021_Metod
{
    class Program
    {
        static (int , int, int) inputInfo()
        {
            Console.WriteLine("Введите количество сотрудников:");
            int employs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимотсь дня работы:");
            int inputCostDayWork = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество дней работы:");
            int DayOfWork = Convert.ToInt32(Console.ReadLine());            

            return (employs, inputCostDayWork, DayOfWork);
        }
        static int payOfDayEmploys(int argument, int argument2)
        {         
            int sumCostForOneEmploy = argument * argument2;
            return sumCostForOneEmploy;
        }

        static void Main(string[] args)
        {
            var inputinfo = inputInfo();
            int inputemploys = inputinfo.Item1, inputCost = inputinfo.Item2, inputDay = inputinfo.Item3;
            int sumCost = inputemploys * inputDay * inputCost;

            int oneEmploy = payOfDayEmploys(inputCost, inputDay);
            Console.WriteLine($"Зарплата одного сотрудника:{oneEmploy}\nОбщая зарплата:{sumCost}");
            Console.ReadKey();
        }
    }
}

