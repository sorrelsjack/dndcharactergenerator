using System.Collections.Generic;
using dnd_character_gen.CharacterRaces;
using dnd_character_gen.Extensions;

namespace dnd_character_gen.CharacterSubRaces
{
    public class MarkOfPassageHuman : Human
    {
        public override Dictionary<string, int> setAbilityScores()
        {
            Dictionary<string, int> abilityScores = new Dictionary<string, int>
            {
                { "Dexterity", 2 }
            };
            List<string> availableStats = new List<string> { "Strength", "Charisma", "Constitution", "Intelligence", "Wisdom" };
            string stat = "";

            stat = availableStats[NumberGen.gen(availableStats.Count)];
            abilityScores.Add(stat, 1);

            return abilityScores;
        }

        public override int setSpeed() => 40;

        public override Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Courier's Speed", "Your base walking speed increases to 40 ft." },
            { "Intuitive Motion", "When you make a Strength (Athletics) check or any ability check to operate or maintain a land vehicle, you can roll one Intuition die, a d4, and add the number rolled to the ability check." },
            { "Orien's Grace", "When you use the Dash action, difficult terrain doesn’t cost you extra movement on that turn." },
            { "Shared Passage", "As a bonus action you can teleport a distance up to your walking speed, ending in an unoccupied space that you can see. You can bring one willing creature of your size or smaller who is carrying gear up to its carrying capacity. The creature must be within 5 feet of you when you use this trait. Once you use this trait, you can’t use it again until you finish a long rest." }
        };
    }
}