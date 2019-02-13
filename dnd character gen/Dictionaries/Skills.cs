using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.Dictionaries {
    public class Skills {
        public Dictionary<string, string> dictionary = new Dictionary<string, string>();

        private Skills() {
            dictionary.Add("Acrobatics", "Dexterity");
            dictionary.Add("Animal Handling", "Wisdom");
            dictionary.Add("Arcana", "Intelligence");
            dictionary.Add("Athletics", "Strength");
            dictionary.Add("Deception", "Charisma");
            dictionary.Add("History", "Intelligence");
            dictionary.Add("Insight", "Wisdom");
            dictionary.Add("Intimidation", "Charisma");
            dictionary.Add("Investigation", "Intelligence");
            dictionary.Add("Medicine", "Wisdom");
            dictionary.Add("Nature", "Intelligence");
            dictionary.Add("Perception", "Wisdom");
            dictionary.Add("Performance", "Charisma");
            dictionary.Add("Persuasion", "Charisma");
            dictionary.Add("Religion", "Intelligence");
            dictionary.Add("Sleight of Hand", "Dexterity");
            dictionary.Add("Stealth", "Dexterity");
            dictionary.Add("Survival", "Wisdom");
        }

        private static Skills instance;

        public static Skills Instance {
            get {
                if (instance == null) {
                    instance = new Skills();
                }
                return instance;
            }
        }

    }
}
