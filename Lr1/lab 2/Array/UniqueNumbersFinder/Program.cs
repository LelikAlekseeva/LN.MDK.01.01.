using System;

namespace UniqueNumbersFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();///Создаем генератор случайных чисел
            List<int> allNumbers = new List<int>();///Создаем список для хранения 1500 случайных чисел 

            Console.WriteLine("Генерируем 1500 случайных чисел...");///Заполняем список 1500 случайными числами от 1 до 200
            for (int i = 0; i < 1500; i++)
            {
                int randomNumber = random.Next(1, 201); // Генерируем число от 1 до 200
                allNumbers.Add(randomNumber); // Добавляем число в список
            }
    }
}
