using System.Collections.Generic;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterSubClasses
{
    public class KnowledgeCleric : ICharacterSubClass //TODO: knowledge cleric
    {
        public List<string> setArmorProf() => null;

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Blessing of Knowledge", "-Learn two languages\n-Become proficient in Arcana, History, Nature, or Religion\n-Proficiency bonus is doubled for either of the chosen skills" }
        };

        public List<string> setLanguageProf()
        {
            List<string> languages = new List<string>();
            string language;

            while (languages.Count < 2)
            {
                language = Languages.Instance.languages[NumberGen.gen(Languages.Instance.languages.Count)];
                if (!languages.Contains(language))
                    languages.Add(language);
            }

            return languages;
        }

        public List<string> setSkillProf()
        {
            List<string> skillProficiencies = new List<string>();
            List<string> availableSkills = new List<string>()
                { "Arcana", "History", "Nature", "Religion"};

            string skill = availableSkills[NumberGen.gen(4)];
            skillProficiencies.Add(skill);
            availableSkills.Remove(skill);

            skill = availableSkills[NumberGen.gen(3)];
            skillProficiencies.Add(skill);

            return skillProficiencies;
        }

        public List<string> setWeaponProf() => null;
    }
}