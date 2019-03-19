using System.Collections.Generic;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterSubClasses
{
    public class WarCleric : ICharacterSubClass
    {
        public List<string> setArmorProf() => new List<string> { "Heavy armor" };

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Bonus Proficiencies", "At 1st level, you gain proficiency with martial weapons and heavy armor." },
            { "War Priest", "From 1st level, your god delivers bolts of inspiration to you while you are engaged in battle. When you use the Attack action, you can make one weapon attack as a bonus action." +
                "\nYou can use this feature a number of times equal to your Wisdom modifier (a minimum of once). You regain all expended uses when you finish a long rest." }
        };

        public List<string> setLanguageProf() => null;

        public List<string> setSkillProf() => null;

        public List<string> setWeaponProf() => new List<string> { "Martial weapons" };
    }
}