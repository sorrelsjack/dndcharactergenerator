using System.Collections.Generic;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterBackgrounds
{
    public class Sailor : ICharacterBackground
    {
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
            "Respect. The thing that keeps a ship together is mutual respect between captain and crew. (Good)",
            "Fairness. We all do the work, so we all share in the rewards. (Lawful)",
            "Freedom. The sea is freedom— the freedom to go anywhere and do anything. (Chaotic)",
            "Mastery. I’m a predator, and the other ships on the sea are my prey. (Evil)",
            "People. I’m committed to my crewmates, not to ideals. (Neutral)",
            "Aspiration. Someday I’ll own my own ship and chart my own destiny. (Any)"
        };

        private List<string> bonds = new List<string>
        {
            "I'm loyal to my captain first, everything else second.",
            "The ship is most important— crewmates and captains come and go.",
            "I'll always remember my first ship.",
            "In a harbor town, I have a paramour whose eyes nearly stole me from the sea.",
            "I was cheated out of my fair share of the profits, and I want to get my due.",
            "Ruthless pirates murdered my captain and crewmates, plundered our ship, and left me to die. Vengeance will be mine."
        };

        private List<string> flaws = new List<string>
        {
            "I follow orders, even if I think they're wrong.",
            "I'll say anything to avoid having to do extra work.",
            "Once someone questions my courage, I never back down no matter how dangerous the situation.",
            "Once I start drinking, it's hard for me to stop.",
            "I can't help but pocket loose coins and other trinkets I come across.",
            "My pride will probably lead to my destruction."
        };

        private List<string> reasons = new List<string> 
        {
            "I was press-ganged by pirates and forced to serve on their ship until I finally escaped.",
            "I wanted to see the world, so I signed on as a deckhand for a merchant ship.",
            "One of my relatives was a sailor who took me to sea.",
            "I needed to escape my community quickly, so I stowed away on a ship. When the crew found me, I was forced to work for my passage.",
            "Reavers attacked my community, so I found refuge on a ship until I could seek vengeance.",
            "I had few prospects where I was living, so I left to find my fortune elsewhere."
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

        public string setReason() => reasons[NumberGen.gen(reasons.Count)];
    }
}