using System;
using System.Timers;
using System.Threading;

namespace RaceConsoleApp
{
    // Класс Машина
    class Car
    {
        public string BrandName = "";   // Бренд и модель Машины
        public double MaxSpeed;         // Максимальная скорость

        // Функция для просмотра характеристик транспорта
        public void CarInfo()
        {
            Console.WriteLine("{0}   Максимальная скорость составляет: {1}", BrandName, MaxSpeed);
        }
    }
    class Program
    {
        static void Main()
        {
            Car[] cars = new Car[ 4 ];      // Создаём массив, содержащий в себе порядковые номера машин

            Car car_camaro = new Car();                 // Создаём первую машину и придаём значения её характеристикам
            car_camaro.BrandName = "Шевроле Камаро";
            car_camaro.MaxSpeed = 250;
            cars[0] = car_camaro;                       // Задаём изначальный номер в массиве

            Car car_granta = new Car();                 // Создаём вторую машину и так же придаём значения её характеристикам
            car_granta.BrandName = "Лада Гранта";       
            car_granta.MaxSpeed = 184;
            cars[1] = car_granta;                       // И тоже задаём изначальный номер в массиве

            Car car_m3 = new Car();                     // Третья машина
            car_m3.BrandName = "БМВ М3";
            car_m3.MaxSpeed = 300;
            cars[2] = car_m3;           

            Car car_sl500 = new Car();                  // Четвёртая
            car_sl500.BrandName = "Мерседес СЛ500";
            car_sl500.MaxSpeed = 250;
            cars[3] = car_sl500;

            // Выводим информацию о машинах при запуске приложения
            cars[0].CarInfo();
            cars[1].CarInfo();
            cars[2].CarInfo();
            cars[3].CarInfo();

            Console.WriteLine();
            Console.Write("Введите дистанцию трассы: ");                // Просим Пользователя указать длину дистанции ( правда нужды в этом особо нет, но лучше указать )
            double Distance = double.Parse(Console.ReadLine());
            Console.WriteLine("Нажмите, чтобы начать гонки!");          // Просим Пользователя ещё раз нажать на клавишу, чтобы гонка началась
            Console.ReadKey(true);
            Console.WriteLine("Гонка началачь! Дистанция: " + Distance + " метров");

            // В этом цикле мы сортируем массив cars таким образом, чтобы их порядковый номер зависел от их максимальной скорости
            for (int i = 0; i < cars.Length - 1; i++)
            {
                for (int j = 0; j < cars.Length - i - 1; j++)
                {
                    Car[] sorting = new Car[cars.Length];
                    if (cars[j].MaxSpeed < cars[j + 1].MaxSpeed)
                    {
                        sorting[j] = cars[j];
                        cars[j] = cars[j + 1];
                        cars[j + 1] = sorting[j];
                    }
                }
            }

            // Делаем некоторую задержку, чтобы задать атмосферу происходящего
            for (int i = 0; i < 48; i++)
            {
                Thread.Sleep(100);
                Console.Write(".");
            }
            Console.WriteLine();
            Console.WriteLine("Гонка окончена! Результаты гонки: ");
            Console.WriteLine();

            // Выводим таблицу результатов после окончания заезда
            for (int i = 0; i < cars.Length; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine( i+1 + "-е место) " + cars[i].BrandName );
            }

            // И напоследок ещё раз просим Пользователя нажать клавишу для выхода из консоли
            Console.ReadKey(true);
        }
    }
}

