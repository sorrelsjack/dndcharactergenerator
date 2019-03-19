using System.Collections.Generic;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterSubClasses
{
    public class LightCleric : ICharacterSubClass
    {
        public List<string> setArmorProf() => null;

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>()
        {
            { "Bonus Cantrip", "When you choose this domain at 1st level, you gain the Light cantrip if you don't already know it." },
            { "Warding Flare", "Also at 1st level, you can interpose divine light between yourself and an attacking enemy. When you are attacked by a creature within 30 feet of you that you can see, you can use your reaction to impose disadvantage on the attack roll, causing light to flare before the attacker before it hits or misses. An attacker that can't be blinded is immune to this feature." +
                "\nYou can use this feature a number of times equal to your Wisdom modifier (a minimum of once). You regain all expended uses when you finish a long rest." }
        };

        public List<string> setLanguageProf() => null;

        public List<string> setSkillProf() => null;

        public List<string> setWeaponProf() => null;
    }
}