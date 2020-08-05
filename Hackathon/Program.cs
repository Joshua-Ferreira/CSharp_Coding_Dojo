using System;
using System.Collections.Generic;

namespace Hackathon
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person Brandon new Person(name = "Brandon", race = "Human", "Fighter");
            Fighter Player1 = new Fighter("Brandon", "Orc", "Fighter");
            Wizard Player2 = new Wizard("Joe", "Elf", "Wizard");
            Rogue Player3 = new Rogue("Josh", "Dwarf", "THE OG ROUGE");
            Wizard Player4 = new Wizard("Kristin", "Human", "Wizard");
            Player1.DisplayStats();
            System.Console.WriteLine("\n");
            Player2.DisplayStats();
            System.Console.WriteLine("\n");
            Player3.DisplayStats();
            System.Console.WriteLine("\n");
            Player4.DisplayStats();
            System.Console.WriteLine("\n");
            Skills Bash = new Skills("Bash", "Strength", 15);
            Skills Fireball = new Skills("Fireball", "Intelligence", 15);
            Skills Stab = new Skills("Stab", "Dexterity", 15);
            Player1.addSkill(Bash);
            Player1.addSkill(Fireball);
            Player2.addSkill(Fireball);
            Player3.addSkill(Stab);
            System.Console.WriteLine("\n");
            Player1.DisplayStats();
            System.Console.WriteLine("\n");
            System.Console.WriteLine(Player1.UseSkill(Bash, Player2));
            System.Console.WriteLine(Player2.UseSkill(Fireball, Player1));
            System.Console.WriteLine(Player3.UseSkill(Stab, Player1));
            System.Console.WriteLine(Player1.UseSkill(Bash, Player2));
            System.Console.WriteLine(Player2.UseSkill(Fireball, Player1));
            System.Console.WriteLine("\n");
            Player2.DisplayStats();
        }
    }
}
