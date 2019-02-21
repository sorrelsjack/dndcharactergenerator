using System;
using System.Collections.Generic;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterSubClasses
{
    public class LightCleric : ICharacterSubClass
    {
        public List<string> setArmorProf() => null;

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>()
        {
            { "Bonus Cantrip", "-Gain Light cantrip" },
            { "Warding Flare", "-If attacked by a creature within 30 ft, can use reaction to impose disadvantage on the attack roll" }
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