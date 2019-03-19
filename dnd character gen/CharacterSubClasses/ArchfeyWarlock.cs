using System.Collections.Generic;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterSubClasses
{
    public class ArchfeyWarlock : ICharacterSubClass //TODO: fix archey lock
    {
        public List<string> setArmorProf() => null;

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string> {
            { "Fey Presence", "-Can cause creatures in a 10 ft cube originating from you to make a Wisdom save against your Warlock spell save DC" +
                "\n-Creatures that fail are charmed or frightened (your choice) until the end of your next turn" }
        };

        public List<string> setLanguageProf() => null;

        public List<string> setSkillProf() => null;

        public List<string> setWeaponProf() => null;
    }
}