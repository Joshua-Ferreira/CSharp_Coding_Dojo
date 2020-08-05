using System;
using System.Collections.Generic;

namespace Hackathon
{
    class Fighter : Person
    {
        public Fighter(string name, string race, string role) : base(name, race, role)
        {
            if (race == "Human")
            {
                Strength = 15;
                Dexterity = 15;
                Constitution = 15;
                Intelligence = 15;
                Wisdom = 15;
                Charisma = 15;
                Max_Health = 15 + Constitution;
                Current_Health = Max_Health;
            }
            if (race == "Elf")
            {
                Intelligence = 20;
                Charisma = 20;
            }
            if (race == "Dwarf")
            {
                Dexterity = 20;
                Wisdom = 20;
                Max_Health = 15 + Constitution;
                Current_Health = Max_Health;
            }
            if (race == "Orc")
            {
                Strength = 20;
                Constitution = 20;
                Max_Health = 20 + Constitution;
                Current_Health = Max_Health;
            }
        }
        public override void DisplayStats()
        {
            base.DisplayStats();
        }
    }

    class Wizard : Person
    {
        public Wizard(string name, string race, string role) : base(name, race, role)
        {
            if (race == "Human")
            {
                Strength = 15;
                Dexterity = 15;
                Constitution = 15;
                Intelligence = 15;
                Wisdom = 15;
                Charisma = 15;
                Max_Health = 15 + Constitution;
                Current_Health = Max_Health;
            }
            if (race == "Elf")
            {
                Intelligence = 20;
                Charisma = 20;
            }
            if (race == "Dwarf")
            {
                Dexterity = 20;
                Wisdom = 20;
                Max_Health = 15 + Constitution;
                Current_Health = Max_Health;
            }
            if (race == "Orc")
            {
                Strength = 20;
                Constitution = 20;
                Max_Health = 20 + Constitution;
                Current_Health = Max_Health;
            }
        }
        public override void DisplayStats()
        {
            base.DisplayStats();
        }
    }

    class Rogue : Person
    {
        public Rogue(string name, string race, string role) : base(name, race, role)
        {
            if (race == "Human")
            {
                Strength = 15;
                Dexterity = 15;
                Constitution = 15;
                Intelligence = 15;
                Wisdom = 15;
                Charisma = 15;
                Max_Health = 15 + Constitution;
                Current_Health = Max_Health;
            }
            if (race == "Elf")
            {
                Intelligence = 20;
                Charisma = 20;
            }
            if (race == "Dwarf")
            {
                Dexterity = 20;
                Wisdom = 20;
                Max_Health = 15 + Constitution;
                Current_Health = Max_Health;
            }
            if (race == "Orc")
            {
                Strength = 20;
                Constitution = 20;
                Max_Health = 20 + Constitution;
                Current_Health = Max_Health;
            }
        }
        public override void DisplayStats()
        {
            base.DisplayStats();
        }
    }
}


