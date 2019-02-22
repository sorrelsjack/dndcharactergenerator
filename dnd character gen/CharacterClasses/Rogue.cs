using System.Collections.Generic;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterClasses
{
    public class Rogue : ICharacterClass
    {
        public List<string> setArmorProf() => new List<string> { "Light armor" };

        public List<string> setEquipment()
        {
            List<string> equipment = new List<string>();
            int randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 0
                ? "Rapier" : "Shortsword");

            randomNumber = NumberGen.gen(2);
            if (randomNumber == 0)
            {
                equipment.Add("Shortbow");
                equipment.Add("Quiver of 20 arrows");
            }
            else
            {
                equipment.Add("Shortsword");
            }

            randomNumber = NumberGen.gen(3);
            if (randomNumber == 0)
                equipment.Add("Burglar's pack");
            else if (randomNumber == 1)
                equipment.Add("Dungeoneer's pack");
            else if (randomNumber == 2)
                equipment.Add("Explorer's pack");

            equipment.Add("Leather armor");
            equipment.Add("Two daggers");
            equipment.Add("Thieves' tools");

            return equipment;
        }

        public Dictionary<string, string> setFeatures()
        {
            Dictionary<string, string> features = new Dictionary<string, string> //TODO deal with this
            {
                { "Expertise", "-Choose two skill proficiencies or one skill proficiency and thieves' tool proficiency and double their proficiency bonus" },
                { "Sneak Attack", "-Once per turn, can deal an extra 1d6 to one creature hit with an attack if you have advantage on attack roll. Must use finesse or ranged weapon" },
                { "Thieves' Cant", "-Secret rogue language that can convey short, simple messages" }
            };

            return features;
        }

        public int setHitDie() => 8;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setLanguages() => new List<string> { "Thieves' Cant" };

        public string setPrimaryStat() => "Dexterity";

        public List<string> setSaves() => new List<string> { "Dexterity", "Intelligence" };

        public List<string> setSkills()
        {
            List<string> skillProficiencies = new List<string>();
            List<string> availableSkills = new List<string>()
                { "Acrobatics", "Athletics", "Deception", "Insight", "Intimidation", "Investigation", "Perception", "Performance", "Persuasion", "Sleight of Hand", "Stealth" };

            string skill = availableSkills[NumberGen.gen(11)];
            skillProficiencies.Add(skill);
            availableSkills.Remove(skill);

            skill = availableSkills[NumberGen.gen(10)];
            skillProficiencies.Add(skill);
            availableSkills.Remove(skill);

            skill = availableSkills[NumberGen.gen(9)];
            skillProficiencies.Add(skill);
            availableSkills.Remove(skill);

            skill = availableSkills[NumberGen.gen(8)];
            skillProficiencies.Add(skill);

            return skillProficiencies;
        }

        public int setSpellAttackMod(int proficiency, Dictionary<string, int> modifiers) => 0;

        public int setSpellSaveDC(int proficiency, Dictionary<string, int> modifiers) => 0;

        public string setSubType() => null;

        public List<string> setToolsProf() => new List<string> { "Thieves' Tools" };

        public List<string> setWeaponProf() => new List<string> { "Simple weapons", "Hand crossbows", "Longswords", "Rapiers", "Shortswords" };
    }
}