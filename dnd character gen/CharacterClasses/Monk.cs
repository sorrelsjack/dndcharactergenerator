using System.Collections.Generic;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterClasses
{
    internal class Monk : ICharacterClass
    {
        public List<string> setArmorProf() => null;

        public List<string> setEquipment()
        {
            List<string> equipment = new List<string>();
            int randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 1
                ? "Shortsword" : SimpleWeapons.Instance.weapons[NumberGen.gen(SimpleWeapons.Instance.weapons.Count)]);

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 1
                ? "Dungeoneer's pack" : "Explorer's pack");

            equipment.Add("10 Darts");

            return equipment;
        }

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            {"Unarmored Defense", "-While wearing no armor or shield, AC is 10 + Dexterity modifier + Wisdom modifier." },
            { "Martial Arts", "-Mastery of combat styles using unarmed strikes and monk weapons.\n-Can use Dexterity instead of strength for attack and damage rolls" +
              "\n-Can roll d4 in place of normal damage. \n-Can make an unarmed strike as a bonus action." }
        };

        public int setHitDie() => 8;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setLanguages() => null;

        public string setPrimaryStat() => "Dexterity";

        public List<string> setSaves() => new List<string>() { "Strength", "Dexterity" };

        public List<string> setSkills()
        {
            List<string> skillProficiencies = new List<string>();
            List<string> availableSkills = new List<string>()
            { "Acrobatics", "Athletics", "History", "Insight", "Religion", "Stealth" };

            string skill = availableSkills[NumberGen.gen(6)];
            skillProficiencies.Add(skill);
            availableSkills.Remove(skill);

            skill = availableSkills[NumberGen.gen(5)];
            skillProficiencies.Add(skill);

            return skillProficiencies;
        }

        public int setSpellAttackMod(int proficiency, Dictionary<string, int> modifiers) => 0;

        public int setSpellSaveDC(int proficiency, Dictionary<string, int> modifiers) => 0;

        public string setSubType() => null;

        public List<string> setToolsProf()
        {
            List<string> toolProficiencies = new List<string>();

            toolProficiencies.Add(ArtisansTools.Instance.tools[NumberGen.gen(ArtisansTools.Instance.tools.Count)]);
            toolProficiencies.Add(MusicalInstruments.Instance.instruments[NumberGen.gen(MusicalInstruments.Instance.instruments.Count)]);

            return toolProficiencies;
        }

        public List<string> setWeaponProf()
        {
            List<string> weaponProficiencies = new List<string>();

            weaponProficiencies.Add("Simple weapons");
            weaponProficiencies.Add("Shortswords");

            return weaponProficiencies;
        }
    }
}