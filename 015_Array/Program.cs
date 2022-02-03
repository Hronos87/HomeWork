using System;


namespace _015_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mounthList = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };

            #region
            /*
            while (counter <= 11)
            {
                Console.WriteLine(mounthList[counter]);
                counter++;
            }
            Console.ReadKey();
            */
            #endregion             
            int counter = 0;
            int index = 0;
            do
            {
                string inputMounth;
                {
                    Console.WriteLine("Напишите месяц:");
                    inputMounth = Console.ReadLine();
                }
                bool mounthMatched;
                {
                    string currentMounth = mounthList[counter];
                    mounthMatched = currentMounth == inputMounth;
                }
                if (mounthMatched)
                {
                    Console.WriteLine("Верно");
                    counter++;
                    continue;
                }
                else
                {
                    Console.WriteLine("Неверно");
                    const int AVAILABLE_TRY_ATTEMPT = 5;
                    if (index < AVAILABLE_TRY_ATTEMPT)
                    {
                        index++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            while (counter <= mounthList.Length);

        }
    }

}

