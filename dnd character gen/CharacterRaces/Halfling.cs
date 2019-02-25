using System.Collections.Generic;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterRaces
{
    public class Halfling : ICharacterRace
    {
        private List<string> maleNames = new List<string>
        {
            "Alton", "Ander", "Cade", "Corrin", "Eldon", "Errich", "Finnan", "Garret", "Lindal",
            "Lyle", "Merric", "Milo", "Osborn", "Perrin", "Reed", "Roscoe", "Wellby"
        };

        private List<string> femaleNames = new List<string>
        {
            "Andry", "Bree", "Callie", "Cora", "Euphemia", "Jillian", "Kithri", "Lavinia", "Lidda",
            "Merla", "Nedda", "Paela", "Portia", "Seraphina", "Shaena", "Trym", "Vani", "Verna"
        };

        public virtual Dictionary<string, int> setAbilityScores() => new Dictionary<string, int>
        {
            { "Dexterity", 2 }
        };

        public List<string> setArmorProf() => null;

        public virtual Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Lucky", "When you roll a 1 on the d20 for an attack roll, ability check, or saving throw, you can reroll the die and must use the new roll." },
            { "Brave", "You have advantage on saving throws against being frightened." },
            { "Halfling Nimbleness", "You can move through the space of any creature that is of a size larger than yours." }
        };

        public int setHitPointModifier() => 0;

        public List<string> setLanguages() => new List<string>() { "Common", "Halfling" };

        public string setName() => NumberGen.gen(2) == 0
            ? femaleNames[NumberGen.gen(femaleNames.Count)]
            : maleNames[NumberGen.gen(maleNames.Count)];

        public string setSize() => "Small";

        public List<string> setSkills() => null;

        public int setSpeed() => 25;

        public List<string> setToolsProf() => null;

        public List<string> setWeaponProf() => null;
    }
}