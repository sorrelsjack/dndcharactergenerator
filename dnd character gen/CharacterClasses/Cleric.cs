using System.Collections.Generic;
using dnd_character_gen.CharacterSubClasses;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterClasses
{
    public class Cleric : ICharacterClass
    {
        private string domain;
        private ICharacterSubClass subClass;

        private List<string> _armorProficiencies = new List<string>();
        private List<string> _languageProficiencies = new List<string>();
        private List<string> _weaponProficiencies = new List<string>();
        private List<string> _skillProficiencies = new List<string>();
        private Dictionary<string, string> _features = new Dictionary<string, string>();

        public List<string> setArmorProf()
        {
            _armorProficiencies.AddRange(new List<string>() { "Light armor", "Medium armor", "Shields" });
            return _armorProficiencies;
        }

        public List<string> setEquipment()
        {
            int randomNumber = 0;
            List<string> equipment = new List<string>();

            equipment.Add(_weaponProficiencies.Contains("Martial weapons") ? "Warhammer" : "Mace");

            if (!_armorProficiencies.Contains("Chain mail"))
            {
                randomNumber = NumberGen.gen(2);
                equipment.Add(randomNumber == 1 ? "Scale mail" : "Leather armor");
            }
            else
            {
                equipment.Add("Chain mail");
            }

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 1
                ? "Light crossbow and 20 bolts" : SimpleWeapons.Instance.weapons[NumberGen.gen(SimpleWeapons.Instance.weapons.Count)]);

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 1 ? "Priest's pack" : "Explorer's pack");

            equipment.Add("Shield");
            equipment.Add("Holy Symbol");

            return equipment;
        }

        public Dictionary<string, string> setFeatures()
        {
            Dictionary<string, string> features = new Dictionary<string, string>
            {
                { "Spellcasting", "-Oh you know" },
                { "Divine Domain", "-Choose a domain related to a deity from which you draw your power (Knowledge, Life, Light, Nature, Tempest, Trickery, War)" }
            };

            foreach (KeyValuePair<string, string> pair in features)
                _features.Add(pair.Key, pair.Value);

            return _features;
        }

        public int setHitDie() => 8;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setLanguages() => null;

        public string setPrimaryStat() => "Wisdom";

        public List<string> setSaves() => new List<string>() { "Wisdom", "Charisma" };

        public List<string> setSkills()
        {
            int skillsAdded = 0;
            List<string> availableSkills = new List<string>()
            { "History", "Insight", "Medicine", "Persuasion", "Religion" };

            while (skillsAdded != 2)
            {
                string skill = availableSkills[NumberGen.gen(5)];
                if (!_skillProficiencies.Contains(skill))
                {
                    _skillProficiencies.Add(skill);
                    availableSkills.Remove(skill);
                    skillsAdded++;
                }

                skill = availableSkills[NumberGen.gen(4)];
                if (!_skillProficiencies.Contains(skill))
                {
                    _skillProficiencies.Add(skill);
                    skillsAdded++;
                }
            }

            return _skillProficiencies;
        }

        public int setSpellAttackMod(int proficiency, Dictionary<string, int> modifiers) => proficiency + modifiers["Wisdom"];

        public int setSpellSaveDC(int proficiency, Dictionary<string, int> modifiers) => 8 + proficiency + modifiers["Wisdom"];

        public string setSubType()
        {
            List<string> domains = new List<string>() { "Knowledge", "Life", "Light", "Nature", "Tempest", "Trickery", "War" };

            domain = domains[NumberGen.gen(7)];

            if (domain == "Knowledge")
                subClass = new KnowledgeCleric();
            else if (domain == "Life")
                subClass = new LifeCleric();
            else if (domain == "Light")
                subClass = new LightCleric();
            else if (domain == "Nature")
                subClass = new NatureCleric();
            else if (domain == "Tempest")
                subClass = new TempestCleric();
            else if (domain == "Trickery")
                subClass = new TrickeryCleric();
            else if (domain == "War")
                subClass = new WarCleric();

            initializeSubType();

            return domain;
        }

        private void initializeSubType()
        {
            foreach (var feature in subClass.setFeatures())
                _features.Add(feature.Key, feature.Value);

            var subClassArmorProf = subClass.setArmorProf();
            if (subClassArmorProf != null)
                _armorProficiencies.AddRange(subClassArmorProf);

            var subClassWeaponProf = subClass.setWeaponProf();
            if (subClassArmorProf != null)
                _weaponProficiencies.AddRange(subClassWeaponProf);

            var subClassLanguageProf = subClass.setLanguageProf();
            if (subClassLanguageProf != null)
                _languageProficiencies.AddRange(subClassLanguageProf);

            var subClassSkillProf = subClass.setSkillProf();
            if (subClassSkillProf != null)
                _skillProficiencies.AddRange(subClassSkillProf);
        }

        public List<string> setToolsProf() => null;

        public List<string> setWeaponProf()
        {
            _armorProficiencies.AddRange(new List<string> { "Simple weapons" });
            return _armorProficiencies;
        }
    }
}