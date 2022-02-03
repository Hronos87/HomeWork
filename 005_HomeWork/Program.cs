using System;


namespace _005_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введие символ:");
            char value = Convert.ToChar(Console.ReadLine());
            
            Console.WriteLine("Введите ключ");
            short key = Convert.ToInt16(Console.ReadLine());

            char encryptedValue = (char)(value^key);

            char decryptedValue = (char)(encryptedValue^key);


            Console.WriteLine($"Символ {value}\n ключ {key}\n зашифрованный символ {encryptedValue}\n расшифрованный символ {decryptedValue}");

            Console.ReadKey();
        }
    }
}
