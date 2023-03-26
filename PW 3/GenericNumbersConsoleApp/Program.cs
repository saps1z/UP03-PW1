using System;
using System.Collections.Generic;

namespace GenericNumbersConsole
{
    public class GenericNumbers
    {
        private List<int> _numbers = new List<int>();
        private double? _mean = null;
        private double? _variance = null;
        private double? _stdDev = null;
        private int? _median = null;

        public GenericNumbers(int length)
        {
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                _numbers.Add(rand.Next(1, 101)); // генерируем случайное число от 1 до 100
            }
        }

        public string GetNumbers()
        {
            string numstemp = "";

            foreach (int number in _numbers)
            {
                numstemp += number + ", ";
            }

            return numstemp;
        }

        public double GetMean()
        {
            if (_mean == null)
            {
                _mean = _numbers.Average();
            }
            return _mean.Value;
        }

        public double GetVariance()
        {
            if (_variance == null)
            {
                double mean = GetMean();
                _variance = _numbers.Sum(num => Math.Pow(num - mean, 2)) / (_numbers.Count - 1);
            }
            return _variance.Value;
        }

        public double GetStandardDeviation()
        {
            if (_stdDev == null)
            {
                _stdDev = Math.Sqrt(GetVariance());
            }
            return _stdDev.Value;
        }

        public int GetMedian()
        {
            if (_median == null)
            {
                _numbers.Sort();
                int middle = _numbers.Count / 2;
                if (_numbers.Count % 2 == 0)
                {
                    _median = (int)Math.Round((double)(_numbers[middle - 1] + _numbers[middle]) / 2);
                }
                else
                {
                    _median = _numbers[middle];
                }
            }
            return _median.Value;
        }
    }

    class Program
    {
        static void Main( )
        {
            while (true)
            {
                GenericNumbers numbers = new GenericNumbers(10);

                Console.WriteLine($"Список чисел: {numbers.GetNumbers()}");
                Console.WriteLine();
                Console.WriteLine($"Среднее арифметическое: {numbers.GetMean()}");
                Console.WriteLine($"Дисперсия: {numbers.GetVariance()}");
                Console.WriteLine($"Среднеквадратичное отклонение: {numbers.GetStandardDeviation()}");
                Console.WriteLine($"Медиана: {numbers.GetMedian()}");
                Console.WriteLine();

                Console.WriteLine("Нажмите любую клавишу, чтобы сгенерировать новый набор чисел");
                Console.ReadKey(true);
                Console.WriteLine();
            }
        }
    }
}
