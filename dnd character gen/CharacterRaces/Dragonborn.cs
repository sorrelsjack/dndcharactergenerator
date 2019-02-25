using System.Collections.Generic;
using System.Linq;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterRaces
{
    public class Dragonborn : ICharacterRace
    {
        private Dictionary<string, string> _dragons = new Dictionary<string, string>
        {
            { "Black", "Acid" },
            { "Blue", "Lightning" },
            { "Brass", "Fire" },
            { "Bronze", "Lightning" },
            { "Copper", "Acid" },
            { "Gold", "Fire" },
            { "Green", "Poison" },
            { "Red", "Fire" },
            { "Silver", "Cold" },
            { "White", "Cold" }
        };

        private List<string> maleNames = new List<string>
        {
            "Arjhan", "Balasar", "Bharash", "Donaar", "Ghesh", "Heskan", "Kriv", "Medrash", "Mehen", "Nadarr", "Pandjed", "Patrin", "Rhogar", "Shamash", "Shedinn", "Tarhun", "Torinn"
        };

        private List<string> femaleNames = new List<string>
        {
            "Akra", "Biri", "Daar", "Farideh", "Harann", "Havilar", "Jheri", "Kava", "Korinn", "Mishann", "Nala", "Perra", "Raiann", "Sora", "Surina", "Thava", "Uadjit"
        };

        public Dictionary<string, int> setAbilityScores() => new Dictionary<string, int>
        {
            { "Strength", 2 },
            { "Charisma", 1 }
        };

        public Dictionary<string, string> setFeatures()
        {
            var selectedDragon = selectDragon();
            Dictionary<string, string> features = new Dictionary<string, string>
            {
                { "Draconic Ancestry", $"You have draconic ancestry from a {selectedDragon[0]}, granting you a breath weapon of the {selectedDragon[1]} damage type." },
                { "Damage Resistance", "You have resistance to the damage type associated with your draconic ancestry." }
            };

            return features;
        }

        private string[] selectDragon()
        {
            var dragon = _dragons.ElementAt(NumberGen.gen(_dragons.Count));
            return new string[] { dragon.Key, dragon.Value };
        }

        public List<string> setLanguages() => new List<string> { "Common", "Draconic" };

        public string setName() => NumberGen.gen(2) == 0
            ? femaleNames[NumberGen.gen(femaleNames.Count)]
            : maleNames[NumberGen.gen(maleNames.Count)];

        public string setSize() => "Medium";

        public int setSpeed() => 30;

        public List<string> setToolsProf() => null;

        public List<string> setWeaponProf() => null;

        public int setHitPointModifier() => 0;

        public List<string> setArmorProf() => null;

        public List<string> setSkills() => null;
    }
}