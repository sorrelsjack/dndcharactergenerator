using System;
using System.Collections.Generic;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterSubClasses
{
    public class LifeCleric : ICharacterSubClass
    {
        public List<string> setArmorProf() => new List<string> { "Heavy armor" };

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Disciple of Life", "-When using a spell of 1st level or higher to restore HP, the target gets additional HP equal to 2 + the spell's level" }
        };

        public List<string> setLanguageProf() => null;

        public string setName()
        {
            throw new NotImplementedException();
        }

        public List<string> setSkillProf() => null;

        public List<string> setWeaponProf() => null;
    }
}