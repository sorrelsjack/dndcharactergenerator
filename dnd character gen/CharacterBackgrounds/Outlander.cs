using System.Collections.Generic;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterBackgrounds
{
    public class Outlander : ICharacterBackground {
        private List<string> origins = new List<string> 
        {
            "Forester", "Trapper", "Homesteader", "Guide", "Exile or outcast",
            "Bounty hunter", "Pilgrim", "Tribal nomad", "Hunter-gatherer", "Tribal marauder"
        };

        private List<string> personalityTraits = new List<string> 
        {
            "I'm driven by a wanderlust that led me away from home.",
            "I watch over my friends as if they were a litter of newborn pups.",
            "I once ran twenty-five miles without stopping to warn to my clan of an approaching orc horde. I'd do it again if I had to.",
            "I have a lesson for everything situation, drawn from observing nature.",
            "I place no stock in wealthy or well-mannered folk. Money and manners won't save you from a hungry owlbear.",
            "I'm always picking things up, absently fiddling with them, and sometimes accidently breaking them.",
            "I feel far more comfortable around animals than people.",
            "I was, in fact, raised by wolves."
        };

        private List<string> ideals = new List<string> 
        {
            "Change. Life is like the seasons, in constant change, and we must change with it. (Chaotic)",
            "Greater Good. It is each person's responsibility to make the most happiness for the whole tribe. (Good)",
            "Honor. If I dishonor myself, I dishonor my whole clan. (Lawful)",
            "Might. The strongest are meant to rule. (Evil)",
            "Nature. The natural world is more important than all the constructs of civilization. (Neutral)",
            "Glory. I must earn glory in battle, for myself and my clan. (Any)"
        };

        private List<string> bonds = new List<string> 
        {
            "My family, clan, or tribe is the most important thing in my life, even when they are far from me.",
            "An injury to the unspoiled wilderness of my home is an injury to me.",
            "I will bring terrible wrath down on the evildoers who destroyed my homeland.",
            "I am the last of my tribe, and it is up to me to ensure their names enter legend.",
            "I suffer awful visions of a coming disaster and will do anything to prevent it.",
            "It is my duty to provide children to sustain my tribe."
        };

        private List<string> flaws = new List<string> 
        {
            "I am too enamored of ale, wine, and other intoxicants.",
            "There’s no room for caution in a life lived to the fullest.","I remember every insult I’ve received and nurse a silent resentment toward anyone who’s ever wronged me.",
            "I am slow to trust members of other races, tribes, and societies.",
            "Violence is my answer to almost any challenge.",
            "Don’t expect me to save those who can’t save themselves. It is nature’s way that the strong thrive and the weak perish."
        };

        private List<string> reasons = new List<string> 
        {
            "I spent a lot of time in the wilderness as a youngster, and I came to love that way of life.",
            "From a young age, I couldn’t abide the stink of the cities and preferred to spend my time in nature.",
            "I came to understand the darkness that lurks in the wilds, and I vowed to combat it.",
            "My people lived on the edges of civilization, and I learned the methods of survival from my family.",
            "After a tragedy I retreated to the wilderness, leaving my old life behind.",
            "My family moved away from civilization, and I learned to adapt to my new environment."
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

        public string setReason() => reasons[NumberGen.gen(reasons.Count)];
    }
}