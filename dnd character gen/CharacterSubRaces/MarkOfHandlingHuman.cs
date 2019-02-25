using System.Collections.Generic;
using dnd_character_gen.CharacterRaces;
using dnd_character_gen.Extensions;

namespace dnd_character_gen.CharacterSubRaces
{
    public class MarkOfHandlingHuman : Human
    {
        public override Dictionary<string, int> setAbilityScores()
        {
            Dictionary<string, int> abilityScores = new Dictionary<string, int>
            {
                { "Dexterity", 1 },
                { "Wisdom", 1 }
            };
            List<string> availableStats = new List<string> { "Strength", "Intelligence", "Constitution", "Charisma" };
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
            { "Wild Intuition", "When you make a Wisdom (Animal Handling) or Intelligence (Nature) check, you can roll one Intuition die, a d4, and add the number rolled to the ability check." },
            { "Expert Handling", "You can use the help action to aid an ally animal companion or mount within 30 feet of you, rather than 5 feet of you." },
            { "Primal Connection", "You can cast animal friendship once with this trait and regain the ability to do so when you finish a short or long rest. Wisdom is your spellcasting ability for this spell." },
            { "The Bigger They Are", "When you cast a spell that affects only beasts, it also affects monstrosities with an Intelligence score of 3 or lower." }
        };
    }
}