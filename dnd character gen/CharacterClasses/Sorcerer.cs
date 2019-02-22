using System.Collections.Generic;
using dnd_character_gen.CharacterSubClasses;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterClasses
{
    public class Sorcerer : ICharacterClass
    {
        private string origin;
        private ICharacterSubClass subClass;

        private Dictionary<string, string> _features = new Dictionary<string, string>();
        private List<string> _languageProficiencies = new List<string>();

        public List<string> setArmorProf() => null;

        public List<string> setEquipment()
        {
            List<string> equipment = new List<string>();
            int randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 0
                ? "Light crossbow and 20 bolts" : SimpleWeapons.Instance.weapons[NumberGen.gen(SimpleWeapons.Instance.weapons.Count)]);

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 0
                ? "Component pouch" : "Arcane focus");

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 0
                ? "Dungeoneer's pack" : "Explorer's pack");

            equipment.Add("Two daggers");

            return equipment;
        }

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Spellcasting", "-Oh you know." },
            { "Sorcerous Origin", "-Choose a sorcerous origin." }
        };

        public int setHitDie() => 6;

        public int setHitPoints(int hitDie, int constitution) => origin != "Draconic Bloodline" ? hitDie + constitution : hitDie + constitution + 1; //For first level characters, of course.

        public List<string> setLanguages() => _languageProficiencies;

        public string setPrimaryStat() => "Charisma";

        public List<string> setSaves() => new List<string> { "Constitution", "Charisma" };

        public List<string> setSkills()
        {
            List<string> skillProficiencies = new List<string>();
            List<string> availableSkills = new List<string>()
                { "Arcana", "Deception", "Insight", "Intimidation", "Persuasion", "Religion" };

            string skill = availableSkills[NumberGen.gen(6)];
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

        public string setSubType()
        {
            List<string> origins = new List<string> { "Draconic Bloodline", "Wild Magic" };

            origin = origins[NumberGen.gen(2)];
            if (origin == "Draconic Bloodline")
                subClass = new DraconicBloodlineSorcerer();
            else if (origin == "Wild Magic")
                subClass = new WildMagicSorcerer();

            initializeSubType();

            return origin;
        }

        private void initializeSubType()
        {
            foreach (var feature in subClass.setFeatures()) //TODO fix a "key already added" issue here
                _features.Add(feature.Key, feature.Value);

            var subClassLanguageProf = subClass.setLanguageProf();
            if (subClassLanguageProf != null)
                _languageProficiencies.AddRange(subClassLanguageProf);
        }

        public List<string> setToolsProf() => null;

        public List<string> setWeaponProf() => new List<string> { "Daggers", "Darts", "Slings", "Quarterstaffs", "Light Crossbows" };
    }
}