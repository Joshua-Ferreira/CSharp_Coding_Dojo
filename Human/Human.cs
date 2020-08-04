using System;

namespace Human
{
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }
        public Human()
        {
            Name = "Initialize";
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        public Human(string name, int str = 3, int intell = 3, int dex = 3, int hp = 100)
        {
            Name = name;
            Strength = str;
            Intelligence = intell;
            Dexterity = dex;
            health = hp;
        }

        public void Attack(Human target)
        {
            int dmg = (int)(5 * Strength);
            target.health -= dmg;
            System.Console.WriteLine($"{Name} attacks {target.Name} for {dmg} damage. {target.Name} has {target.health} health remaining");
        }

    }
}