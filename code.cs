using System;

namespace StringArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = new string[] { "дом", "слон", "лес", "команда", "кит" };
            int count = 0; // Переменная для хранения количества строк с длиной менее или равной 3 символам

            // Создание выходного массива
            string[] outputArray = new string[count];
            int j = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length <= 3)
                {
                    outputArray[j] = inputArray[i];
                    j++;
                }
            }

             // Вывод выходного массива на консоль
            Console.WriteLine("Строки с длиной менее или равной 3 символам:");
            for (int i = 0; i < outputArray.Length; i++)
            {
                Console.WriteLine(outputArray[i]);
            }

            Console.ReadLine();
        }
    }
}