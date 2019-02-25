using System.Collections.Generic;

namespace dnd_character_gen.CharacterRaces
{
    public class LightfootHalfling : Halfling
    {
        public override Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Lucky", "When you roll a 1 on the d20 for an attack roll, ability check, or saving throw, you can reroll the die and must use the new roll." },
            { "Brave", "You have advantage on saving throws against being frightened." },
            { "Naturally Stealthy", "You can attempt to hide even when you are obscured only by a creature that is at least one size larger than you." },
            { "Halfling Nimbleness", "You can move through the space of any creature that is of a size larger than yours." }
        };

        public override Dictionary<string, int> setAbilityScores() => new Dictionary<string, int>
        {
            { "Dexterity", 2 },
            { "Charisma", 1 }
        };
    }
}