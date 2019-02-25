using System.Collections.Generic;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;

namespace dnd_character_gen.CharacterRaces
{
    public class MarkOfScribingGnome : Gnome
    {
        public override Dictionary<string, int> setAbilityScores() => new Dictionary<string, int>
        {
            { "Intelligence", 2 },
            { "Charisma", 1 }
        };

        public override List<string> setToolsProf() => new List<string> { "Calligrapher's supplies", "Forgery kit" };

        public override Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Darkvision", "Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray." },
            { "Gifted Scribe", "You are proficient with calligrapher’s supplies and the forgery kit. When you make an ability check using either one of these tools, you can roll one Intuition die, a d4, and add the number rolled to the ability check." },
            { "Scribe's Insight", "You can cast comprehend languages once with this trait, and you regain the ability to do so when you finish a long rest. Intelligence is your spellcasting ability for it." },
            { "Whispering Wind", "You know the cantrip message. Intelligence is your spellcasting ability when casting it." },
            { "Extra Language",  "You can speak, read, and write one extra language of your choice." },
            { "Gnome Cunning", "You have advantage on all Intelligence, Wisdom, and Charisma saving throws against magic." }
        };

        public override List<string> setLanguages() => new List<string> { "Common", "Gnomish", $"{Languages.Instance.languages[NumberGen.gen(Languages.Instance.languages.Count)]}" };
    }
}