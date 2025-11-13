using System;


namespace Phone_store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество дней: ");
            int days = int.Parse(Console.ReadLine());     ///спрашиваем у пользователя за сколько дней считать продажи

            double total = 0; ///создали переменную де будем хранить общую сумму всех продаж, начиная с нуля (пока ничего не продано) 

            for (int day = 1; day <= days; day++) ///цикл по дням которые ввёл пользователь 
            {
                Console.WriteLine($"\nДень {day}:"); ///вывод номер "текущего" дня

                Console.Write("Сколько телефонов продали? ");
                int phones = int.Parse(Console.ReadLine()); ///кол-во телефонов за день 

                double daySum = 0; /// обнуляем сумму для нового дня, создаём переменную для суммы продаж за текущий день 

                for (int phone = 1; phone <= phones; phone++) ///цикл по всем проданным телефонам в этот день 
                {
                    Console.Write($"Цена {phone}-го телефона: ");
                    double price = double.Parse(Console.ReadLine()); ///Спрашиваем цену каждого телефона 

                    daySum += price; ///Прибавляем цену телефона к сумме за день

                    total += daySum;    ///обавляем дневную выручку к общей выручке

                    Console.WriteLine($"В день {day} продано на: {daySum} руб.");  ///Показываем пользователю сколько продали за этот день 
                }
                Console.WriteLine($"\nВсего продано на: {total} руб."); ///вывод общей суммы продаж
            }
        }
    }
}