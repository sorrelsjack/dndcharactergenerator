using System.Collections.Generic;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterSubClasses
{
    public class WarCleric : ICharacterSubClass
    {
        public List<string> setArmorProf() => new List<string> { "Heavy armor" };

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Bonus Proficiencies", "-Gain proficiency with martial weapons and heavy armor" },
            { "War Priest", "-When using the Attack action, can make one weapon attack as a bonus action" }
        };

        public List<string> setLanguageProf() => null;

        public List<string> setSkillProf() => null;

        public List<string> setWeaponProf() => new List<string> { "Martial weapons" };
    }
}