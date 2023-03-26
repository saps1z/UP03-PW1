using System;
using System.Collections.Generic;

namespace WarcraftConsole
{
    class Orc
    {
        public static int TotalGold { get; private set; }
        public int Gold { get; private set; }

        public Orc()
        {
            Gold = 0;
            TotalGold += 2;
            if (TotalGold > 10)
            {
                Gold -= 2;
                TotalGold -= 2;
            }
        }

        public void StealGold()
        {
            if (TotalGold > 0)
            {
                Gold += 2;
                TotalGold -= 2;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Orc> orcs = new List<Orc>();

            for (int i = 1; i <= 10; i++)
            {
                orcs.Add(new Orc());
                Console.WriteLine($"Орк {i} имеет {orcs[i - 1].Gold} золота");
            }

            Console.WriteLine($"Всего золота: {Orc.TotalGold}");

            Console.WriteLine("Крадём золото...");
            for (int i = 0; i < orcs.Count; i++)
            {
                orcs[i].StealGold();
                Console.WriteLine($"Орк {i + 1} имеет {orcs[i].Gold} золота");
            }

            Console.WriteLine($"Всего золота: {Orc.TotalGold}");

            Console.ReadKey( true );
        }
    }
}

