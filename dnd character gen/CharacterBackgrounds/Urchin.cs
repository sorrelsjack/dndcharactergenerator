using System.Collections.Generic;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterBackgrounds
{
    public class Urchin : ICharacterBackground {

        private List<string> personalityTraits = new List<string> 
        {
            "I hide scraps of food and trinkets away in my pockets.",
            "I ask a lot of questions.",
            "I like to squeeze into small places where no one else can get to me.",
            "I sleep with my back to a wall or tree, with everything I own wrapped in a bundle in my arms.",
            "I eat like a pig and have bad manners.",
            "I think anyone who's nice to me is hiding evil intent.",
            "I don't like to bathe.",
            "I bluntly say what other people are hinting at or hiding."
        };

        private List<string> ideals = new List<string> 
        {
            "Respect. All people, rich or poor, deserve respect. (Good)",
            "Community. We have to take care of each other, because no one else is going to do it. (Lawful)",
            "Change. The low are lifted up, and the high and mighty are brought down. Change is the nature of things. (Chaotic)",
            "Retribution. The rich need to be shown what life and death are like in the gutters. (Evil)",
            "People. I help the people who help me— that’s what keeps us alive. (Neutral)",
            "Aspiration. I'm going to prove that I'm worthy of a better life."
        };

        private List<string> bonds = new List<string> 
        {
            "My town or city is my home, and I'll fight to defend it.",
            "I sponsor an orphanage to keep others from enduring what I was forced to endure.",
            "I owe my survival to another urchin who taught me to live on the streets.",
            "I owe a debt I can never repay to the person who took pity on me.",
            "I escaped my life of poverty by robbing an important person, and I'm wanted for it.",
            "No one else should have to endure the hardships I've been through."
        };

        private List<string> flaws = new List<string> 
        {
            "If I'm outnumbered, I will run away from a fight.",
            "Gold seems like a lot of money to me, and I'll do just about anything for more of it.",
            "I will never fully trust anyone other than myself.",
            "I'd rather kill someone in their sleep than fight fair.",
            "It's not stealing if I need it more than someone else.",
            "People who can't take care of themselves get what they deserve."
        };

        private List<string> reasons = new List<string> 
        {
            "Wanderlust caused me to leave my family to see the world. I look after myself.",
            "I ran away from a bad situation at home and made my own way in the world.",
            "Monsters wiped out my village, and I was the sole survivor. I had to find a way to survive.",
            "A notorious thief looked after me and other orphans, and we spied and stole to earn our keep.",
            "One day I woke up on the streets, alone and hungry, with no memory of my early childhood.",
            "My parents died, leaving no one to look after me. I raised myself."
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

        public string setReason() => reasons[NumberGen.gen(reasons.Count)];
    }
}