using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.Dictionaries {
    public class Skills {
        public Dictionary<string, string> skills = new Dictionary<string, string>();

        private Skills() {
            skills.Add("Acrobatics", "Dexterity");
            skills.Add("Animal Handling", "Wisdom");
            skills.Add("Arcana", "Intelligence");
            skills.Add("Athletics", "Strength");
            skills.Add("Deception", "Charisma");
            skills.Add("History", "Intelligence");
            skills.Add("Insight", "Wisdom");
            skills.Add("Intimidation", "Charisma");
            skills.Add("Investigation", "Intelligence");
            skills.Add("Medicine", "Wisdom");
            skills.Add("Nature", "Intelligence");
            skills.Add("Perception", "Wisdom");
            skills.Add("Performance", "Charisma");
            skills.Add("Persuasion", "Charisma");
            skills.Add("Religion", "Intelligence");
            skills.Add("Sleight of Hand", "Dexterity");
            skills.Add("Stealth", "Dexterity");
            skills.Add("Survival", "Wisdom");
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
