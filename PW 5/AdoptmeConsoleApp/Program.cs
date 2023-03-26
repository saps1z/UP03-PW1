using System;

namespace AdoptmeConsole
{
    interface IAnimal
    {
        void Voice();
    }

    class Dog : IAnimal
    {
        public void Voice() { Console.WriteLine( "Гав!" ); }
    }

    class Cat : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Мяу!");
        }
    }

    class Elephant : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("*издаёт громкие слоновьи и мучительные для ушей звуки*");
        }
    }

    class Monkey : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Привет, как дела?");
        }
    }

    class Owl : IAnimal
    {
        private int GetCurrentTime( )
        {
            return 23; // Convert.ToInt32( File.ReadAllText( "current_time.txt" ) );
        }

        public void Voice()
        {
            int currentTime = GetCurrentTime( );

            if ( ( currentTime >= 8 ) && ( currentTime <= 21 ) ) {
                Console.WriteLine( "Тисе, я спю!" );
            } else
            {
                Console.WriteLine("Ух! Ух! Ух!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog tuzik = new Dog();
            PetAnimal( tuzik );

            Cat boris = new Cat();
            PetAnimal( boris );

            Owl hedwig = new Owl();
            PetAnimal( hedwig );

            Elephant ben = new Elephant();
            PetAnimal(ben);

            Monkey anton = new Monkey();
            PetAnimal(anton);

            Console.ReadKey( true );
        }

        static void PetAnimal( IAnimal animal )
        {
            Console.Write( "Мы гладим зверюшку, а она нам говорит: " );
            animal.Voice();
        }
    }
}