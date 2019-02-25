using System.Collections.Generic;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterBackgrounds
{
    //TODO: Fill out using PHB
    public class Urchin : ICharacterBackground {

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
        {
            "Small knife", "Map of the city you grew up in", "Pet mouse",
            "Token to remember your parents by", "Set of common clothes", "Belt pouch containing 10 gp"
        };

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string> 
        {
            { "City Secrets", "You know the secret patterns and flow to cities and can find passages through the urban sprawl that others would miss. When you are not in combat, you (and companions you lead) can travel between any two locations in the city twice as fast as your speed would normally allow." }
        };

        public string setFlaw() => flaws[NumberGen.gen(flaws.Count)];

        public string setIdeal() => ideals[NumberGen.gen(ideals.Count)];

        public List<string> setLanguages() => null;

        public string setPersonalityTrait() => personalityTraits[NumberGen.gen(personalityTraits.Count)];

        public List<string> setSkills() => new List<string> { "Sleight of Hand", "Stealth" };

        public Dictionary<string, string> setSpecial() => null;

        public List<string> setToolsProf() => new List<string> { "Disguise kit", "Thieves' tools" };
    }
}