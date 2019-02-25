using System.Collections.Generic;

namespace dnd_character_gen.CharacterRaces
{
    public class StoutHalfling : Halfling
    {
        public override Dictionary<string, int> setAbilityScores() => new Dictionary<string, int>
        {
            { "Dexterity", 2 },
            { "Constitution", 1 }
        };

        public override Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Lucky", "When you roll a 1 on the d20 for an attack roll, ability check, or saving throw, you can reroll the die and must use the new roll." },
            { "Brave", "You have advantage on saving throws against being frightened." },
            { "Stout Resilience", "You have advantage on saving throws against poison, and you have resistance against poison damage." },
            { "Halfling Nimbleness", "You can move through the space of any creature that is of a size larger than yours." }
        };
    }
}