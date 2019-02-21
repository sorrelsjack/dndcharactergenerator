using System.Collections.Generic;

namespace dnd_character_gen.Dictionaries
{
    public class Languages
    {
        public List<string> languages = new List<string>();

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