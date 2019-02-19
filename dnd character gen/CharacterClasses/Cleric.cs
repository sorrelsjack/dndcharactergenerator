using dnd_character_gen.CharacterSubClasses;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterClasses {
    public class Cleric : ICharacterClass {
        public List<string> setArmorProf() => new List<string>() { "Light armor", "Medium armor", "Shields" }; //What if we need to add more later if there's more proficiences?

        public List<string> setEquipment() {
            List<string> equipment = new List<string>();
            //Mace or Warhammer (if proficient)
            //Scale mail, leather armor, or chain mail (if proficient)
            //Light crossbow and 20 bolts or any simple weapon
            //Priests pack or explorer's pack
            equipment.Add("Shield");
            equipment.Add("Holy Symbol");

            return equipment;
        }

        public Dictionary<string, string> setFeatures() {
            throw new NotImplementedException();
        }

        public int setHitDie() => 8;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution; //TODO could this go in the main class?

        public List<string> setLanguages() => null;

        public string setPrimaryStat() => "Wisdom";

        public List<string> setSaves() => new List<string>() { "Wisdom", "Charisma" };

        public List<string> setSkills() {
            List<string> skillProficiencies = new List<string>();
            List<string> availableSkills = new List<string>()
            { "History", "Insight", "Medicine", "Persuasion", "Religion" };

            string skill = availableSkills[NumberGen.gen(5)];
            skillProficiencies.Add(skill);
            availableSkills.Remove(skill);

            skill = availableSkills[NumberGen.gen(4)];
            skillProficiencies.Add(skill);

            return skillProficiencies;
        } 

        public int setSpellAttackMod(int proficiency, Dictionary<string, int> modifiers) => proficiency + modifiers["Wisdom"];

        public int setSpellSaveDC(int proficiency, Dictionary<string, int> modifiers) => 8 + proficiency + modifiers["Wisdom"];

        public string setSubType() {
            List<string> domains = new List<string>() { "Knowledge", "Life", "Light", "Nature", "Tempest", "Trickery", "War" };

            return domains[NumberGen.gen(7)];
        }

        public List<string> setToolsProf() => null;

        public List<string> setWeaponProf() => new List<string> { "Simple weapons" };
    }
}
