using System;
using System.Collections.Generic;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterSubClasses
{
    public class DuelingFighter : ICharacterSubClass
    {
        public List<string> setArmorProf()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Dueling", "-While wielding a melee weapon in one hand with no other weapons, gain a +2 bonus to damage rolls with that weapon" }
        };

        public List<string> setLanguageProf()
        {
            throw new NotImplementedException();
        }

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