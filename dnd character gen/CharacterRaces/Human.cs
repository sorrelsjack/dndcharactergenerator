using System.Collections.Generic;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterRaces
{
    public class Human : ICharacterRace
    {
        public virtual Dictionary<string, int> setAbilityScores() => new Dictionary<string, int>
        {
            { "Strength", 1 },
            { "Dexterity", 1 },
            { "Constitution", 1 },
            { "Intelligence", 1 },
            { "Wisdom", 1 },
            { "Charisma", 1 }
        };

        public List<string> setArmorProf() => null;

        public virtual Dictionary<string, string> setFeatures() => null;

        public int setHitPointModifier() => 0;

        public List<string> setLanguages()
        {
            List<string> languages = new List<string> { "Common" };
            string language = "";

            while (languages.Count < 2)
            {
                language = Languages.Instance.languages[NumberGen.gen(Languages.Instance.languages.Count)];

                if (!languages.Contains(language))
                    languages.Add(language);
            }

            return languages;
        }

        public string setName() => null; //TODO: Human names

        public string setSize() => "Medium";

        public List<string> setSkills() => null;

        public virtual int setSpeed() => 30;

        public virtual List<string> setToolsProf() => null;

        public List<string> setWeaponProf() => null;
    }
}