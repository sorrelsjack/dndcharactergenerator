using System.Collections.Generic;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterSubClasses
{
    public class TempestCleric : ICharacterSubClass
    {
        public List<string> setArmorProf() => new List<string> { "Heavy armor" };

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>()
        {
            { "Bonus Proficiencies", "At 1st level, you gain proficiency with martial weapons and heavy armor." },
            { "Wrath of the Storm", "Also at 1st level, you can thunderously rebuke attackers. When a creature within 5 feet of you that you can see hits you with an attack, you can use your reaction to cause the creature to make a Dexterity saving throw. The creature takes 2d8 lightning or thunder damage (your choice) on a failed saving throw, and half as much damage on a successful one." +
                "\nYou can use this feature a number of times equal to your Wisdom modifier (a minimum of once). You regain all expended uses when you finish a long rest." }
        };

        public List<string> setLanguageProf() => null;

        public List<string> setSkillProf() => null;

        public List<string> setWeaponProf() => new List<string> { "Martial weapons" };
    }
}