using System.Collections.Generic;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterBackgrounds
{
    public class Charlatan : ICharacterBackground
    {
        private List<string> conTools = new List<string> { "10 stoppered bottles filled with colored liquid", "Set of weighted dice", "Deck of marked cards", "Signet ring of an imaginary duke" };

        private List<string> favoriteSchemes = new List<string>
        {
            "I cheat at games involving chance.",
            "I shave coins or forge documents.",
            "I insinuate myself into people’s lives to prey on their weakness and secure their fortunes.",
            "I put on new identities like clothes.",
            "I run sleight-of-hand cons on street corners.",
            "I convince people that worthless junk is worth their hard-earned money."
        };

        private List<string> personalityTraits = new List<string>
        {
            "I fall in and out of love easily, and am always pursuing someone.",
            "I have a joke for every occasion, especially occasions where humor is inappropriate.",
            "Flattery is my preferred trick for getting what I want.",
            "I’m a born gambler who can't resist taking a risk for a potential payoff.",
            "I lie about almost everything, even when there’s no good reason to.",
            "Sarcasm and insults are my weapons of choice.",
            "I keep multiple holy symbols on me and invoke whatever deity might come in useful at any given moment.",
            "I pocket anything I see that might have some value."
        };

        private List<string> ideals = new List<string>
        {
            "Independence. I am a free spirit— no one tells me what to do. (Chaotic)",
            "Fairness. I never target people who can’t afford to lose a few coins. (Lawful)",
            "Charity. I distribute the money I acquire to the people who really need it. (Good)",
            "Creativity. I never run the same con twice. (Chaotic)",
            "Friendship. Material goods come and go. Bonds of friendship last forever. (Good)",
            "Aspiration. I’m determined to make something of myself. (Any)"
        };

        private List<string> bonds = new List<string>
        {
            "I fleeced the wrong person and must work to ensure that this individual never crosses paths with me or those I care about.",
            "I owe everything to my mentor—a horrible person who’s probably rotting in jail somewhere.",
            "Somewhere out there, I have a child who doesn’t know me. I’m making the world better for him or her.",
            "I come from a noble family, and one day I’ll reclaim my lands and title from those who stole them from me.",
            "A powerful person killed someone I love. Some day soon, I’ll have my revenge.",
            "I swindled and ruined a person who didn’t deserve it. I seek to atone for my misdeeds but might never be able to forgive myself."
        };

        private List<string> flaws = new List<string>
        {
            "I can’t resist a pretty face.",
            "I'm always in debt. I spend my ill-gotten gains on decadent luxuries faster than I bring them in.",
            "I’m convinced that no one could ever fool me the way I fool others.",
            "I’m too greedy for my own good. I can’t resist taking a risk if there’s money involved.",
            "I can’t resist swindling people who are more powerful than me.",
            "I hate to admit it and will hate myself for it, but I'll run and preserve my own hide if the going gets tough."
        };

        public string setBond() => bonds[NumberGen.gen(bonds.Count)];

        public List<string> setEquipment() => new List<string>
        {
            "Set of fine clothes", "Disguise kit", $"{conTools[NumberGen.gen(conTools.Count)]}", "Belt pouch containing 15 gp"
        };

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "False Identity", "You have created a second identity that includes documentation, established acquaintances, and disguises that allow you to assume that persona. Additionally, you can forge documents including official papers and personal letters, as long as you have seen an example of the kind of document or the handwriting you are trying to copy." }
        };

        public string setFlaw() => flaws[NumberGen.gen(flaws.Count)];

        public string setIdeal() => ideals[NumberGen.gen(ideals.Count)];

        public List<string> setLanguages() => null;

        public string setPersonalityTrait() => personalityTraits[NumberGen.gen(personalityTraits.Count)];

        public List<string> setSkills() => new List<string> { "Deception", "Sleight of Hand" };

        public Dictionary<string, string> setSpecial() => new Dictionary<string, string>
        {
            { "Favorite Schemes", $"{favoriteSchemes[NumberGen.gen(favoriteSchemes.Count)]}" }
        };

        public List<string> setToolsProf() => new List<string> { "Disguise kit", "Forgery kit" };
    }
}