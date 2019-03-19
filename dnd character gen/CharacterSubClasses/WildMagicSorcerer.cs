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
            { "Wild Magic Surge", "Starting when you choose this origin at 1st level, your spellcasting can unleash surges of untamed magic. Immediately after you cast a sorcerer spell of 1st level or higher, the DM can have you roll a d20. If you roll a 1, roll on the Wild Magic Surge table to create a random magical effect." },
            { "Tides of Chaos", "Starting at 1st level, you can manipulate the forces of chance and chaos to gain advantage on one attack roll, ability check, or saving throw. Once you do so, you must finish a long rest before you can use this feature again." +
                "\nAny time before you regain the use of this feature, the DM can have you roll on the Wild Magic Surge table immediately after you cast a sorcerer spell of 1st level or higher. You then regain the use of this feature." }
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