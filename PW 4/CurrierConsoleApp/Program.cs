using System;

namespace CurrierConsole
{
    class Package
    {
        public string Description { get; }
        public double Weight { get; }

        public Package(string description, double weight)
        {
            Description = description;
            Weight = weight;
        }
    }

    class ShippingService
    {
        private double _totalWeight = 0.0;
        private readonly double _weightLimit;

        public ShippingService(double weightLimit)
        {
            _weightLimit = weightLimit;
        }

        public void SendPackage(Package package)
        {
            if (_totalWeight + package.Weight > _weightLimit)
            {
                Console.WriteLine("!! Превышен лимит веса отправленных посылок. !!");
                Console.WriteLine($"Отправка посылки \"{package.Description}\" отменена.");
                return;
            }

            Console.WriteLine($"Посылка \"{package.Description}\" отправлена.");
            _totalWeight += package.Weight;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double weightLimit = 10.0;
            ShippingService shippingService = new ShippingService(weightLimit);

            Package package1 = new Package("Книга", 2.5);
            Package package2 = new Package("Игрушка", 1.2);
            Package package3 = new Package("Холодильник", 25.0);
            Package package4 = new Package("Мобильник", 0.8);
            Package package5 = new Package("Портативный компьютер", 7.6);

            shippingService.SendPackage(package1);
            shippingService.SendPackage(package2);
            shippingService.SendPackage(package3);
            shippingService.SendPackage(package4);
            shippingService.SendPackage(package5);

            Console.ReadKey(true);
        }
    }
}
