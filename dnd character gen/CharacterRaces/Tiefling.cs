using System.Collections.Generic;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterRaces
{
    public class Tiefling : ICharacterRace
    {
        private List<string> maleNames = new List<string>
        {
            "Akmenos", "Amnon", "Barakas", "Damakos", "Ekemon", "Iados", "Kairon", "Leucis",
            "Melech", "Mordai", "Morthos", "Pelaios", "Skamos", "Therai"
        };

        private List<string> femaleNames = new List<string>
        {
            "Akta", "Anakis", "Bryseis", "Criella", "Damaia", "Ea", "Kallista", "Lerissa",
            "Makaria", "Nemeia", "Orianna", "Phelaia", "Rieta"
        };

        private List<string> virtueNames = new List<string>
        {
            "Art", "Carrion", "Chant", "Creed", "Despair", "Excellence", "Fear", "Glory", "Hope",
            "Ideal", "Music", "Nowhere", "Open", "Poetry", "Quest", "Random", "Reverence", "Sorrow",
            "Temerity", "Torment", "Weary"
        };

        public Dictionary<string, int> setAbilityScores() => new Dictionary<string, int>
        {
            { "Intelligence", 1 },
            { "Charisma", 2 }
        };

        public List<string> setArmorProf() => null;

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Darkvision", "Thanks to your infernal heritage, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray." },
            { "Hellish Resistance", "You have resistance to fire damage." },
            { "Infernal Legacy", "You know the thaumaturgy cantrip. When you reach 3rd level, you can cast the hellish rebuke spell as a 2nd-level spell once with this trait and regain the ability to do so when you finish a long rest. When you reach 5th level, you can cast the darkness spell once with this trait and regain the ability to do so when you finish a long rest. Charisma is your spellcasting ability for these spells." }
        };

        public int setHitPointModifier() => 0;

        public List<string> setLanguages() => new List<string> { "Common", "Infernal" };

        public string setName()
        {
            int randomNumber = NumberGen.gen(3);
            string name = "";

            if (randomNumber == 0)
                name = maleNames[NumberGen.gen(maleNames.Count)];
            else if (randomNumber == 1)
                name = femaleNames[NumberGen.gen(femaleNames.Count)];
            else if (randomNumber == 2)
                name = virtueNames[NumberGen.gen(virtueNames.Count)];

            return name;
        }

        public string setSize() => "Medium";

        public List<string> setSkills() => null;

        public int setSpeed() => 30;

        public List<string> setToolsProf() => null;

        public List<string> setWeaponProf() => null;
    }
}