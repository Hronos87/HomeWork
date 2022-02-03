using System;

namespace _020_jaggerArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Получение текса
            Console.WriteLine("Введите текст:");
            string inputText = Console.ReadLine();
            char[] charSeparator = new char[] { '.' };

            // разбиение текста на предложения
            string[] arraySentence;
            arraySentence = inputText.Split(charSeparator, StringSplitOptions.RemoveEmptyEntries);

            // разбиение предложений на слова
            string[][] arrayWord = new string[arraySentence.Length][];

            for (int i = 0; i < arraySentence.Length; i++)
            {
                string word;
                word = arraySentence[i];
                arrayWord[i] = word.Split();
            }

            // вывод всех слов
            foreach (var separatingWord in arrayWord)
                for (int i = 0; i < separatingWord.Length; i++)
                {
                    Console.WriteLine($"{separatingWord[i]}");
                }
            Console.ReadKey();
        }
    }
}