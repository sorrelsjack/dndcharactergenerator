using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dnd_character_gen.Dictionaries;

namespace dnd_character_gen.CharacterClasses {
    public class Druid : ICharacterClass
    {
        public List<string> setArmorProf() => new List<string> {"Light armor", "Medium armor", "Shields"};

        public List<string> setEquipment() {
            List<string> equipment = new List<string>();
            int randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 1
                ? "Wooden Shield" : SimpleWeapons.Instance.weapons[NumberGen.gen(SimpleWeapons.Instance.weapons.Count)]);

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 1
                ? "Scimitar" : SimpleWeapons.Instance.weapons[NumberGen.gen(SimpleWeapons.Instance.weapons.Count)]);

            equipment.Add("Leather Armor");
            equipment.Add("Explorer's Pack");
            equipment.Add("Druidic Focus");

            return equipment;
        }

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Druidic", "-Knows Druidic, the secret language of druids\n-Language can be used to leave hidden messages\n-Other can spot messages on a successful DC 15 Perception check"},
            { "Spellcasting", "Oh you know." }
        };

        public int setHitDie() => 8;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setLanguages() => new List<string>() { "Druidic" };

        public string setPrimaryStat() => "Wisdom";

        public List<string> setSaves() => new List<string>() { "Intelligence", "Wisdom" };

        public List<string> setSkills() {
            List<string> skillProficiencies = new List<string>();
            List<string> availableSkills = new List<string>()
            { "Arcana", "Animal Handling", "Medicine", "Nature", "Perception", "Religion", "Surival" };

            string skill = availableSkills[NumberGen.gen(7)];
            skillProficiencies.Add(skill);
            availableSkills.Remove(skill);

            skill = availableSkills[NumberGen.gen(6)];
            skillProficiencies.Add(skill);

            return skillProficiencies;
        }

        public int setSpellAttackMod(int proficiency, Dictionary<string, int> modifiers) =>
            proficiency + modifiers["Wisdom"];

        public int setSpellSaveDC(int proficiency, Dictionary<string, int> modifiers) =>
            8 + proficiency + modifiers["Wisdom"];

        public string setSubType() => null;

        public List<string> setToolsProf() => new List<string>() { "Herbalism Kit" };

        public List<string> setWeaponProf() => new List<string>() 
            { "Clubs", "Daggers", "Darts", "Javelins", "Maces", "Quarterstaffs", "Scimitars", "Sickles", "Slings", "Spears" };
    }
}
