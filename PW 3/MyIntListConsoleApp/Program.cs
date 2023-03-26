using System;

namespace MyIntListConsole
{
    class MyIntList
    {
        private List<int> numberList = new List<int>();

        public double Average
        {
            get { return CalculateAverage(); }
            set { CalculateAverage(); }
        }

        public void AddNumber( int number )
        {
            numberList.Add( number );
        }

        public void RemoveNumber( int number ) { 
            numberList.Remove( number );
        }

        public double CalculateAverage( ) {
            int sum = 0;

            foreach( int number in numberList )
            {
                sum += number;
            }

            return sum / ( double ) numberList.Count;

        }
    }

    class Program
    {
        static void Main()
        {
            MyIntList numbers = new MyIntList();
            numbers.AddNumber( 1 );
            numbers.AddNumber( 2 );
            numbers.AddNumber( 8 );

            double sum = numbers.Average * 21;

            Console.WriteLine( numbers.Average );
            Console.WriteLine( sum );

            Console.ReadKey( true );
        }
    }
}