using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Race
{
    class Program
    {
        static public void PrintMode (Car car)
        {
            Console.WriteLine(car.GetModel());
        }
        static public void LadaVSMers(List<Car> cars)
        {
            int time = 0;
            int finish = 248;
            while(true)
            {
                foreach (Car car in cars)
                {
                    Console.WriteLine("======");
                    int NumberSpace = car.GetSpeed() / 50;
                    for (int i = 0; i < NumberSpace; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(car.GetModel());
                    Console.WriteLine();
                    if (NumberSpace<finish)
                    {
                        Console.WriteLine("Победитель - " + car.GetModel());
                        return;
                    }
                    Console.WriteLine("===");

                }
                time++;

                Thread.Sleep(1000);
                Console.Clear();

            }
        }
        static void Main()
        {
            Car car = new Car();
            car.SetModel("Лада");
            car.SetSpeed(150);
            PrintMode(car);
            Car SecondCar = new Car();
            SecondCar.SetModel("Мерс");
            SecondCar.SetSpeed(300);
            PrintMode(SecondCar);

            List<Car> ListCars = new List<Car>();
            ListCars.Add(car);
            ListCars.Add(SecondCar);
            LadaVSMers(ListCars);

        }
    }
}
