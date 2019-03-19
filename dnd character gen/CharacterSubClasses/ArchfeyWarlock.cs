using System.Collections.Generic;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterSubClasses
{
    public class ArchfeyWarlock : ICharacterSubClass
    {
        public List<string> setArmorProf() => null;

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string> {
            { "Fey Presence", "Starting at 1st level, your patron bestows upon you the ability to project the beguiling and fearsome presence of the fey. As an action, you can cause each creature in a 10-foot cube originating from you to make a Wisdom saving throw against your warlock spell save DC. The creatures that fail their saving throws are all charmed or frightened by you (your choice) until the end of your next turn." +
                "\nOnce you use this feature, you can't use it again until you finish a short or long rest." }
        };

        public List<string> setLanguageProf() => null;

        public List<string> setSkillProf() => null;

        public List<string> setWeaponProf() => null;
    }
}