using System.Collections.Generic;

namespace dnd_character_gen.CharacterRaces
{
    public class DeepGnome : Gnome
    {
        public override Dictionary<string, int> setAbilityScores() => new Dictionary<string, int>
        {
            { "Intelligence", 2 },
            { "Dexterity", 1 }
        };

        public override List<string> setLanguages() => new List<string> { "Common", "Gnomish", "Undercommon" };

        public override Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Darkvision", "Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray." },
            { "Superior Darkvision", "Your darkvision has a radius of 120 feet." },
            { "Stone Camouflage", "You have advantage on Dexterity (stealth) checks to hide in rocky terrain." },
            { "Gnome Cunning", "You have advantage on all Intelligence, Wisdom, and Charisma saving throws against magic." }
        };
    }
}