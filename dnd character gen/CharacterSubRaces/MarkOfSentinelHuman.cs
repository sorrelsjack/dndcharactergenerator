using System.Collections.Generic;
using dnd_character_gen.CharacterRaces;
using dnd_character_gen.Extensions;

namespace dnd_character_gen.CharacterSubRaces
{
    public class MarkOfSentinelHuman : Human
    {
        public override Dictionary<string, int> setAbilityScores()
        {
            Dictionary<string, int> abilityScores = new Dictionary<string, int>
            {
                { "Strength", 1 },
                { "Wisdom", 1 }
            };
            List<string> availableStats = new List<string> { "Dexterity", "Constitution", "Intelligence", "Charisma" };
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
            { "Sentinel's Intuition", "When you roll for Initiative or make a Wisdom (Perception) check to notice a threat, you can roll one Intuition die, a d4, and add it to the ability check." },
            { "Sentinel's Shield", "You know the cantrip blade ward. You can cast shield once with this trait and regain the ability to do so after you finish a short or long rest." },
            { "Vigilant Guardian", "As an action, you can designate an ally you can see as your ward. You have advantage on Wisdom (Insight) and Wisdom (Perception) checks made to spot threats to your ward. In addition, when you are within 5 feet of your ward, and that creature is the target of an attack that you can see, you can use your reaction to swap places with your ward. When you do, you become the target of the attack." }
        };
    }
}