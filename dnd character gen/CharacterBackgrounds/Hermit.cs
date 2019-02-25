using System.Collections.Generic;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterBackgrounds
{
    //TODO: Fill out using PHB
    public class Hermit : ICharacterBackground {
        private List<string> livesOfSeclusion = new List<string> 
        {
            "I was searching for spiritual enlightenment.",
            "I was partaking in communal living in accordance with dictates of a religious order.",
            "I was exiled for a crime I didn't commit.",
            "I retreated from society after a life-altering event.",
            "I needed a quiet place to work on my art, literature, music, or manifesto.",
            "I needed to commune with nature, far from civilization.",
            "I was the caretaker of an ancient ruin or relic.",
            "I was a pilgrim in search of a person, place, or relic of spiritual significance."
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
        {
            "Scroll case stuffed full of notes from your studies or prayers", "Winter blanket",
            "Set of common clothes", "Herbalism kit", "5 gp"
        };

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string> 
        {
            { "Discovery", "The quiet seclusion of your extended hermitage gave you access to a unique and pow erful discovery. The exact nature of this revelation depends on the nature of your seclusion. Work with your DM to determine the details of your discovery and its impact on the campaign." }
        };

        public string setFlaw() => flaws[NumberGen.gen(flaws.Count)];

        public string setIdeal() => ideals[NumberGen.gen(ideals.Count)];

        public List<string> setLanguages() => new List<string> { Languages.Instance.languages[NumberGen.gen(Languages.Instance.languages.Count)] };

        public string setPersonalityTrait() => personalityTraits[NumberGen.gen(personalityTraits.Count)];

        public List<string> setSkills() => new List<string> { "Medicine", "Religion" };

        public Dictionary<string, string> setSpecial() => new Dictionary<string, string> 
        {
            { "Life of Seclusion", $"{livesOfSeclusion[NumberGen.gen(livesOfSeclusion.Count)]}" }
        };

        public List<string> setToolsProf() => new List<string> { "Herbalism kit" };
    }
}