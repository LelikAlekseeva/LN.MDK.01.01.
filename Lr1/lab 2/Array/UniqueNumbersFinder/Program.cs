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
                allNumbers.Add(randomNumber);

                Dictionary<int, int> numberCounts = new Dictionary<int, int>();///Создаем словарь для подсчета количества каждого числа

                foreach (int number in allNumbers)///Подсчитываем сколько раз встречается каждое число
                {
                    ///Если число уже есть в словаре, увеличиваем счетчик
                    if (numberCounts.ContainsKey(number))
                    {
                        numberCounts[number]++; // Увеличиваем счетчик на 1
                    }
                    else
                    {
                        /// Если числа нет в словаре, добавляем его со счетчиком 1
                        numberCounts[number] = 1;
                    }
                }
                List<int> uniqueNumbers = new List<int>();///Создаем список для чисел, которые встречаются только один раз
                
            }
        }
    }
}