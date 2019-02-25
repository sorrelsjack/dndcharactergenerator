using System.Collections.Generic;

namespace dnd_character_gen.CharacterRaces
{
    public class MarkOfHealingHalfling : Halfling
    {
        public override Dictionary<string, int> setAbilityScores() => new Dictionary<string, int>
        {
            { "Dexterity", 2 },
            { "Wisdom", 1 }
        };

        public override Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Lucky", "When you roll a 1 on the d20 for an attack roll, ability check, or saving throw, you can reroll the die and must use the new roll." },
            { "Brave", "You have advantage on saving throws against being frightened." },
            { "Medical Intuition", "When you make a Wisdom (Medicine) check, you can roll one Intuition die, a d4, and add the number rolled to the ability check." },
            { "Healing Touch", "As an action, you can draw power from your dragonmark to spend one of your Hit Dice and revitalize yourself or a creature you touch. Roll the die, add your Wisdom modifier, and the creature regains a number of hit points equal to the total. Once you use this trait, you can’t use it again until you finish a short or long rest." },
            { "Jorasco's Blessing", "You know the cantrip spare the dying. Charisma is your spellcasting ability for this" },
            { "Halfling Nimbleness", "You can move through the space of any creature that is of a size larger than yours." }
        };
    }
}