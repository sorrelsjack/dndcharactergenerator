using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterClasses {
    public class Warlock : ICharacterClass {
        public List<string> setArmorProf() => new List<string> { "Light armor" };

        public List<string> setEquipment() {
            List<string> equipment = new List<string>();
            int randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 1
                ? "Light crossbow and 20 bolts" : SimpleWeapons.Instance.weapons[NumberGen.gen(SimpleWeapons.Instance.weapons.Count)]);

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 1 ? "Component pouch" : "Arcane focus");

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 1 ? "Scholar's pack" : "Dungeoneer's pack");

            equipment.Add("Leather armor");
            equipment.Add(SimpleWeapons.Instance.weapons[NumberGen.gen(SimpleWeapons.Instance.weapons.Count)]);
            equipment.Add("Two daggers");

            return equipment;
        }

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Otherworldly Patron", "-Make a pact with an otherworldly being of your choice"},
            { "Pact Magic", "-Arcane research and magic from patron let you cast spells"}
        };

        public int setHitDie() => 8;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setLanguages() => null;

        public string setPrimaryStat() => "Charisma";

        public List<string> setSaves() => new List<string> { "Wisdom", "Charisma" };

        public List<string> setSkills() {
            List<string> skillProficiencies = new List<string>();
            List<string> availableSkills = new List<string>()
                { "Arcana", "Deception", "History", "Intimidation", "Investigation", "Nature", "Religion" };

            string skill = availableSkills[NumberGen.gen(7)];
            skillProficiencies.Add(skill);
            availableSkills.Remove(skill);

            skill = availableSkills[NumberGen.gen(6)];
            skillProficiencies.Add(skill);

            return skillProficiencies;
        }

        public int setSpellAttackMod(int proficiency, Dictionary<string, int> modifiers) =>
            proficiency + modifiers["Charisma"];

        public int setSpellSaveDC(int proficiency, Dictionary<string, int> modifiers) =>
            8 + proficiency + modifiers["Charisma"];

        public string setSubType() {
            List<string> patrons = new List<string>() {"Fiend"}; //TODO fill this out

            return patrons[NumberGen.gen(1)];
        }

        public List<string> setToolsProf() => null;

        public List<string> setWeaponProf() => new List<string> { "Simple weapons" };
    }
}
