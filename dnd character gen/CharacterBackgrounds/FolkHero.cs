using System.Collections.Generic;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterBackgrounds
{
    public class FolkHero : ICharacterBackground
    {
        private string artisansTools = ArtisansTools.Instance.tools[NumberGen.gen(ArtisansTools.Instance.tools.Count)];

        private List<string> definingEvents = new List<string>
        {
            "I stood up to a tyrant's agents.",
            "I saved people during a natural disaster.",
            "I stood alone against a terrible monster.",
            "I stole from a corrupt merchant to help the poor.",
            "I led a militia to fight off an invading army.",
            "I broke into a tyrant’s castle and stole weapons to arm the people.",
            "I trained the peasantry to use farm implements as weapons against a tyrant’s soldiers.",
            "A lord rescinded an unpopular decree after I led a symbolic act of protest against it.",
            "A celestial, fey, or similar creature gave me a blessing or revealed my secret origin.",
            "Recruited into a lord’s army, I rose to leadership and was commended for my heroism."
        };

        private List<string> personalityTraits = new List<string> 
        {
            "I judge people by their actions, not their words.",
            "If someone is in trouble, I’m always ready to lend help.",
            "When I set my mind to something, I follow through no matter what gets in my way.",
            "I have a strong sense of fair play and always try to find the most equitable solution to arguments.",
            "I’m confident in my own abilities and do what I can to instill confidence in others.",
            "Thinking is for other people. I prefer action.",
            "I misuse long words in an attempt to sound smarter.",
            "I get bored easily. When am I going to get on with my destiny?"
        };

        private List<string> ideals = new List<string> 
        {
            "Respect. People deserve to be treated with dignity and respect. (Good)",
            "Fairness. No one should get preferential treatment before the law, and no one is above the law. (Lawful)",
            "Freedom. Tyrants must not be allowed to oppress the people. (Chaotic)",
            "Might. If I become strong, I can take what I want—what I deserve. (Evil)",
            "Sincerity. There’s no good in pretending to be something I’m not. (Neutral)",
            "Destiny. Nothing and no one can steer me away from my higher calling. (Any)"
        };

        private List<string> bonds = new List<string> 
        {
            "I have a family, but I have no idea where they are. One day, I hope to see them again.",
            "I worked the land, I love the land, and I will protect the land.",
            "A proud noble once gave me a horrible beating, and I will take my revenge on any bully I encounter.",
            "My tools are symbols of my past life, and I carry them so that I will never forget my roots.",
            "I protect those who cannot protect themselves.",
            "I wish my childhood sweetheart had come with me to pursue my destiny."
        };

        private List<string> flaws = new List<string> 
        {
            "The tyrant who rules my land will stop at nothing to see me killed.",
            "I’m convinced of the significance of my destiny, and blind to my shortcomings and the risk of failure.",
            "The people who knew me when I was young know my shameful secret, so I can never go home again.",
            "I have a weakness for the vices of the city, especially hard drink.",
            "Secretly, I believe that things would be better if I were a tyrant lording over the land.",
            "I have trouble trusting in my allies."
        };

        public string setBond() => bonds[NumberGen.gen(bonds.Count)];

        public List<string> setEquipment() => new List<string> { $"{artisansTools}", "Shovel", "Iron pot", "Set of common clothes", "Belt pouch containing 10 gp" };

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string> 
        {
            { "Rustic Hospitality", "Since you come from the ranks of the common folk, you fit in among them with ease. You can find a place to hide, rest, or recuperate among other commoners, unless you have shown yourself to be a danger to them. They will shield you from the law or anyone else searching for you, though they will not risk their lives for you." }
        };

        public string setFlaw() => flaws[NumberGen.gen(flaws.Count)];

        public string setIdeal() => ideals[NumberGen.gen(ideals.Count)];

        public List<string> setLanguages() => null;

        public string setPersonalityTrait() => personalityTraits[NumberGen.gen(personalityTraits.Count)];

        public List<string> setSkills() => new List<string> { "Animal Handling", "Survival" };

        public Dictionary<string, string> setSpecial() => new Dictionary<string, string>
        {
            { "Defining Event", $"{definingEvents[NumberGen.gen(definingEvents.Count)]}" }
        };

        public List<string> setToolsProf() => new List<string> { $"{artisansTools}", "Vehicles (Land)" };
    }
}