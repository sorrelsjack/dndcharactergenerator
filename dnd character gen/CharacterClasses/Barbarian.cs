using System.Collections.Generic;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterClasses
{
    public class Barbarian : ICharacterClass
    {
        public string setSubType() => null;

        public string setPrimaryStat() => "Strength";

        public int setHitDie() => 12;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setArmorProf() => new List<string>() { "Light armor", "Medium armor", "Shields" };

        public List<string> setWeaponProf() => new List<string>() { "Simple weapons", "Martial weapons" };

        public List<string> setToolsProf() => null;

        public List<string> setSaves() => new List<string>() { "Strength", "Constitution" };

        public List<string> setSkills()
        {
            List<string> skillProficiencies = new List<string>();
            List<string> availableSkills = new List<string>()
            { "Animal Handling", "Athletics", "Intimidation", "Nature", "Perception", "Survival"};

            string skill = availableSkills[NumberGen.gen(6)];
            skillProficiencies.Add(skill);
            availableSkills.Remove(skill);

            skill = availableSkills[NumberGen.gen(5)];
            skillProficiencies.Add(skill);

            return skillProficiencies;
        }

        public List<string> setEquipment()
        {
            List<string> equipment = new List<string>();
            int randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 0
                ? "Greataxe" : MartialWeapons.Instance.weapons[NumberGen.gen(MartialWeapons.Instance.weapons.Count)]);

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 0
                ? "Two Handaxe" : SimpleWeapons.Instance.weapons[NumberGen.gen(SimpleWeapons.Instance.weapons.Count)]);

            equipment.Add("Explorer's Pack");
            equipment.Add("Four Javelins");

            return equipment;
        }

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Rage", "-Can enter Rage as bonus action/n-Advantage on Strength checks and Strength saving throws" +
                "/n-Melee weapon attacks using Strength get a bonus to damage rolls/n-Resistance to bludgeoning, piercing, and slashing damage" },
            { "Unarmored Defense", "-While not wearing armor, AC is 10 + Dexterity modifier + Constitution modifier. Can use a shield still." }
        };

        public int setSpellAttackMod(int proficiency, Dictionary<string, int> modifiers) => 0;

        public int setSpellSaveDC(int proficiency, Dictionary<string, int> modifiers) => 0;

        public List<string> setLanguages() => null;
    }
}