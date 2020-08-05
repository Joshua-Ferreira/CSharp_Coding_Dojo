using System;
using System.Collections.Generic;

namespace Hackathon
{
    class Person
    {
        public string Name;
        public int Strength;
        public int Dexterity;
        public int Constitution;
        public int Intelligence;
        public int Wisdom;
        public int Charisma;
        public int Current_Health;
        private int max_health;
        public string Race;
        public string Role;
        public bool Alive;
        public int Max_Health
        {
            get { return this.max_health; }
            set { this.max_health = value; }
        }
        public List<Skills> Abilities;
        public Person(string name, string race, string role)
        {
            Name = name;
            Strength = 10;
            Dexterity = 10;
            Constitution = 10;
            Intelligence = 10;
            Wisdom = 10;
            Charisma = 10;
            max_health = 10 + Constitution;
            Current_Health = max_health;
            Race = race;
            Role = role;
            Alive = true;
            Abilities = new List<Skills>();
        }
        public Person(string nameyname, int crushTheApple, int grabTheApple, int eatTheBadApple, int knowingToNotEatTheBadApple, int recognizingABadApple, int GettingSomeoneElseToEatTheBadApple, string raceCard, string WaysInWhichTheyCanHelp)
        {
            Name = nameyname;
            Strength = crushTheApple;
            Dexterity = grabTheApple;
            Constitution = eatTheBadApple;
            Intelligence = knowingToNotEatTheBadApple;
            Wisdom = recognizingABadApple;
            Charisma = GettingSomeoneElseToEatTheBadApple;
            max_health = 10 + eatTheBadApple;
            Current_Health = max_health;
            Race = raceCard;
            Role = WaysInWhichTheyCanHelp;
            Alive = true;
            Abilities = new List<Skills>();
        }

        // public void learnANewSkill(Skills skills)
        // {
        //     Skills.addSkill(skills);
        // }
        public virtual void DisplayStats()
        {
            System.Console.WriteLine($"Name: {this.Name}");
            System.Console.WriteLine($"Strength: {this.Strength}");
            System.Console.WriteLine($"Dexterity: {this.Dexterity}");
            System.Console.WriteLine($"Constitution: {this.Constitution}");
            System.Console.WriteLine($"Intelligence: {this.Intelligence}");
            System.Console.WriteLine($"Wisdom: {this.Wisdom}");
            System.Console.WriteLine($"Charisma: {this.Charisma}");
            System.Console.WriteLine($"Max Health: {this.max_health}");
            System.Console.WriteLine($"Current Health: {this.Current_Health}");
            System.Console.WriteLine($"Race: {this.Race}");
            System.Console.WriteLine($"Role: {this.Role}");
            System.Console.WriteLine($"Alive: {this.Alive}");
            foreach (Skills AbilityName in this.Abilities)
            {
                System.Console.WriteLine($"Abilities: {AbilityName.skill_name}");
            }
        }

        //Player1.addSkill(Bash);
        public virtual void addSkill(Skills Subject)
        {
            string AttributeName = Subject.skillAttribute;
            bool CanLearn = false;
            switch (AttributeName)
            {
                case "Strength":
                    if (this.Strength >= Subject.skillNumericRequirement)
                    {
                        CanLearn = true;
                    }
                    break;
                case "Dexterity":
                    if (this.Dexterity >= Subject.skillNumericRequirement)
                    {
                        CanLearn = true;
                    }
                    break;
                case "Constitution":
                    if (this.Constitution >= Subject.skillNumericRequirement)
                    {
                        CanLearn = true;
                    }
                    break;
                case "Intelligence":
                    if (this.Intelligence >= Subject.skillNumericRequirement)
                    {
                        CanLearn = true;
                    }
                    break;
                case "Wisdom":
                    if (this.Wisdom >= Subject.skillNumericRequirement)
                    {
                        CanLearn = true;
                    }
                    break;
                case "Charisma":
                    if (this.Charisma >= Subject.skillNumericRequirement)
                    {
                        CanLearn = true;
                    }
                    break;
                default: break;
            }
            if (CanLearn)
            {
                this.Abilities.Add(Subject);
            }
            else
            {
                System.Console.WriteLine($"You don't meet the requirments to gain this skill.  The Skill requires {Subject.skillAttribute} level of {Subject.skillNumericRequirement}.");
            }
        }
        public string UseSkill(Skills skill, Person target)
        {
            // Skills skill = this.Abilities[idx];
            if (!this.Alive)
            {
                return "You are dead.  You cannot perform any actions.";
            }
            string type = skill.skillAttribute;
            int level = 0;
            switch (type)
            {
                case "Strength":
                    level = this.Strength;
                    break;
                case "Dexterity":
                    level = this.Dexterity;
                    break;
                case "Constitution":
                    level = this.Constitution;
                    break;
                case "Intelligence":
                    level = this.Intelligence;
                    break;
                case "Wisdom":
                    level = this.Wisdom;
                    break;
                case "Charisma":
                    level = this.Charisma;
                    break;
                default: break;
            }
            int modifier = Skill_Check(level);
            if (this.Abilities.Contains(skill))
            {
                int StartingHealth = target.Current_Health;
                target.Current_Health -= skill.damage + modifier;
                if (target.Current_Health < 1)
                {
                    target.Alive = false;
                    System.Console.WriteLine($"{target.Name} has been killed.  Thoughts and prayers.");
                }
                return ($"{target.Name} got fucked up. Their health went from {StartingHealth} to {target.Current_Health}");
            }

            else
            {
                return ("Girls only like guys that have great skills");
            }

        }
        public int Skill_Check(int level = 0)
        {
            Random rand = new Random();
            if (level >= 20)
            {
                return 5;
            }
            else if (level == 19 || level == 18)
            {
                return 4;
            }
            else if (level == 17 || level == 16)
            {
                return 3;
            }
            else if (level == 15 || level == 14)
            {
                return 2;
            }
            else if (level == 13 || level == 12)
            {
                return 1;
            }
            else if (level == 11 || level == 10)
            {
                return 0;
            }
            else if (level == 9 || level == 8)
            {
                return -1;
            }
            else if (level == 7 || level == 6)
            {
                return -2;
            }
            else if (level == 5 || level == 4)
            {
                return -3;
            }
            else if (level == 3 || level == 2)
            {
                return -4;
            }
            else
            {
                return -5;
            }
        }
    }
}