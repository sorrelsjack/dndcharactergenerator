using System.Collections.Generic;

namespace dnd_character_gen.Dictionaries
{
    public class GamingSets
    {
        public List<string> sets = new List<string>();

        private GamingSets()
        {
            sets.Add("Dice set");
            sets.Add("Playing card set");
        }

        private static GamingSets instance;

        public static GamingSets Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GamingSets();
                }

                return instance;
            }
        }
    }
}