using System;

namespace IShareConsole
{
    public interface IShare
    {
        void Draw(int size);
    }

    public class VerticalLine : IShare
    {
        public void Draw(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("|");
            }
        }
    }

    public class HorizontalLine : IShare
    {
        public void Draw(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("--");
            }
            Console.WriteLine();
        }
    }

    public class Square : IShare
    {
        public void Draw(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("[]");
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IShare[] shares = { new VerticalLine(), new HorizontalLine(), new Square() };

            foreach (IShare share in shares)
            {
                share.Draw(7);
                Console.WriteLine();
            }

            Console.ReadKey(true);
        }
    }
}
