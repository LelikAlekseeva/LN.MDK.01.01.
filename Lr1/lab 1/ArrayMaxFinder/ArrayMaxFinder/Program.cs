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
            }
        }
    }
}
