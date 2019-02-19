using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterClasses {
    public class Paladin : ICharacterClass {
        public List<string> setArmorProf() => new List<string> { "Light armor", "Medium armor", "Heavy Armor", "Shields" };

        public List<string> setEquipment() {
            List<string> equipment = new List<string>();
            int randomNumber = NumberGen.gen(2);
            if (randomNumber == 1)
            {
                equipment.Add(MartialWeapons.Instance.weapons[NumberGen.gen(MartialWeapons.Instance.weapons.Count)]);
                equipment.Add("Shield");
            }
            else
            {
                equipment.Add(MartialWeapons.Instance.weapons[NumberGen.gen(MartialWeapons.Instance.weapons.Count)]);
                equipment.Add(MartialWeapons.Instance.weapons[NumberGen.gen(MartialWeapons.Instance.weapons.Count)]);
            }

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 1
                ? "Five javelins" : SimpleWeapons.Instance.weapons[NumberGen.gen(SimpleWeapons.Instance.weapons.Count)]);

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 1
                ? "Priest's pack" : "Explorer's pack");

            equipment.Add("Chain mail");
            equipment.Add("Holy symbol");

            return equipment;
        }

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Divine Sense", "-Until end of next turn, know the location of any celestial, fiend, or undead within 60ft.\n-Use this feature a number of times equal to 1 + Charisma modifier."},
            { "Lay on Hands", "-Healing power that replenishes after a long rest.\n-Can restore hit points equal to Paladin level * 5.\n-As an action, touch a creature and restore hit point from the pool of power."}
        };

        public int setHitDie() => 10;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setLanguages() => null;

        public string setPrimaryStat() => "Strength";

        public List<string> setSaves() => new List<string> { "Wisdom", "Charisma" };

        public List<string> setSkills() {
            List<string> skillProficiencies = new List<string>();
            List<string> availableSkills = new List<string>()
                { "Athletics", "Insight", "Intimidation", "Medicine", "Persuasion", "Religion" };

            string skill = availableSkills[NumberGen.gen(6)]; //TODO make it so that it accounts for a 0 index system.. sigh.
            skillProficiencies.Add(skill);
            availableSkills.Remove(skill);

            skill = availableSkills[NumberGen.gen(5)];
            skillProficiencies.Add(skill);

            return skillProficiencies;
        }

        public int setSpellAttackMod(int proficiency, Dictionary<string, int> modifiers) =>
            proficiency + modifiers["Charisma"];

        public int setSpellSaveDC(int proficiency, Dictionary<string, int> modifiers) => 
            8 + proficiency + modifiers["Charisma"];

        public string setSubType() => null;

        public List<string> setToolsProf() => null;

        public List<string> setWeaponProf() => new List<string> { "Simple weapons", "Martial weapons" };
    }
}
