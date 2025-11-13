using System;
using System.Collections.Generic;


namespace Phone_store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество дней: ");
            int days = int.Parse(Console.ReadLine());     ///спрашиваем у пользователя за сколько дней считать продажи

            double total = 0; ///создали переменную де будем хранить общую сумму всех продаж, начиная с нуля (пока ничего не продано) 

            Dictionary<string, int> phoneSales = new Dictionary<string, int>(); /// Считаем сколько штук продали каждого телефона
            Dictionary<string, double> phoneMoney = new Dictionary<string, double>(); /// Считаем сколько денег принес каждый телефон


            for (int day = 1; day <= days; day++) ///цикл по дням которые ввёл пользователь 
            {
                Console.WriteLine($"\nДень {day}:"); ///вывод номер "текущего" дня

                Console.Write("Сколько телефонов продали? ");
                int phones = int.Parse(Console.ReadLine()); ///кол-во телефонов за день 

                double daySum = 0; /// обнуляем сумму для нового дня, создаём переменную для суммы продаж за текущий день 

                for (int phone = 1; phone <= phones; phone++) ///цикл по всем проданным телефонам в этот день 
                {
                    /// Сначала спрашиваем название телефона
                    Console.Write($"Название {phone}-го телефона: ");
                    string phoneName = Console.ReadLine();

                    Console.Write($"Цена {phone}-го телефона: ");
                    double price = double.Parse(Console.ReadLine());

                    ///  спрашиваем сколько штук продали
                    Console.Write($"Сколько штук продали {phoneName}: ");
                    int count = int.Parse(Console.ReadLine());

                    /// Считаем сумму за этот телефон
                    double phoneSum = price * count;
                    daySum += phoneSum;

                    /// Записываем в словари
                    if (phoneSales.ContainsKey(phoneName))
                    {
                        phoneSales[phoneName] += count; /// Увеличиваем количество продаж
                        phoneMoney[phoneName] += phoneSum; /// Увеличиваем сумму денег
                    }
                    else
                    {
                        phoneSales[phoneName] = count; /// Добавляем новый телефон
                        phoneMoney[phoneName] = phoneSum;
                    }

                }
                total += daySum; ///добавляем сумму дня к общей сумме
                Console.WriteLine($"В день {day} продано на: {daySum} руб."); /// показываем сумму за день
            }
            Console.WriteLine($"\nВсего продано на: {total} руб."); ///вывод общей суммы продаж

            string bestPhone = "";
            int bestCount = 0;
            string worstPhone = "";
            int worstCount = 1000000; /// Большое число чтобы любое реальное было меньше
            foreach (var phone in phoneSales)
            {
                /// Проверяем самый продаваемый
                if (phone.Value > bestCount)
                {
                    bestCount = phone.Value;
                    bestPhone = phone.Key;
                }

                /// Проверяем самый непопулярный
                if (phone.Value < worstCount)
                {
                    worstCount = phone.Value;
                    worstPhone = phone.Key;
                }
            }

            Console.WriteLine($"\n=СТАТИСТИКА ПРОДАЖ =");
            Console.WriteLine($"Самый продаваемый: {bestPhone} ({bestCount} шт.)");
            Console.WriteLine($"Самый непопулярный: {worstPhone} ({worstCount} шт.)");

        }
    }
}