using System;
using System.Collections.Generic;

namespace Hackathon
{
    class Skills
    {
        //skills name
        public string skill_name { get; set; }
        //skills attribute
        public string skillAttribute { get; set; }
        public int skillNumericRequirement { get; set; }
        public int damage { get; set; }

        public Skills(string nameOfTheSkill, string AttributeRequirementOfTheSkill, int attributeLevelInNumbers)
        {
            skill_name = nameOfTheSkill;
            skillAttribute = AttributeRequirementOfTheSkill;
            skillNumericRequirement = attributeLevelInNumbers;
            damage = 10;
        }

    }
}



