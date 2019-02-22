using System;
using System.Collections.Generic;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterSubClasses
{
    public class ProtectionFighter : ICharacterSubClass
    {
        public List<string> setArmorProf()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Protection", "-When a seeable creature attacks a target other than self within 5 ft, can use reaction to impose disadvantage on the attack roll. Must be wielding a shield" }
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