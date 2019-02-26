using System.Collections.Generic;
using dnd_character_gen.CharacterRaces;

namespace dnd_character_gen.CharacterSubRaces
{
    public class DarkElf : Elf
    {
        public override Dictionary<string, int> setAbilityScores() => new Dictionary<string, int>
        {
            {"Dexterity", 2},
            {"Charisma", 1}
        };

        public override Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            {
                "Darkvision",
                "Accustomed to twilit forests and the night sky, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray."
            },
            {"Superior Darkvision", "Your darkvision has a radius of 120 feet."},
            {"Keen Senses", "You have proficiency in the Perception skill."},
            {
                "Sunlight Sensitivity",
                "You have disadvantage on attack rolls and on Wisdom (Perception) checks that rely on sight when you, the target of your attack, or whatever you are trying to perceive is in direct sunlight."
            },
            {
                "Drow Magic",
                "Drow Magic. You know the dancing lights cantrip. When you reach 3rd level, you can cast the faerie fire spell once per day. When you reach 5th level, you can also cast the darkness spell once per day. Charisma is your spellcasting ability for these spells."
            },
            {"Drow Weapon Training", "You have proficiency with rapiers, shortswords, and hand crossbows."},
            {
                "Fey Ancestry",
                "You have advantage on saving throws against being charmed, and magic can’t put you to sleep."
            },
            {
                "Trance",
                "Elves don’t need to sleep. Instead, they meditate deeply, remaining semiconscious, for 4 hours a day. (The Common word for such meditation is “trance.”) While meditating, you can dream after a fashion; such dreams are actually mental exercises that have become reflexive through years of practice. After resting in this way, you gain the same benefit that a human does from 8 hours of sleep."
            }
        };

        public override List<string> setWeaponProf() => new List<string> { "Rapiers", "Shortswords", "Hand crossbows" };
    }
}