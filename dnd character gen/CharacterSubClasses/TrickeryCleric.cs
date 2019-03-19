using System.Collections.Generic;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterSubClasses
{
    public class TrickeryCleric : ICharacterSubClass
    {
        public List<string> setArmorProf() => null;

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>()
        {
            { "Blessing of the Trickster", "Starting when you choose this domain at 1st level, you can use your action to touch a willing creature other than yourself to give it advantage on Dexterity (Stealth) checks. This blessing lasts for 1 hour or until you use this feature again." }
        };

        public List<string> setLanguageProf() => null;

        public List<string> setSkillProf() => null;

        public List<string> setWeaponProf() => null;
    }
}