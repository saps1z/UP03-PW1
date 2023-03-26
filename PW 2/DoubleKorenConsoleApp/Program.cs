using System;
using System.Security.Cryptography;

namespace DoubleKorenConsoleApplication
{
    // Класс квадратного уравнения
    class DoubleKoren
    {
        private double a, b, c, x1, x2;      // Создаём переменные квадратного уравнения

        private double Discriminante(  )        // Создаём приватный метод для вычисления дискрименанта
        {
            return b * b - 4 * a * c;           // Формула дискрименанта b^2 - 4ac
        }

        public void SetA( double a ) { this.a = a; }        // Глобальная функция для установки переменной a
        public void SetB( double b ) { this.b = b; }        // Глобальная функция для установки переменной b
        public void SetC( double c ) { this.c = c; }        // Глобальная функция для установки переменной c

        // Глобальная функция, вычисляющая корни уравнения x1 и x2
        public void CalculateRoots( )   
        {
            if ( (double)Discriminante() < 0 )                 // Если дискрименант меньше нуля, тогда выдаём ошибку о том, что уравнение не имеет корней
            {
                Console.WriteLine("D < 0  =>  Уравнение не имеет корней");
            }
            else if ( (double)Discriminante() == 0 )           // Но если дискрименант всё же равен нулю, даём решение только одного корня
            {
                x1 = -b / (2 * a);
                Console.WriteLine("D = 0  =>  Уравнение имеет один корень: X = " + x1);
            }
            else                                               // В других же случаях D > 0 мы проводим полное решение уравнения
            {
                x1 = ( -b + Math.Sqrt( (double)Discriminante() ) ) / ( 2 * a );
                x2 = ( -b - Math.Sqrt( (double)Discriminante() ) ) / ( 2 * a );

                Console.WriteLine("Корни уравнения: X1 = {0}, X2 = {1}", x1, x2);
            }
        }

        // Глобальные функции для получения переменных уравнения
        public double GetA( ) { return a; }             // Получаем коэффициент a
        public double GetB( ) { return b; }             // Получаем коэффициент b
        public double GetC( ) { return c; }             // Получаем коэффициент c
        public double GetX1( ) { return x1; }           // Получаем первый корень уравнения x1
        public double GetX2( ) { return x2; }           // Получаем второй корень уравнения  x2

    }

    // Класс самой программы
    class Program
    {
        static void Main()
        {
            // Выводим сообщение о том, что программа стартовала и отсупаем одну строку
            Console.WriteLine("РЕШАТЕЛЬ КВАДРАТНЫХ УРАВНЕНИЙ");
            Console.WriteLine();

            // Создаём объект решателя квадратного уравнения
            DoubleKoren Reshatel = new DoubleKoren();

            // Просим пользователя установить значение коэффициента a
            Console.Write("Введите значение коэффициента a: ");
            Reshatel.SetA( double.Parse(Console.ReadLine()) );

            // Просим пользователя установить значение коэффициента b
            Console.Write("Введите значение коэффициента b: ");
            Reshatel.SetB( double.Parse(Console.ReadLine()) );

            // Просим пользователя установить значение коэффициента c
            Console.Write("Введите значение коэффициента c: ");
            Reshatel.SetC( double.Parse(Console.ReadLine()) );

            // После установки значений отступаем одну строку и выдаём ответ
            Console.WriteLine();
            // Предварительно показываем значение переменных коэффициентов
            Console.WriteLine("Коэффициенты уравнения: A = " + Reshatel.GetA() + "; B = " + Reshatel.GetB() + "; C = " + Reshatel.GetC() );
            // Используя публичные методы получения значений, используя формулу, вычисляем значение дискрименанта
            Console.WriteLine("Дискрименант равен: D = " + ( Reshatel.GetB() * Reshatel.GetB() - 4 * Reshatel.GetA() * Reshatel.GetC() ) );
            // И решаем само уравнение
            Reshatel.CalculateRoots();

            // В конце просим пользователя нажать клавишу для завершения программы
            Console.ReadKey(true);
        }
    }
}