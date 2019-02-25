using System.Collections.Generic;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterBackgrounds
{
    public class Sage : ICharacterBackground
    {
        private List<string> specialties = new List<string>
        {
            "Alchemist", "Astronomer", "Discredited academic", "Librarian", "Professor", "Researcher", "Wizard's apprentice", "Scribe"
        };

        private List<string> personalityTraits = new List<string>
        {
            "I use polysyllabic words that convey the impression of great erudition.",
            "I’ve read every book in the world’s greatest libraries—or I like to boast that I have.",
            "I’m used to helping out those who aren’t as smart as I am, and I patiently explain anything and everything to others.",
            "There’s nothing I like more than a good mystery.",
            "I’m willing to listen to every side of an argument before I make my own judgment.",
            "I … speak … slowly … when talking … to idiots, … which … almost … everyone … is … compared … to me.",
            "I am horribly, horribly awkward in social situations.",
            "I’m convinced that people are always trying to steal my secrets."
        };

        private List<string> ideals = new List<string>
        {
            "Knowledge. The path to power and self-improvement is through knowledge. (Neutral)",
            "Beauty. What is beautiful points us beyond itself toward what is true. (Good)",
            "Logic. Emotions must not cloud our logical thinking. (Lawful)",
            "No Limits. Nothing should fetter the infinite possibility inherent in all existence. (Chaotic)",
            "Power. Knowledge is the path to power and domination. (Evil)",
            "Self-Improvement. The goal of a life of study is the betterment of oneself. (Any)"
        };

        private List<string> bonds = new List<string>
        {
            "It is my duty to protect my students.",
            "I have an ancient text that holds terrible secrets that must not fall into the wrong hands.",
            "I work to preserve a library, university, scriptorium, or monastery.",
            "My life’s work is a series of tomes related to a specific field of lore.",
            "I’ve been searching my whole life for the answer to a certain question.",
            "I sold my soul for knowledge. I hope to do great deeds and win it back."
        };

        private List<string> flaws = new List<string>
        {
            "I am easily distracted by the promise of information.",
            "Most people scream and run when they see a demon. I stop and take notes on its anatomy.",
            "Unlocking an ancient mystery is worth the price of a civilization.",
            "I overlook obvious solutions in favor of complicated ones.",
            "I speak without really thinking through my words, invariably insulting others.",
            "I can’t keep a secret to save my life, or anyone else’s."
        };

        public string setBond() => bonds[NumberGen.gen(bonds.Count)];

        public List<string> setEquipment() => new List<string>
        {
            "Bottle of black ink", "Quill", "Small knife", "Letter from a dead colleague posing a question you have not yet been able to answer", "Set of common clothes", "Pouch containing 10 gp"
        };

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Researcher", "When you attempt to learn or recall a piece of lore, if you do not know that information, you often know where and from whom you can obtain it. Usually, this information comes from a library, scriptorium, university, or a sage or other learned person or creature. Your DM might rule that the knowledge you seek is secreted away in an almost inaccessible place, or that it simply cannot be found. Unearthing the deepest secrets of the multiverse can require an adventure or even a whole campaign." }
        };

        public string setFlaw() => flaws[NumberGen.gen(flaws.Count)];

        public string setIdeal() => ideals[NumberGen.gen(ideals.Count)];

        public List<string> setLanguages()
        {
            List<string> languages = new List<string>();
            string language;

            while (languages.Count < 2)
            {
                language = Languages.Instance.languages[NumberGen.gen(Languages.Instance.languages.Count)];
                if (!languages.Contains(language))
                    languages.Add(language);
            }

            return languages;
        }

        public string setPersonalityTrait() => personalityTraits[NumberGen.gen(personalityTraits.Count)];

        public List<string> setSkills() => new List<string> { "Arcana", "History" };

        public Dictionary<string, string> setSpecial() => new Dictionary<string, string> { { "Specialty", $"{specialties[NumberGen.gen(specialties.Count)]}" } };

        public List<string> setToolsProf() => null;
    }
}