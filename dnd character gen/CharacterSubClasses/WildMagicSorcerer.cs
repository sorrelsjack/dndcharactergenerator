using System;
using System.Collections.Generic;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterSubClasses
{
    public class WildMagicSorcerer : ICharacterSubClass
    {
        public List<string> setArmorProf()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Wild Magic Surge", "-Immediately after casting a sorcerer spell of 1st level or higher, DM can have you roll a d20\n-Rolling a 1 results in a Wild Magic Surge" },
            { "Tides of Chaos", "-Can gain advantage on one attack roll, ability check, or saving throw\n-Only once per long rest" +
                                "\n-Any time before the use of this feature is regained, can result in a Wild Magic Surge roll after " +
                                "casting a sorcrerer spell 1st level or higher -- regain use of this feature afterwards" }
        };

        public List<string> setLanguageProf() => null;

        public List<string> setSkillProf()
        {
            throw new NotImplementedException();
        }

        public List<string> setWeaponProf()
        {
            throw new NotImplementedException();
        }
    }
}