using System.Collections.Generic;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterSubClasses
{
    public class NatureCleric : ICharacterSubClass
    {
        public List<string> setArmorProf() => new List<string> { "Heavy armor" };

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>()
        {
            { "Acolyte of Nature", "At 1st level, you learn one cantrip of your choice from the druid spell list. You also gain proficiency in one of the following skills of your choice: Animal Handling, Nature, or Survival." },
            { "Bonus Proficiency", "Also at 1st level, you gain proficiency with heavy armor." }
        };

        public List<string> setLanguageProf() => null;

        public List<string> setSkillProf()
        {
            List<string> skillProficiencies = new List<string>();
            List<string> availableSkills = new List<string>() { "Animal Handling", "Nature", "Survival" };

            string skill = availableSkills[NumberGen.gen(3)];
            skillProficiencies.Add(skill);
            availableSkills.Remove(skill);

            skill = availableSkills[NumberGen.gen(2)];
            skillProficiencies.Add(skill);

            return skillProficiencies;
        }

        public List<string> setWeaponProf() => null;
    }
}