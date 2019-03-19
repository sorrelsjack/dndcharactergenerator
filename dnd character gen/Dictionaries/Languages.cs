using System.Collections.Generic;

namespace dnd_character_gen.Dictionaries
{
    public class Languages
    {
        public List<string> languages = new List<string>();
        public List<string> exoticLanguages = new List<string>();
        public Dictionary<string, string> languageMap = new Dictionary<string, string>();

        private Languages()
        {
            languages.Add("Common");
            languages.Add("Dwarvish");
            languages.Add("Elvish");
            languages.Add("Giant");
            languages.Add("Gnomish");
            languages.Add("Goblin");
            languages.Add("Halfling");
            languages.Add("Orcish");

            exoticLanguages.Add("Abyssal");
            exoticLanguages.Add("Celestial");
            exoticLanguages.Add("Draconic");
            exoticLanguages.Add("Deep Speech");
            exoticLanguages.Add("Infernal");
            exoticLanguages.Add("Primoridal");
            exoticLanguages.Add("Sylvan");
            exoticLanguages.Add("Undercommon");
            exoticLanguages.Add("Druidic");

            languageMap.Add("Humans", "Common");
            languageMap.Add("Dwarves", "Dwarvish");
            languageMap.Add("Elves", "Elvish");
            languageMap.Add("Ogres", "Giant");
            languageMap.Add("Giants", "Giant");
            languageMap.Add("Gnomes", "Gnomish");
            languageMap.Add("Goblinoids", "Goblin");
            languageMap.Add("Halflings", "Halfling");
            languageMap.Add("Gnolls", "Gnoll");
            languageMap.Add("Orcs", "Orcish");

            //TODO: Aberrations, monstrosities, plants, undead

            languageMap.Add("Demons", "Abyssal");
            languageMap.Add("Celestials", "Celestial");
            languageMap.Add("Dragons", "Draconic");
            languageMap.Add("Dragonborn", "Draconic");
            languageMap.Add("Kobold", "Draconic");
            languageMap.Add("Lizardfolk", "Draconic");
            languageMap.Add("Mind Flayers", "Deep Speech");
            languageMap.Add("Beholders", "Deep Speech");
            languageMap.Add("Devils", "Infernal");
            languageMap.Add("Elementals", "Primordial");
            languageMap.Add("Fey", "Sylvan");
            languageMap.Add("Underdark Traders", "Undercommon");
            languageMap.Add("Druids", "Druidic");
        }

        private static Languages instance;

        public static Languages Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Languages();
                }
                return instance;
            }
        }
    }
}