using System;

namespace MAGICIANREDD
{
    class Spell
    {
        public int Mana { get; private set; }

        public string Title { get; set; }
        private string Effect { get; set; }

        public Spell(int mana, string title, string effect)
        {
            Mana = mana;
            Title = title;
            Effect = effect;
        }

        public void Use()
        {
            Console.WriteLine(Effect);
        }
    }

    class Magician
    {
        public string Name { get; private set; }
        public int Mana { get; private set; }

        public Magician ( string name, int mana) { 
            Name = name;
            Mana = mana;
        }

        public void CastSpell( Spell spell )
        {
            if ( Mana >= spell.Mana ) {
                Console.Write(Name + " колдует! ");
                spell.Use();
                Mana -= spell.Mana;
            } else
            {
                Console.WriteLine(Name + " пытается использовать заклинание " + spell.Title);
                Console.WriteLine( "Для использования {0} не хватает {1} единиц маны. Хлебните зелья!", spell.Title, spell.Mana - Mana );
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Spell alohomora = new Spell( 60, "Алохомора", "Замок открывается!" );
            Spell vingardiumLeviosa = new Spell( 60, "Вингардиум Левиоса", "Предмет поднимается в воздух!" );

            Magician garryPotter = new Magician( "Гарри Поттер", 100 );

            garryPotter.CastSpell( alohomora );
            garryPotter.CastSpell( vingardiumLeviosa );

            Console.ReadKey( true );
        }
    }
}