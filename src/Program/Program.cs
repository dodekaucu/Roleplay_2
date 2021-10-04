using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.Staff = new Staff();
            gandalf.SpellsBook = book;

            Orcos ragnar = new Orcos("Ragnar",1500);
            IElemento item = new Axe();
            ragnar.AddElemento(item);
            item = new Shield();
            ragnar.AddElemento(item);

            Dwarf gimli = new Dwarf("Gimli");
            item = new Axe();
            gimli.AddElemento(item);
            item = new Shield();
            gimli.AddElemento(item);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
        }
    }
}
