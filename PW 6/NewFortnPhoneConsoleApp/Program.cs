using System;

namespace FortnPhoneConsole
{
    class Phone {
        public string Model { get; set; }
        public string Number { get; set; }

        public Phone( string model, string number ) {
            Model = model;
            Number = number;
        }

        public void Call( string number ) {
            Console.WriteLine( $"Вызов по номеру { number }") ;
            WriteToLog( $"Вызов { number }" );
        }

        protected void WriteToLog( string text ) {
            File.AppendAllText( "log.txt", $"{ Model }, { DateTime.Now }: { text }\n" );
        }

    }


    class Smartphone : Phone
    {

        public Smartphone( string model, string number, double cameraResolution ) : base( model, number ) {
            CameraResolution = cameraResolution;
        }

        public double CameraResolution { get; set; }

        public void Shoot( ) {
            Console.WriteLine( "Снимок сделан" );
            WriteToLog( $"Снимок сделан" );
        }

    }
    class Program {
        static void Main( ) {
            Smartphone speedrun = new Smartphone( "SUSPhone Fortnite Edition PUBG SE 18", "880055535355", 80.5 );

            speedrun.Call( "89999999998" );
            speedrun.Shoot( );

            Console.ReadKey( true );
        }
    }
}