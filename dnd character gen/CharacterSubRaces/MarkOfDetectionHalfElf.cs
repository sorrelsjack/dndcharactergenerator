using System.Collections.Generic;
using dnd_character_gen.CharacterRaces;
using dnd_character_gen.Extensions;

namespace dnd_character_gen.CharacterSubRaces
{
    public class MarkOfDetectionHalfElf : HalfElf
    {
        public override Dictionary<string, int> setAbilityScores()
        {
            Dictionary<string, int> abilityScores = new Dictionary<string, int>
            {
                { "Intelligence", 1 },
                { "Charisma", 1 }
            };
            List<string> availableStats = new List<string> { "Strength", "Dexterity", "Constitution", "Wisdom" };
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
            { "Darkvision", "Thanks to your elf blood, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray." },
            { "Fey Ancestry", "You have advantage on saving throws against being charmed, and magic can’t put you to sleep." },
            { "Deductive Intuition", "When you make an Intelligence (Investigation) or Wisdom (Insight) check, you can roll one Intuition die, a d4, and add the number rolled to the ability check." },
            { "Sense Threats", "You can cast the detect magic and detect poison and disease spells, but only as rituals. Intelligence is your spellcasting ability for these spells." },
            { "Skill Versatility", "You gain proficiency in two skills of your choice." },
        };

        public override List<string> setLanguages() => new List<string> { "Common", "Elvish" };
    }
}