using System;


namespace _003_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите выслугу в годах: ");
            int Seniority = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите зарплату: ");
            decimal Salary = Convert.ToInt32(Console.ReadLine());

            bool Under5years = Seniority < 5;

            bool Allowance10PercAvailabla = Under5years == true;

            decimal Allowance10Perc = Salary * 0.1m;


            bool To5yearsOr10years = Seniority >= 5 & Seniority < 10;

            bool Allowance15PercAvailabla = true & (To5yearsOr10years == true);

            decimal Allowance15Perc = Salary * 0.15m;

            Console.WriteLine($"Надбавка 10% доступна:{Allowance10PercAvailabla}\n");

            Console.WriteLine($"Надбавка 15% доступна:{Allowance15PercAvailabla}\n");

            Console.WriteLine($"Надбавка составит: \nпри выслуге от 5 лет до 10 лет:{Allowance15Perc,7:F2} \nпри выслуге до 5лет:{Allowance10Perc,18:F2}");

            // Delay
            Console.ReadKey();
        }
    }
}
