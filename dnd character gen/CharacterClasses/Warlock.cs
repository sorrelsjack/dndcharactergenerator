using System.Collections.Generic;
using dnd_character_gen.CharacterSubClasses;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterClasses
{
    public class Warlock : ICharacterClass
    {
        private string patron;
        private ICharacterSubClass subClass;

        private Dictionary<string, string> _features = new Dictionary<string, string>();

        public List<string> setArmorProf() => new List<string> { "Light armor" };

        public List<string> setEquipment()
        { 
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

        public List<string> setSkills()
        {
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

        public string setSubType()
        {
            List<string> patrons = new List<string>() { "Archfey", "Fiend", "Great Old One" };

            patron = patrons[NumberGen.gen(3)];
            if (patron == "Archfey")
                subClass = new ArchfeyWarlock();
            else if (patron == "Fiend")
                subClass = new FiendWarlock();
            else if (patron == "Great Old One")
                subClass = new GreatOldOneWarlock();

            initializeSubType();

            return patron;
        }

        private void initializeSubType() 
        {
            foreach (var feature in subClass.setFeatures())
                _features.Add(feature.Key, feature.Value);
        }

        public List<string> setToolsProf() => null;

        public List<string> setWeaponProf() => new List<string> { "Simple weapons" };
    }
}