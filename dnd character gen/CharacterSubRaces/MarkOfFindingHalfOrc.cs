using System.Collections.Generic;
using dnd_character_gen.CharacterRaces;
using dnd_character_gen.Extensions;

namespace dnd_character_gen.CharacterSubRaces
{
    public class MarkOfFindingHalfOrc : HalfOrc //TODO; look at half-orc again
    {
        public override Dictionary<string, int> setAbilityScores()
        {
            Dictionary<string, int> abilityScores = new Dictionary<string, int>
            {
                { "Strength", 1 },
                { "Wisdom", 1 }
            };
            List<string> availableStats = new List<string> { "Constitution", "Intelligence", "Dexterity", "Charisma" }; //TODO: Actually, in these cases, does it include the ones already selected?
            string stat = "";

            while (abilityScores.Count < 3)
            {
                stat = availableStats[NumberGen.gen(availableStats.Count)];

                abilityScores.Add(stat, 1);
                availableStats.Remove(stat);
            }

            return abilityScores;
        }

        public override Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Darkvision",  "Thanks to your orc blood, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray." },
            { "Hunter's Intuition", "Your mark sharpens your senses and helps you find your prey. When you make a Wisdom (Perception) or Wisdom (Survival) check, you can roll one Intuition die, a d4, and add the number rolled to the ability check." },
            { "Imprint Prey",  "As a bonus action, choose one creature you can see within 30 feet of you. The target is imprinted in your mind until it dies or you use this trait again. Alternatively, you can imprint a creature as your quarry whenever you succeed on a Wisdom (Survival) check to track it." },
            { "Nature's Voice", "When you reach 3rd level you gain the ability to cast locate animals or plants, but only as a ritual." },
        };

        public override List<string> setSkills() => null;
    }
}