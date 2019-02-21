using System;
using System.Collections.Generic;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterSubClasses
{
    public class TempestCleric : ICharacterSubClass
    {
        public List<string> setArmorProf() => new List<string> { "Heavy armor" };

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>()
        {
            { "Bonus Proficiencies", "-Gain proficiency with martial weapons and heavy armor" },
            { "Wrath of the Storm", "-When creature within 5 ft attacks you, can use reaction to make it make a Dexterity saving throw. On failure, it takes 2d8 lighting or thunder damage. On success, half that." }
        };

        public List<string> setLanguageProf() => null;

        public string setName()
        {
            throw new NotImplementedException();
        }

        public List<string> setSkillProf() => null;

        public List<string> setWeaponProf() => new List<string> { "Martial weapons" };
    }
}