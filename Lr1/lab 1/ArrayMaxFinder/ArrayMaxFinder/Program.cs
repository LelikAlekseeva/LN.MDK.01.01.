using System;

namespace ArrayMaxFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество жлементов массива: ");
            int n =int.Parse(Console.ReadLine()); ///спрашиваем размер массива у пользователя 
            int[] array = new int[n];///создание массива заданного размера 

            Console.WriteLine($"Введите {n} целых чисел : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());///заполняется массив чиселками пользователя

                int max = array[1];///предположи что 1ый эл-т максимальный
                int maxIndex = 0;///запомнили индекс первого эл-та

                for (int i = 1; i< n; i++)///цикл начинаем со второго эл-та
                {
                    if (array[i] > max)///Проверим если текущий элемент больше нашего текущего максимума
                    {
                        max = array[i];///запоминаем индекс нового мак эл-та
                    }
                }

            }
        }
    }
}
