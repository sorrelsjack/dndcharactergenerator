using System.Collections.Generic;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterRaces
{
    public class Gnome : ICharacterRace
    {
        private List<string> maleNames = new List<string>
        {
            "Alston", "Alvyn", "Boddynock", "Brocc", "Burgell", "Dimble", "Eldon", "Erky", "Fonkin",
            "Frug", "Gerbo", "Gimble", "Glim", "Jebeddo", "Kellen", "Namfoodle", "Orryn", "Roondar",
            "Seebo", "Sindri", "Warryn", "Wrenn", "Zook"
        };

        private List<string> femaleNames = new List<string>
        {
            "Bimpnottin", "Breena", "Caramip", "Carlin", "Donella", "Duvamil", "Ella", "Ellyjobell",
            "Ellywick", "Lilli", "Loopmottin", "Lorilla", "Mardnab", "Nissa", "Nyx", "Oda", "Orla",
            "Roywyn", "Shamil", "Tana", "Waywocket", "Zanna"
        };

        public virtual Dictionary<string, int> setAbilityScores() => new Dictionary<string, int> { { "Intelligence", 2 } };

        public List<string> setArmorProf() => null;

        public virtual Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Darkvision", "Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray." },
            { "Gnome Cunning", "You have advantage on all Intelligence, Wisdom, and Charisma saving throws against magic." }
        };

        public int setHitPointModifier() => 0;

        public virtual List<string> setLanguages() => new List<string> { "Common", "Gnomish" };

        public string setName() => NumberGen.gen(2) == 0
            ? femaleNames[NumberGen.gen(femaleNames.Count)]
            : maleNames[NumberGen.gen(maleNames.Count)];

        public string setSize() => "Small";

        public List<string> setSkills() => null;

        public int setSpeed() => 25;

        public virtual List<string> setToolsProf() => null;

        public List<string> setWeaponProf() => null;
    }
}