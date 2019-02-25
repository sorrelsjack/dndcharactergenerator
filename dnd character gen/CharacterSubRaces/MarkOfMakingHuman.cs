using System.Collections.Generic;
using dnd_character_gen.CharacterRaces;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;

namespace dnd_character_gen.CharacterSubRaces
{
    public class MarkOfMakingHuman : Human
    {
        public override Dictionary<string, int> setAbilityScores()
        {
            Dictionary<string, int> abilityScores = new Dictionary<string, int>
            {
                { "Intelligence", 1 },
                { "Dexterity", 1 }
            };

            if (NumberGen.gen(2) == 0)
                abilityScores["Intelligence"] = abilityScores["Intelligence"] + 1;
            else
            {
                abilityScores["Dexterity"] = abilityScores["Dexterity"] + 1;
            }

            return abilityScores;
        }

        public override Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Artisan's Intuition", "When you make an ability check with artisan’s tools, roll 1d4 and add it to the result." },
            { "Maker's Gift", "You know the cantrip mending and gain proficiency with one type of artisan’s tools." },
            { "Magecraft",  "You can create a temporary magic item out of common materials. Choose a cantrip from the wizard spell list. Describe the item connected to it. As long as you possess the item, you know that cantrip. At the end of a long rest, you can replace it with a new item and select a new cantrip from the wizard spell list. Intelligence is your spellcasting ability for these cantrips." },
            { "Spellsmith", "You can spend one minute to weave a temporary enchantment into a nonmagical suit of armor or weapon. For the next hour the object becomes a magic item, gaining a +1 bonus to AC if it is armor or a +1 bonus to hit and damage if it is a weapon. Once you use this trait, you can’t use it again until you finish a long rest." }
        };

        public override List<string> setToolsProf() => new List<string> { ArtisansTools.Instance.tools[NumberGen.gen(ArtisansTools.Instance.tools.Count)] };
    }
}