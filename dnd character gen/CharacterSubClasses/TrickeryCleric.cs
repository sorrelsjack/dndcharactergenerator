using System;
using System.Collections.Generic;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterSubClasses
{
    public class TrickeryCleric : ICharacterSubClass
    {
        public List<string> setArmorProf() => null;

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>()
        {
            { "Blessing of the Trickster", "-Can use action to touch a willing creature other than self to give it advantage of Dexterity checks. Lasts 1 hour." }
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