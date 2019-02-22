using System;
using System.Collections.Generic;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterSubClasses
{
    public class GreatWeaponFightingFighter : ICharacterSubClass
    {
        public List<string> setArmorProf()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Great Weapon Fighting", "-In the case of a 1 or 2 on a damage die roll made with a melee weapon held with two hands, can reroll and use new roll. Weapon must be two-handed or have the versatile property" }
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