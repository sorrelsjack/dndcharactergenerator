using System.Collections.Generic;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterClasses
{
    public class Barbarian : ICharacterClass
    {
        private List<string> reasons = new List<string> 
        {
            "My devotion to my people lifted me in battle, making me powerful and dangerous. ",
            "The spirits of my ancestors called on me to carry out a great task.",
            "I lost control in battle one day, and it was as if something else was manipulating my body, forcing it to kill every foe I could reach.",
            "I went on a spiritual journey to find myself and instead found a spirit animal to guide, protect, and inspire me.",
            "I was struck by lightning and lived. Afterward, I found a new strength within me that let me push beyond my limitations.",
            "My anger needed to be channeled into battle, or I risked becoming an indiscriminate killer."
        };

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
            { "Rage", "In battle, you fight with primal ferocity. On your turn, you can enter a rage as a bonus action. " +
                "\nWhile raging, you gain the following benefits if you aren’t wearing heavy armor:" +
                "\n- You have advantage on Strength checks and Strength saving throws." +
                "\n- When you make a melee weapon attack using Strength, you gain a bonus to the damage roll that increases as you gain levels as a barbarian, as shown in the Rage Damage column of the Barbarian table." +
                "\n- You have resistance to bludgeoning, piercing, and slashing damage." +
                "\nIf you are able to cast spells, you can’t cast them or concentrate on them while raging." +
                "\nYour rage lasts for 1 minute.It ends early if you are knocked unconscious or if your turn ends and you haven’t attacked a hostile creature since your last turn or taken damage since then. You can also end your rage on your turn as a bonus action." +
                "\nOnce you have raged the number of times shown for your barbarian level in the Rages column of the Barbarian table, you must finish a long rest before you can rage again." },
            { "Unarmored Defense", "While you are not wearing any armor, your Armor Class equals 10 + your Dexterity modifier + your Constitution modifier. You can use a shield and still gain this benefit." }
        };

        public int setSpellAttackMod(int proficiency, Dictionary<string, int> modifiers) => 0;

        public int setSpellSaveDC(int proficiency, Dictionary<string, int> modifiers) => 0;

        public List<string> setLanguages() => null;

        public string setReason() => reasons[NumberGen.gen(reasons.Count)];
    }
}