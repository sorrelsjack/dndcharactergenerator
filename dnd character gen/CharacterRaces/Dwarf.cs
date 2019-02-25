using System.Collections.Generic;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterRaces
{
    public class Dwarf : ICharacterRace
    {
        private List<string> maleNames = new List<string>
        {
            "Adrik", "Alberich", "Baern", "Barendd", "Brottor", "Bruenor", "Dain", "Darrak", "Delg", "Eberk", "Einkil", "Fargrim",
            "Flint", "Gardain", "Harbek", "Kildrak", "Morgran", "Orsik", "Oskar", "Rangrim", "Rurik", "Taklinn", "Thoradin", "Thorin",
            "Tordek", "Traubon", "Travok", "Ulfgar", "Veit", "Vondal"
        };

        private List<string> femaleNames = new List<string>
        {
            "Amber", "Artin", "Audhild", "Bardryn", "Dagnal", "Diesa", "Eldeth", "Falkrunn", "Finellen", "Gunnloda", "Gurdis", "Helja",
            "Hlin", "Kathra", "Kristryd", "Ilde", "Mardred", "Riswynn", "Sannl", "Torbera", "Torgga", "Vistra"
        };

        private List<string> toolProficiencies = new List<string>
        {
            "Smith's tools", "Brewer's supplies", "Mason's tools"
        };

        public virtual Dictionary<string, int> setAbilityScores() => new Dictionary<string, int>
        {
            { "Constitution", 2 }
        };

        public virtual List<string> setArmorProf() => null;

        public virtual Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Darkvision", "Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray." },
            { "Dwarven Resilience", "You have advantage on saving throws against poison, and you have resistance against poison damage." },
            { "Dwarven Combat Training", "You have proficiency with the battleaxe, handaxe, light hammer, and warhammer." },
            { "Stonecunning", "Whenever you make an Intelligence (History) check related to the origin of stonework, you are considered proficient in the History skill and add double your proficiency bonus to the check, instead of your normal proficiency bonus." }
        };

        public virtual int setHitPointModifier() => 0;

        public List<string> setLanguages() => new List<string> { "Common", "Dwarvish" };

        public string setName() => NumberGen.gen(2) == 0
            ? femaleNames[NumberGen.gen(femaleNames.Count)]
            : maleNames[NumberGen.gen(maleNames.Count)];

        public string setSize() => "Medium";

        public List<string> setSkills() => null;

        public int setSpeed() => 25;

        public List<string> setToolsProf() => new List<string> { toolProficiencies[NumberGen.gen(toolProficiencies.Count)] };

        public List<string> setWeaponProf() => new List<string> { "Battleaxe", "Handaxe", "Light hammer", "Warhammer" }; //TODO: On classes, pass all simple weapons if proficient
    }
}