﻿using System.Collections.Generic;
using dnd_character_gen.CharacterSubClasses;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterClasses
{
    public class Fighter : ICharacterClass
    {
        private string fightingStyle;
        private ICharacterSubClass subClass;

        private Dictionary<string, string> _features = new Dictionary<string, string>();

        public List<string> setArmorProf() => new List<string> { "Light armor", "Medium armor", "Heavy armor", "Shields" };

        public List<string> setEquipment()
        {
            List<string> equipment = new List<string>();

            int randomNumber = NumberGen.gen(2);
            if (randomNumber == 1)
                equipment.Add("Chain mail");
            else
            {
                equipment.Add("Leather armor");
                equipment.Add("Longbow");
                equipment.Add("20 arrows");
            }

            randomNumber = NumberGen.gen(2);
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
                ? "Light crossbow and 20 bolts" : "Two handaxes");

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 1
                ? "Dungeoneer's pack" : "Explorer's pack");

            equipment.Add("Explorer's Pack");
            equipment.Add("Four Javelins");

            return equipment;
        }

        public Dictionary<string, string> setFeatures()
        {
            Dictionary<string, string> features = new Dictionary<string, string>
            {
                { "Fighting Style", "Adopt a fighting style as speciality (Archery, Defense, Dueling, Great Weapon Fighting, Protection, Two-Weapon Fighting" },
                { "Second Wind", "-On turn, can use a bonus action to regain HP equal to 1d10 + level\n-Can use once per short or long rest" }
            };

            foreach (KeyValuePair<string, string> pair in features)
                _features.Add(pair.Key, pair.Value);

            return _features;
        }

        public int setHitDie() => 10;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setLanguages() => null;

        public string setPrimaryStat() => NumberGen.gen(2) == 1 ? "Strength" : "Dexterity";

        public List<string> setSaves() => new List<string>() { "Strength", "Constitution" };

        public List<string> setSkills()
        {
            List<string> skillProficiencies = new List<string>();
            List<string> availableSkills = new List<string>()
                { "Acrobatics", "Animal Handling", "Athletics", "History", "Insight", "Intimidation", "Perception", "Survival" };

            string skill = availableSkills[NumberGen.gen(8)];
            skillProficiencies.Add(skill);
            availableSkills.Remove(skill);

            skill = availableSkills[NumberGen.gen(7)];
            skillProficiencies.Add(skill);

            return skillProficiencies;
        }

        public int setSpellAttackMod(int proficiency, Dictionary<string, int> modifiers) => 0;

        public int setSpellSaveDC(int proficiency, Dictionary<string, int> modifiers) => 0;

        public string setSubType()
        {
            List<string> fightingStyles = new List<string>()
            { "Archery", "Defense", "Dueling", "Great Weapon Fighting", "Protection", "Two-Weapon Fighting" };

            fightingStyle = fightingStyles[NumberGen.gen(6)];
            if (fightingStyle == "Archery")
                subClass = new ArcheryFighter();
            else if (fightingStyle == "Defense")
                subClass = new DefenseFighter();
            else if (fightingStyle == "Dueling")
                subClass = new DuelingFighter();
            else if (fightingStyle == "Great Weapon Fighting")
                subClass = new GreatWeaponFightingFighter();
            else if (fightingStyle == "Protection")
                subClass = new ProtectionFighter();
            else if (fightingStyle == "Two-Weapon Fighting")
                subClass = new TwoWeaponFightingFighter();

            initializeSubType();

            return fightingStyle;
        }

        private void initializeSubType()
        {
            foreach (var feature in subClass.setFeatures())
                _features.Add(feature.Key, feature.Value);
        }

        public List<string> setToolsProf() => null;

        public List<string> setWeaponProf() => new List<string> { "Simple weapons", "Martial weapons" };
    }
}