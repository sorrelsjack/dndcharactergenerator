using System.Collections.Generic;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterSubClasses
{
    public class NatureCleric : ICharacterSubClass //TODO: nature cleric
    {
        public List<string> setArmorProf() => new List<string> { "Heavy armor" };

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>()
        {
            { "Acolyte of Nature", "-Learn one Druid cantrip\n-Gain proficiency in one of the following: Animal Handling, Nature, Survival" },
            { "Bonus Proficiency", "-Proficiency with heavy armor" }
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