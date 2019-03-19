﻿using System.Collections.Generic;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterBackgrounds
{
    public class Acolyte : ICharacterBackground
    {
        public string setBond()
        {
            List<string> bonds = new List<string>
            {
                "I would die to recover an ancient relic of my faith that was lost long ago.",
                "I will someday get revenge on the corrupt temple hierarchy who branded me a heretic.",
                "I owe my life to the priest who took me in when my parents died.",
                "Everything I do is for the common people.",
                "I will do anything to protect the temple where I served.",
                "I seek to preserve a sacred text that my enemies consider heretical and seek to destroy."
            };

            return bonds[NumberGen.gen(bonds.Count)];
        }

        public List<string> setEquipment() => new List<string>
            { "Holy symbol", $"{(NumberGen.gen(2) == 0 ? "Prayer book" : "Prayer wheel")}", "5 sticks of incense", "Vestments",
                "Set of common clothes", "Belt pouch containing 15 gp" };

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Shelter of the Faithful", "As an acolyte, you command the respect of those who share your faith, and you can perform the religious ceremonies of your deity. You and your adventuring companions can expect to receive free healing and care at a temple, shrine, or other established presence of your faith, though you must provide any material components needed for spells. Those who share your religion will support you (but only you) at a modest lifestyle. You might also have ties to a specific temple dedicated to your chosen deity or pantheon, and you have a residence there. This could be the temple where you used to serve, or a temple where you have found a new home. While near your temple, you can call upon the priests for assistance, provided the assistance you ask for is not hazardous and you remain in good standing with your temple." }
        };

        public string setFlaw()
        {
            List<string> flaws = new List<string>
            {
                "I judge others harshly, and myself even more severely.",
                "I put too much trust in those who wield power within my temple's hierarchy.",
                "My piety sometimes leads me to blindly trust those that profess faith in my god.",
                "I am inflexible in my thinking.",
                "I am suspicious of strangers and expect the worst of them.",
                "Once I pick a goal, I become obsessed with it to the detriment of everything else in my life."
            };

            return flaws[NumberGen.gen(flaws.Count)];
        }

        public string setIdeal()
        {
            List<string> ideals = new List<string>
            {
                "Tradition: The ancient traditions of worship and sacrifice must be preserved and upheld. (Lawful)",
                "Charity: I always try to help those in need, no matter what the personal cost. (Good)",
                "Change: We must help bring about the changes the gods are constantly working in the world. (Chaotic)",
                "Power: I hope to one day rise to the top of my faith's religious hierarchy. (Lawful)",
                "Faith: I trust that my deity will guide my actions, I have faith that if I work hard, things will go well. (Lawful)",
                "Aspiration: I seek to prove myself worthy of my god's favor by matching my actions against his or her teachings. (Any)"
            };

            return ideals[NumberGen.gen(ideals.Count)];
        }

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

        public string setPersonalityTrait()
        {
            List<string> personalityTraits = new List<string>
            {
                "I idolize a particular hero of my faith, and constantly refer to that person's deeds and example.",
                "I can find common ground between the fiercest enemies, empathizing with them and always working towards peace.",
                "I see omens in every event and action. The gods try to speak to us, we just need to listen",
                "Nothing can shake my optimistic attitude.",
                "I quote (or misquote) sacred texts and proverbs in almost every situation.",
                "I am tolerant (or intolerant) of other faiths and respect (or condemn) the worship of other gods.",
                "I've enjoyed fine food, drink, and high society among my temple's elite. Rough living grates on me.",
                "I've spent so long in the temple that I have little practical experience dealing with people in the outside world."
            };

            return personalityTraits[NumberGen.gen(personalityTraits.Count)];
        }

        public string setReason() 
        {
            List<string> reasons = new List<string>
            {
                "I ran away from home at an early age and found refuge in a temple.",
                "My family gave me to a temple, since they were unable or unwilling to care for me.",
                "I grew up in a household with strong religious convictions. Entering the service of one or more gods seemed natural.",
                "An impassioned sermon struck a chord deep in my soul and moved me to serve the faith.",
                "I followed a childhood friend, a respected acquaintance, or someone I loved into religious service.",
                "After encountering a true servant of the gods, I was so inspired that I immediately entered the service of a religious group."
            };

            return reasons[NumberGen.gen(reasons.Count)];
        }

        public List<string> setSkills() => new List<string> { "Insight", "Religion" };

        public Dictionary<string, string> setSpecial() => null; //TODO: pick a god

        public List<string> setToolsProf() => null;
    }
}