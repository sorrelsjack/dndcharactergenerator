using System.Collections.Generic;
using dnd_character_gen.CharacterRaces;

namespace dnd_character_gen.CharacterSubRaces
{
    public class WoodElf : Elf
    {
        public override Dictionary<string, int> setAbilityScores() => new Dictionary<string, int>
        {
            { "Dexterity", 2 },
            { "Wisdom", 1 }
        };

        public override List<string> setWeaponProf() => new List<string> { "Longsword", "Shortsword", "Shortbow", "Longbow" };

        public override int setSpeed() => 35;

        public override Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Darkvision", "Accustomed to twilit forests and the night sky, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray." },
            { "Keen Senses", "You have proficiency in the Perception skill." },
            { "Elf Weapon Training", "You have proficiency with the longsword, shortsword, shortbow, and longbow" },
            { "Fleet of Foot", "Your base walking speed increases to 35 feet." },
            { "Mask of the Wild", "You can attempt to hide even when you are only lightly obscured by foliage, heavy rain, falling snow, mist, and other natural phenomena." },
            { "Fey Ancestry", "You have advantage on saving throws against being charmed, and magic can’t put you to sleep." },
            { "Trance", "Elves don’t need to sleep. Instead, they meditate deeply, remaining semiconscious, for 4 hours a day. (The Common word for such meditation is “trance.”) While meditating, you can dream after a fashion; such dreams are actually mental exercises that have become reflexive through years of practice. After resting in this way, you gain the same benefit that a human does from 8 hours of sleep." }
        };
    }
}