using System;

namespace _019_array3D
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,,,] bookName = new string[3, 5, 10, 10];

            bookName[0, 0, 0, 1] = "О дивный новый мир";
            bookName[1, 0, 4, 5] = "Приключения Тома Сойера";
            bookName[2, 1, 0, 7] = "CLR via C#";

            Console.WriteLine("Введите название книги:");
            string inputName = Console.ReadLine();

            for (int w = 0; w < bookName.GetLength(0); w++)
                for (int i = 0; i < bookName.GetLength(1); i++)
                    for (int j = 0; j < bookName.GetLength(2); j++)
                        for (int k = 0; k < bookName.GetLength(3); k++)
                        {
                            if (inputName == bookName[w, i, j, k])
                            {
                                Console.WriteLine($"{bookName[w, i, j, k]} находится в ячейке по адресу {w},{i},{j},{k}");
                            }
                        }
            foreach (string book in bookName)
            {
                if (book != null)
                Console.WriteLine($"{book}");
            }
            Console.ReadKey();
        }
    }
}
