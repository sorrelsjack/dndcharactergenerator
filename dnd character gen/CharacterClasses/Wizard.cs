using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterClasses {
    public class Wizard : ICharacterClass {

        public List<string> setArmorProf() => null;

        public List<string> setEquipment() {
            List<string> equipment = new List<string>();
            int randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 1 ? "Quarterstaff" : "Dagger");

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 1 ? "Component pouch" : "Arcane focus");

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 1 ? "Scholar's pack" : "Explorer's pack");

            equipment.Add("Spellbook");

            return equipment;
        }

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Spellcasting", "Oh you know." },
            { "Arcane Recovery", "-1/day, when finishing a short rest, choose expended spell slots to recover./n-Slots can have a combined level equal to or less than half of your Wizard level (rounded up)"}
        };

        public int setHitDie() => 6;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setLanguages() => null;

        public string setPrimaryStat() => "Intelligence";

        public List<string> setSaves() => new List<string> { "Intelligence", "Wisdom" };

        public List<string> setSkills() {
            List<string> skillProficiencies = new List<string>();
            List<string> availableSkills = new List<string>() { "Arcana", "History", "Insight", "Investigation", "Medicine", "Religion" };

            string skill = availableSkills[NumberGen.gen(6)];
            skillProficiencies.Add(skill);
            availableSkills.Remove(skill);

            skill = availableSkills[NumberGen.gen(5)];
            skillProficiencies.Add(skill);

            return skillProficiencies;
        }

        public int setSpellAttackMod(int proficiency, Dictionary<string, int> modifiers) => 
            proficiency + modifiers["Intelligence"];

        public int setSpellSaveDC(int proficiency, Dictionary<string, int> modifiers) =>
            8 + proficiency + modifiers["Intelligence"];

        public string setSubType() => null;

        public List<string> setToolsProf() => null;

        public List<string> setWeaponProf() => new List<string> { "Daggers", "Darts", "Slings", "Quarterstaffs", "Light Crossbows" };
    }
}
