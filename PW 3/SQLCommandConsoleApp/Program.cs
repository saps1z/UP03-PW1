using System;

namespace SQLCommandConsole
{
    public class SQLCommand
    {
        private string _commandText;

        public string CommandText
        {
            get { return _commandText; }
            set { _commandText = value.ToUpper(); }
        }
    }

    public class Program
    {
        static void Main( )
        {
            SQLCommand cmd = new SQLCommand();
            cmd.CommandText = "select * from customers";

            Console.WriteLine( cmd.CommandText );

            Console.ReadKey( true );
        }
    }
}
