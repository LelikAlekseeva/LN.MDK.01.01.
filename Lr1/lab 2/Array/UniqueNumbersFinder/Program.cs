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

                foreach (var pair in numberCounts)///Находим все числа, которые встречаются ровно один раз
                {
                    /// Проверяем, встречается ли число только один раз
                    if (pair.Value == 1)
                    {
                        uniqueNumbers.Add(pair.Key); /// Добавляем число в список уникальных
                    }
                }
                uniqueNumbers.Sort();///ортируем уникальные числа по возрастанию для красивого вывода
                Console.WriteLine("\nЧисла, встречающиеся один раз:");///Выводим результат в формате [a1, a2, a3, ..., an]
                Console.Write("[");

                /// Выводим все числа через запятую
                for (int i = 0; i < uniqueNumbers.Count; i++)
                {
                    Console.Write(uniqueNumbers[i]); /// Выводим текущее число

                    /// Если это не последнее число, ставим запятую
                    if (i < uniqueNumbers.Count - 1)
                    {
                        Console.Write(", ");
                    }
                }

                Console.WriteLine("]"); /// Закрываем квадратную скобку
                Console.WriteLine($"\nСтатистика:");
                Console.WriteLine($"Всего сгенерировано чисел: {allNumbers.Count}");
                Console.WriteLine($"Найдено уникальных чисел: {uniqueNumbers.Count}");///добавили вывод статистики 
                Console.ReadKey();
            }
        }
    }
}