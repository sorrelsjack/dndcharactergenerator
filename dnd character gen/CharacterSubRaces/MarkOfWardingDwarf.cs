using System.Collections.Generic;

namespace dnd_character_gen.CharacterRaces
{
    public class MarkOfWardingDwarf : Dwarf
    {
        public override Dictionary<string, int> setAbilityScores() => new Dictionary<string, int>
        {
            { "Constitution", 2 },
            { "Dexterity", 1 },
            { "Intelligence", 1 }
        };

        public override Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Darkvision", "Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray." },
            { "Dwarven Resilience", "You have advantage on saving throws against poison, and you have resistance against poison damage." },
            { "Master of Locks", "When you make an Intelligence (History), Intelligence (Investigation), or Thieves’ Tools check involving lock and trap mechanisms, you can roll one Intuition die, a d4, and add the number rolled to the ability check." },
            { "Wards and Seals", "You can use your mark to cast the alarm spell as a ritual. Starting at 3rd level you can cast arcane lock once with this trait and you regain the ability to do so when you finish a long rest. Intelligence is your spellcasting ability for these spells." },
            { "Dwarven Combat Training", "You have proficiency with the battleaxe, handaxe, light hammer, and warhammer." },
            { "Stonecunning", "Whenever you make an Intelligence (History) check related to the origin of stonework, you are considered proficient in the History skill and add double your proficiency bonus to the check, instead of your normal proficiency bonus." }
        };
    }
}