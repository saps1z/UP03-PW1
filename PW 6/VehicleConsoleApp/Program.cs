using System;

namespace VehicleConsole
{
    class Vehicle {
        public string Name { get; private set; }
        public int MaxSpeed { get; private set; }

        public Vehicle( string name, int max_speed ) {
            Name = name;
            MaxSpeed = max_speed;
        }
    }

    class PolitechCar : Vehicle {
        public PolitechCar(string name, int max_speed) : base(name, max_speed) { }

        public void PlayBadMusicLoudly() {
            Console.WriteLine($"\"{Name}\" играет очень хайповую и молодёжную музыку под которую хочется зафлекси"); }
    }

    class Plane : Vehicle {
        public Plane(string name, int max_speed) : base(name, max_speed) { }

        public void DustTheField() {
            Console.WriteLine($"\"{Name}\" опыляет поле!");
        }
    }

    class ConcreteMixer : Vehicle
    {
        public ConcreteMixer( string name, int max_speed ) : base( name, max_speed ) { }

        public void MixConcrete( ) {
            Console.WriteLine( $"\"{Name}\" мешает бетон!" ); }
    }

    class Program {
        static void Main() {
            PolitechCar car = new PolitechCar(" Политех-машина 2022 ", 1);
            Plane plane = new Plane(" Самолёт ", 1000000);
            ConcreteMixer mixer = new ConcreteMixer(" Бетономешалка ", 78);

            car.PlayBadMusicLoudly();
            plane.DustTheField();
            mixer.MixConcrete();

            Console.ReadKey(true);
        }
    }
}