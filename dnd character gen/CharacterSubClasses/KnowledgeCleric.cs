using System.Collections.Generic;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterSubClasses
{
    public class KnowledgeCleric : ICharacterSubClass
    {
        public List<string> setArmorProf() => null;

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Blessing of Knowledge", "At 1st level, you learn two languages of your choice. You also become proficient in your choice of two of the following skills: Arcana, History, Nature, or Religion." +
                "\nYour proficiency bonus is doubled for any ability check you make that uses either of those skills." }
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