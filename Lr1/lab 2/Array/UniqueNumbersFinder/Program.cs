using System;
using System.Collections.Generic;

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
                int randomNumber = random.Next(1, 201); ///Генерируем число от 1 до 200
                allNumbers.Add(randomNumber); ///Добавляем число в список
            }

            Dictionary<int, int> numberCounts = new Dictionary<int, int>();///Создаем словарь для подсчета количества каждого числа

            foreach (int number in allNumbers)///Подсчитываем сколько раз встречается каждое число
            {
                ///Если число уже есть в словаре, увеличиваем счетчик
                if (numberCounts.ContainsKey(number))
                {
                    numberCounts[number]++; ///Увеличиваем счетчик на 1
                }
                else
                {
                    ///Если числа нет в словаре, добавляем его со счетчиком 1
                    numberCounts[number] = 1;
                }
            }

            List<int> uniqueNumbers = new List<int>();///Создаем список для чисел, которые встречаются только один раз

            foreach (var pair in numberCounts)///Находим все числа, которые встречаются ровно один раз
            {
                ///Проверяем, встречается ли число только один раз
                if (pair.Value == 1)
                {
                    uniqueNumbers.Add(pair.Key); ///Добавляем число в список уникальных
                }
            }

            uniqueNumbers.Sort();///Сортируем уникальные числа по возрастанию для красивого вывода

            Console.WriteLine("\nЧисла, встречающиеся один раз:");///Выводим результат в формате [a1, a2, a3, ..., an]
            Console.Write("[");

            ///Выводим все числа через запятую
            for (int index = 0; index < uniqueNumbers.Count; index++)
            {
                Console.Write(uniqueNumbers[index]); ///Выводим текущее число

                ///Если это не последнее число, ставим запятую
                if (index < uniqueNumbers.Count - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("]"); ///Закрываем квадратную скобку

            Console.WriteLine($"\nСтатистика:");
            Console.WriteLine($"Всего сгенерировано чисел: {allNumbers.Count}");
            Console.WriteLine($"Найдено уникальных чисел: {uniqueNumbers.Count}");///Добавили вывод статистики 

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey(); ///Ждем нажатия клавиши перед закрытием
        }
    }
}