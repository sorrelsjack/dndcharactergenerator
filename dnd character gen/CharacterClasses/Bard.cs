using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterClasses {
    public class Bard : ICharacterClass {
        public int setHitDie() => 8;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setArmorProf() => new List<string>() { "Light armor" };

        public List<string> setWeaponProf() => new List<string>() 
        { "Simple weapons", "Hand crossbows", "Longswords", "Rapiers", "Shortswords" };

        public List<string> setToolsProf() {
            List<string> toolProficiencies = new List<string>();
            string skill = "";

            while (toolProficiencies.Count < 3) {
                skill = MusicalInstruments.Instance.instruments[NumberGen.gen(MusicalInstruments.Instance.instruments.Count)];

                if (!toolProficiencies.Contains(skill)) {
                    toolProficiencies.Add(skill);
                }
            }

            return toolProficiencies;
        }

        public List<string> setSkills() {
            List<string> skillProficiencies = new List<string>();
            string skill = "";

            while (skillProficiencies.Count < 3) {
                skill = Skills.Instance.skills.Keys.ElementAt(NumberGen.gen(Skills.Instance.skills.Count));

                if (!skillProficiencies.Contains(skill)) {
                    skillProficiencies.Add(skill);
                }
            }

            return skillProficiencies;
        }

        public string setPrimaryStat() => "Charisma";

        public List<string> setSaves() => new List<string>() { "Dexterity", "Charisma" };

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string> 
        {
            { "Spellcasting", "-Oh you know."},
            { "Bardic Inspiration", "-Can inspire another creature within 60ft as bonus action" +
                "\n-Inspired creature gains 1d6, which can be added to any roll it makes" }
        };

        public string setSubType() => null;

        public List<string> setEquipment() {
            List<string> equipment = new List<string>();
            int randomNumber = NumberGen.gen(3);

            if (randomNumber == 1)
                equipment.Add("Rapier");
            else if (randomNumber == 2)
                equipment.Add("Longsword");
            else if (randomNumber == 3)
                equipment.Add(SimpleWeapons.Instance.weapons[NumberGen.gen(SimpleWeapons.Instance.weapons.Count)]);

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 1
                ? "Diplomat's Pack" : "Entertainer's Pack");

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 1
                ? "Lute" : MusicalInstruments.Instance.instruments[NumberGen.gen(MusicalInstruments.Instance.instruments.Count)]);

            equipment.Add("Leather Armor");
            equipment.Add("Dagger");

            return equipment;
        }

        public int? setSpellSaveDC(int proficiency, Dictionary<string, int> modifiers) => 8 + proficiency + modifiers["Charisma"];

        public int? setSpellAttackMod(int proficiency, Dictionary<string, int> modifiers) => proficiency + modifiers["Charisma"];

        public List<string> setLanguages() => null;
    }
}
