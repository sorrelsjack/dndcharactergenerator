using System.Collections.Generic;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterBackgrounds
{
    public class Entertainer : ICharacterBackground
    {
        private string musicalInstrument =
            MusicalInstruments.Instance.instruments[NumberGen.gen(MusicalInstruments.Instance.instruments.Count)];

        private List<string> admirerFavor = new List<string> { "Love letter", "Lock of hair", "Trinket" };

        private List<string> entertainerRoutines = new List<string>
        {
            "Actor", "Dancer", "Fire-eater", "Jester", "Juggler", "Instrumentalist", "Poet", "Singer", "Storyteller",
            "Tumbler"
        };

        private List<string> personalityTraits = new List<string>
        {
            "I know a story relevant to almost every situation.",
            "Whenever I come to a new place, I collect local rumors and spread gossip.",
            "I’m a hopeless romantic, always searching for that “special someone.”",
            "Nobody stays angry at me or around me for long, since I can defuse any amount of tension.",
            "I love a good insult, even one directed at me.",
            "I get bitter if I’m not the center of attention.",
            "I’ll settle for nothing less than perfection.",
            "I change my mood or my mind as quickly as I change key in a song."
        };

        private List<string> ideals = new List<string>
        {
            "Beauty. When I perform, I make the world better than it was. (Good)",
            "Tradition. The stories, legends, and songs of the past must never be forgotten, for they teach us who we are. (Lawful)",
            "Creativity. The world is in need of new ideas and bold action. (Chaotic)",
            "Greed. I’m only in it for the money and fame. (Evil)",
            "People. I like seeing the smiles on people’s faces when I perform. That’s all that matters. (Neutral)",
            "Honesty. Art should reflect the soul; it should come from within and reveal who we really are. (Any)"
        };

        private List<string> bonds = new List<string>
        {
            "My instrument is my most treasured possession, and it reminds me of someone I love.",
            "Someone stole my precious instrument, and someday I’ll get it back.",
            "I want to be famous, whatever it takes.",
            "I idolize a hero of the old tales and measure my deeds against that person’s.",
            "I will do anything to prove myself superior to my hated rival.",
            "I would do anything for the other members of my old troupe."
        };

        private List<string> flaws = new List<string>
        {
            "I’ll do anything to win fame and renown.",
            "I’m a sucker for a pretty face.",
            "A scandal prevents me from ever going home again. That kind of trouble seems to follow me around.",
            "I once satirized a noble who still wants my head. It was a mistake that I will likely repeat.",
            "I have trouble keeping my true feelings hidden. My sharp tongue lands me in trouble.",
            "Despite my best efforts, I am unreliable to my friends."
        };

        public string setBond() => bonds[NumberGen.gen(bonds.Count)];

        public List<string> setEquipment() => new List<string>
        {
            $"{musicalInstrument}", $"{admirerFavor[NumberGen.gen(admirerFavor.Count)]}", "Costume",
            "Belt pouch containing 15 gp"
        };

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "By Popular Demand", "You can always find a place to perform, usually in an inn or tavern but possibly with a circus, at a theater, or even in a noble’s court. At such a place, you receive free lodging and food of a modest or comfortable standard (depending on the quality of the establishment), as long as you perform each night. In addition, your performance makes you something of a local figure. When strangers recognize you in a town where you have performed, they typically take a liking to you." }
        };

        public string setFlaw() => flaws[NumberGen.gen(flaws.Count)];

        public string setIdeal() => ideals[NumberGen.gen(ideals.Count)];

        public List<string> setLanguages() => null;

        public string setPersonalityTrait() => personalityTraits[NumberGen.gen(personalityTraits.Count)];

        public List<string> setSkills() => new List<string> { "Acrobatics", "Performance" };

        public Dictionary<string, string> setSpecial()
        {
            Dictionary<string, string> specials = new Dictionary<string, string> { { "Entertainer Routine", $"{entertainerRoutines[NumberGen.gen(entertainerRoutines.Count)]}" } };

            if (NumberGen.gen(2) == 0)
                specials.Add("Entertainer Variant: Gladiator",
                    "A gladiator is as much an entertainer as any minstrel or circus performer, trained to make the arts of combat into a spectacle the crowd can enjoy. This kind of flashy combat is your entertainer routine, though you might also have some skills as a tumbler or actor. Using your By Popular Demand feature, you can find a place to perform in any place that features combat for entertainment—perhaps a gladiatorial arena or secret pit fighting club. You can replace the musical instrument in your equipment package with an inexpensive but unusual weapon, such as a trident or net.");
            //TODO address Entertainer variant

            return specials;
        }

        public List<string> setToolsProf() => new List<string> { "Disguise kit", $"{musicalInstrument}" };
    }
}