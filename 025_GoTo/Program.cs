using System;

namespace _025_GoTo
{
    class Program
    {

        static void Method(int a)
        {
        //Label:
            Console.WriteLine(" Метод два");
            goto Label;
        }

        static void MethodTwo (int a)
        {
            Label:
        }
        static void Main(string[] args)
        {
            //goto Label;
            int a = 0;
          
            /*
             * // Label:
            while (a == 0)
            {
                a = 1;
            //Label:
               // goto Label;
            }

            while (a != 1)
            {
                a = 0;
                //goto Label;
                while (true)
                {
                //label:
                    a = 0;
                }
            }
            */
            do
            {
            /Label:
                a = 1;
            }
            while (true);
            //goto Label;

          //  Console.ReadKey();
        }
    }
}
