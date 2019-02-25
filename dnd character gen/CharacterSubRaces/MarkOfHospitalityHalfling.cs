using System.Collections.Generic;

namespace dnd_character_gen.CharacterRaces
{
    public class MarkOfHospitalityHalfling : Halfling
    {
        public override Dictionary<string, int> setAbilityScores() => new Dictionary<string, int>
        {
            { "Dexterity", 2 },
            { "Charisma", 1 }
        };

        public override Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Lucky", "When you roll a 1 on the d20 for an attack roll, ability check, or saving throw, you can reroll the die and must use the new roll." },
            { "Brave", "You have advantage on saving throws against being frightened." },
            { "Innkeeper's Charms", "You know the cantrips friends and prestidigitation. Charisma is your spellcasting ability for them." },
            { "Ever Hospitable", "When you make a Charisma (Persuasion) check or an ability check involving Brewer's Supplies or Cook's Utensils, you can roll one Intuition die (a d4) and add the number rolled to the ability check." },
            { "Halfling Nimbleness", "You can move through the space of any creature that is of a size larger than yours." }
        };
    }
}