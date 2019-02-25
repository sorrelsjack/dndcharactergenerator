using System.Collections.Generic;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterBackgrounds
{
    //TODO: Fill out using PHB
    public class Outlander : ICharacterBackground {
        private List<string> origins = new List<string> 
        {
            "Forester", "Trapper", "Homesteader", "Guide", "Exile or outcast",
            "Bounty hunter", "Pilgrim", "Tribal nomad", "Hunter-gatherer", "Tribal marauder"
        };

        private List<string> personalityTraits = new List<string> 
        {

        };

        private List<string> ideals = new List<string> 
        {

        };

        private List<string> bonds = new List<string> 
        {

        };

        private List<string> flaws = new List<string> 
        {

        };

        public string setBond() => bonds[NumberGen.gen(bonds.Count)];

        public List<string> setEquipment() => new List<string>
        { "Staff", "Hunting trap", "Trophy from an animal you killed", "Set of traveler's clothes", "Belt pouch containing 10 gp" };

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string> 
        {
            { "Wanderer", "You have an excellent memory for maps and geography, and you can always recall the general layout of terrain, settlements, and other features around you. In addition, you can find food and fresh water for yourself and up to five other people each day, provided that the land offers berries, small game, water, and so forth." }
        };

        public string setFlaw() => flaws[NumberGen.gen(flaws.Count)];

        public string setIdeal() => ideals[NumberGen.gen(ideals.Count)];

        public List<string> setLanguages() => new List<string> { Languages.Instance.languages[NumberGen.gen(Languages.Instance.languages.Count)] };

        public string setPersonalityTrait() => personalityTraits[NumberGen.gen(personalityTraits.Count)];

        public List<string> setSkills() => new List<string> { "Athletics", "Survival" };

        public Dictionary<string, string> setSpecial() => new Dictionary<string, string> 
        {
            { "Origin", $"{origins[NumberGen.gen(origins.Count)]}" }
        };

        public List<string> setToolsProf() => new List<string> { MusicalInstruments.Instance.instruments[NumberGen.gen(MusicalInstruments.Instance.instruments.Count)] };
    }
}