using System;
using System.Collections.Generic;

namespace IFilterConsole
{
    interface IFilter
    {
        string Execute(string textLine);
    }

    class DigitFilter : IFilter
    {
        public string Execute(string textLine)
        {
            string result = "";
            foreach (char c in textLine)
            {
                if (!Char.IsDigit(c))
                {
                    result += c;
                }
            }
            return result;
        }
    }

    class LetterFilter : IFilter
    {
        public string Execute(string textLine)
        {
            string result = "";
            foreach (char c in textLine)
            {
                if (!Char.IsLetter(c))
                {
                    result += c;
                }
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<IFilter> filters = new List<IFilter>();
            filters.Add(new DigitFilter());
            filters.Add(new LetterFilter());

            Console.Write("Введите текст, который нужно отфильтровать: ");
            string input = Console.ReadLine();

            foreach (IFilter filter in filters)
            {
                string output = filter.Execute(input);
                Console.WriteLine("Текст с фильтром {0}: {1}", filter.GetType().Name, output);
            }

            Console.ReadKey(true);
        }
    }
}
