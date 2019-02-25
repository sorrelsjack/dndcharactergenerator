using System.Collections.Generic;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterBackgrounds
{
    //TODO: Fill out using PHB
    public class Sailor : ICharacterBackground {
        private List<string> luckyCharms = new List<string> { "Rabbit foot", "Small stoe with a hole in the center" }; //TODO: Can have trinket

        private List<string> personalityTraits = new List<string> 
        {
            "My friends know they can rely on me, no matter what.",
            "I work hard so that I can play hard when the work is done.",
            "I enjoy sailing into new ports and making new friends over a flagon of ale.",
            "I stretch the truth for the sake of a good story.",
            "To me, a tavern brawl is a nice way to get to know a new city.",
            "I never pass up a friendly wager.",
            "My language is as foul as an otyugh nest.",
            "I like a job well done, especially if I can convince someone else to do it."
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
            "Belaying pin (club)", "50 ft of silk rope", $"{luckyCharms[NumberGen.gen(luckyCharms.Count)]}",
            "Set of common clothes", "Belt pouch containing 10 gp"
        };

        public virtual Dictionary<string, string> setFeatures() => new Dictionary<string, string> 
        {
            { "Ship's Passage", "When you need to, you can secure free passage on a sailing ship for yourself and your adventuring companions. You might sail on the ship you served on, or another ship you have good relations with (perhaps one captained by a former crewmate). Because you’re calling in a favor, you can’t be certain of a schedule or route that will meet your every need. Your Dungeon Master will determine how long it takes to get where you need to go. In return for your free passage, you and your companions are expected to assist the crew during the voyage." }
        };

        public string setFlaw() => flaws[NumberGen.gen(flaws.Count)];

        public string setIdeal() => ideals[NumberGen.gen(ideals.Count)];

        public List<string> setLanguages() => null;

        public string setPersonalityTrait() => personalityTraits[NumberGen.gen(personalityTraits.Count)];

        public List<string> setSkills() => new List<string> { "Athletics", "Perception" };

        public Dictionary<string, string> setSpecial() => null;

        public List<string> setToolsProf() => new List<string> { "Navigator's tools", "Vehicles (water)" };
    }
}