using System;

namespace HumanConsole {
    class Human {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Human( string name, int age, string gender ) {
            Name = name;
            Age = age;
            Gender = gender;
        }
    }

    class Rabotnik : Human {
        public string Position { get; set; }
        public Rabotnik( string name, int age, string gender, string position ) : base( name, age, gender ) { Position = position; }
    }

    class Program {
        static void Main( ) {
            Human oleg = new Human( "Олег", 21, "Мужской" );
            Rabotnik anton = new Rabotnik( "Антон", 18, "Мужской", "Блогер" );

            Console.WriteLine( "Человек:" );
            Console.WriteLine();
            Console.WriteLine( $"Имя: {oleg.Name}" );
            Console.WriteLine( $"Возраст: {oleg.Age}" );
            Console.WriteLine( $"Пол: {oleg.Gender}" );

            Console.WriteLine( "________________________________________________________" );
            Console.WriteLine();

            Console.WriteLine( "Работник:" );
            Console.WriteLine( );
            Console.WriteLine( $"Имя: {anton.Name}" );
            Console.WriteLine( $"Возраст: {anton.Age}" );
            Console.WriteLine( $"Пол: {anton.Gender}" );
            Console.WriteLine( $"Должность: {anton.Position}" );

            Console.ReadKey();
        }
    }
}