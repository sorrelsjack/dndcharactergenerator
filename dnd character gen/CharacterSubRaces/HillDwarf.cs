using System.Collections.Generic;

namespace dnd_character_gen.CharacterRaces
{
    public class HillDwarf : Dwarf //TODO: Finish
    {
        public override Dictionary<string, int> setAbilityScores() => new Dictionary<string, int>
        {
            { "Constitution", 2 },
            { "Wisdom", 1 }
        };

        public override int setHitPointModifier() => 1;

        public override Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            {
                "Darkvision",
                "Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray."
            },
            {
                "Dwarven Resilience",
                "You have advantage on saving throws against poison, and you have resistance against poison damage."
            },
            { "Dwarven Toughness", "Your hit point maximum increases by 1, and it increases by 1 every time you gain a level." },
            {
                "Dwarven Combat Training",
                "You have proficiency with the battleaxe, handaxe, light hammer, and warhammer."
            },
            {
                "Stonecunning",
                "Whenever you make an Intelligence (History) check related to the origin of stonework, you are considered proficient in the History skill and add double your proficiency bonus to the check, instead of your normal proficiency bonus."
            }
        };
    }
}