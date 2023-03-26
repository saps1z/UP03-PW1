using System;

namespace CaesarCipherConsole
{
    // Создаём класс Шифр Цезаря, к которому мы и будем обращаться
    class CaesarCipher
    {
        // Метод зашифровки строки
        public string Encryption( string input, int key )
        {
            string result = string.Empty;       // Создаём локальную переменную строку и присваеваем ей пустое значение
                                                // чтобы компилятор не выдавал ошибки
            foreach ( char symbol in input )    // Запускаем цикл перебирающие все символы в строке
            {
                if ( char.IsLetter( symbol ) )
                {
                    char shiftedSymbol = ( char ) ( ( ( symbol - 'A' ) + key ) % 26 + 'A' );    // Формула, по которой происходит сдвиг букв
                    result += shiftedSymbol;
                }
                else
                {
                    result += symbol;
                }
            }

            return result;          // Получаем нашу обработанную строку
        }

        // Метод расшифровки строки, делаем буквально тоже самое, что и при шифровке, но меняем формулу
        public string Decryption( string input, int key )
        {
            string result = string.Empty;

            foreach ( char symbol in input )
            {
                if ( char.IsLetter( symbol ) )
                {
                    char shiftedSymbol = ( char ) ( ( ( symbol - 'A' ) - key + 26 ) % 26 + 'A' );
                    result += shiftedSymbol;
                }
                else
                {
                    result += symbol;
                }
            }

            return result;
        }
    }

    // Класс самой программы
    class Program
    {
        static void Main()
        {
            CaesarCipher cipher = new CaesarCipher();   // Создаём новый объект CaesarCipher
            string inputString;                         // Переменная, в которой будет хранится наша строка
            int key;                                    // Переменная, где мы указываем кол-во символов для сдвига

            // С запуском программы, выдаём информацию
            Console.WriteLine( "Добро пожаловать в программу, способную" );
            Console.WriteLine( "шифровать и расшифровывать строки шифром Цезаря !" );
            Console.WriteLine();

            // Цикл, где наш код будет повторяться, чтобы Пользователю было удобнее шифровать строки
            while (true)
            {
                // Цикл, где мы проверяем нашу строку
                while (true)
                {
                    Console.Write("Введите текст: ");       // Просим ввести тескт
                    inputString = Console.ReadLine();       // Считываем строку и записываем в переменную inputString

                    // Если строка пуста
                    if (inputString == string.Empty)
                    {
                        // Выводим текст о том, что такого допускать нельзя
                        Console.WriteLine("Строка не может быть пустой! Пожалуйста, введите текст");
                    }
                    // Если строка имеет текст
                    else
                    {
                        break;      // Значит всё хорошо и мы можем покинуть цикл
                    }
                }

                // Цикл, лимитирующий ошибочные действия Пользователя
                while (true)
                {
                    Console.Write("Введите число ( от 1 до 25 ), которое послужит ключём шифрования: ");        // Просим Пользователя ввести число от 1 до 25
                    key = int.Parse(Console.ReadLine());                                                        // Считываем это число и записываем в переменную key

                    // Если ключ привысил лимит, то выдаём ошибку
                    if (key > 25)
                    {
                        Console.WriteLine("Английский алфавит содержит 26 букв!");
                        Console.WriteLine("Шифр Цезаря в этом случае может сдвинуть буквы только на 25 позиций...");
                    }
                    // Если ключ равен 0, делаем тоже самое
                    else if (key == 0)
                    {
                        Console.WriteLine("Нулевой буквы не существует");
                    }
                    // Если ключ отрицательный, тоже выдаём ошибку
                    else if (key < 0)
                    {
                        Console.WriteLine("Отрицательные цифры писать нельзя");
                    }
                    // Если всё нормально, делаем выход из цикла
                    else { break; }
                }

                // Показываем зашифрованную строку
                string encryptedString = cipher.Encryption(inputString, key);
                Console.WriteLine("Зашифрованная строка: " + encryptedString);

                // Показываем расшифрованную строку
                string decryptedString = cipher.Decryption(encryptedString, key);
                Console.WriteLine("Расшифрованная строка: " + decryptedString);

                // Делаем отступ в одну строку
                Console.WriteLine();
                // И повторяем цикл
            }
        }
    }
}
