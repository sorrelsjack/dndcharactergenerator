using System.Collections.Generic;
using dnd_character_gen.CharacterRaces;
using dnd_character_gen.Extensions;

namespace dnd_character_gen.CharacterSubRaces
{
    public class MarkOfStormHalfElf : HalfElf
    {
        public override Dictionary<string, int> setAbilityScores()
        {
            Dictionary<string, int> abilityScores = new Dictionary<string, int>
            {
                { "Dexterity", 1 },
                { "Charisma", 1 }
            };
            List<string> availableStats = new List<string> { "Strength", "Intelligence", "Constitution", "Wisdom" };
            string stat = "";

            while (abilityScores.Count < 3)
            {
                stat = availableStats[NumberGen.gen(availableStats.Count)];

                abilityScores.Add(stat, 1);
                availableStats.Remove(stat);
            }

            return abilityScores;
        }

        public override List<string> setLanguages() => new List<string> { "Common", "Elvish" };

        public override Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Darkvision", "Thanks to your elf blood, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray." },
            { "Fey Ancestry", "You have advantage on saving throws against being charmed, and magic can’t put you to sleep." },
            { "Sea Monkey", "Your base walking speed is 30 feet, and you have a swim speed of 30 feet." },
            { "Windwright's Intuition", "When you make a Dexterity (Acrobatics) check or any ability check involving operating or maintaining a water or air vehicle, you can roll one Intuition die, a d4, and add the number rolled to the ability check." },
            { "Storm's Blessing", "You have resistance to lightning damage." },
            { "Headwinds", "You know the gust cantrip. When you reach 3rd level, you can cast the gust of wind spell once with this trait and regain the ability to do so when you finish a long rest." },
            { "Skill Versatility", "You gain proficiency in two skills of your choice." },
        };
    }
}