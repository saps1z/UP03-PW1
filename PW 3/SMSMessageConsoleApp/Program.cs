using System;

namespace SMSMessager
{
    class SmsMessage
    {
        private string message_text = "";
        private double price = 1.5;

        public string MessageText
        {
            get { return message_text; }
            set { message_text = MessageChecker( value ); }
        }

        public double Price
        {
            get { return price; }
            set { price = PriceCount( value ); }
        }

        public SmsMessage() { }

        public SmsMessage( string message_text, double price )
        {
            MessageText = message_text;
            Price = price;
        }

        public void DisplayMessage ( ) { 
            Console.WriteLine( "Текст сообщения: " + MessageText );
            Console.WriteLine( "Стоимость: {0} рублей", Price );
        }

        private string MessageChecker( string message_text ) { 
            if ( message_text.Length > 250 ) { message_text = message_text.Substring( 0, 250 ); }
            return message_text;
        }

        private double PriceCount( double price )
        {
            if ( message_text.Length > 65 ) { price = price + ( message_text.Length - 65) * 0.5; }
            return price;
        }
    }

    class Program
    {
        static void Main()
        {
            SmsMessage message_tiny = new SmsMessage( "Это короткое сообщение менее 65 символов.", 1.5 );
            message_tiny.DisplayMessage();
            Console.WriteLine();

            SmsMessage message_large = new SmsMessage( "Это довольно длинное сообщение, которое превышает лимит в 65 символов и соответственно стоит больше!", 1.5);
            message_large.DisplayMessage();
            Console.WriteLine();

            SmsMessage message_huge = new SmsMessage( "А это уже сообщение настолько длинное, что его придётся обрезать самой программой до тех пор, пока количество символов в этом сообщении не будет состовлять менее 250 символов и не выйдет за пределы экрана, или что ещё хуже интерфейса, чтобы код стало неудобно читать.", 1.5);
            message_huge.DisplayMessage();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
