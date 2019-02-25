using System.Collections.Generic;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterRaces
{
    public class HalfOrc : ICharacterRace
    {
        private List<string> maleNames = new List<string>
        {
            "Dench", "Feng", "Gell", "Henk", "Holg", "Imsh", "Keth", "Krusk", "Mhurren", "Ront", "Shump", "Thokk"
        };

        private List<string> femaleNames = new List<string>
        {
            "Baggi", "Emen", "Engong", "Kansif", "Myev", "Neega", "Ovak", "Ownka", "Shautha", "Sutha", "Vola", "Volen", "Yevelda"
        };

        public virtual Dictionary<string, int> setAbilityScores() => new Dictionary<string, int>
        {
            { "Strength", 2 },
            { "Constitution", 1 }
        };

        public List<string> setArmorProf() => null;

        public virtual Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Darkvision",  "Thanks to your orc blood, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray." },
            { "Menacing", "You gain proficiency in the Intimidation skill." },
            { "Relentless Endurance", "When you are reduced to 0 hit points but not killed outright, you can drop to 1 hit point instead. You can’t use this feature again until you finish a long rest." },
            { "Savage Attacks", "When you score a critical hit with a melee weapon attack, you can roll one of the weapon’s damage dice one additional time and add it to the extra damage of the critical hit." }
        };

        public int setHitPointModifier() => 0;

        public List<string> setLanguages() => new List<string> { "Common", "Orcish" };

        public string setName() => NumberGen.gen(2) == 0
            ? femaleNames[NumberGen.gen(femaleNames.Count)]
            : maleNames[NumberGen.gen(maleNames.Count)];

        public string setSize() => "Medium";

        public virtual List<string> setSkills() => new List<string> { "Intimidation" };

        public int setSpeed() => 30;

        public List<string> setToolsProf() => null;

        public List<string> setWeaponProf() => null;
    }
}