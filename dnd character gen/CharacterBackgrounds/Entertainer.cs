using System.Collections.Generic;
using System.Linq;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterBackgrounds
{
    public class Entertainer : ICharacterBackground
    {
        private string musicalInstrument =
            MusicalInstruments.Instance.instruments[NumberGen.gen(MusicalInstruments.Instance.instruments.Count)];

        private List<string> admirerFavor = new List<string> { "Love letter", "Lock of hair" };

        protected List<string> entertainerRoutines = new List<string>
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

        private List<string> reasons = new List<string>
        {
            "Members of my family made ends meet by performing, so it was fitting for me to follow their example.",
            "I always had a keen insight into other people, enough so that I could make them laugh or cry with my stories or songs.",
            "I ran away from home to follow a minstrel troupe.",
            "I saw a bard perform once, and I knew from that moment on what I was born to do.",
            "I earned coin by performing on street corners and eventually made a name for myself.",
            "A traveling entertainer took me in and taught me the trade."
        };

        public Entertainer()
        {
            admirerFavor.AddRange(Trinkets.Instance.trinkets.ToList());
        }

        public string setBond() => bonds[NumberGen.gen(bonds.Count)];

        public virtual List<string> setEquipment() => new List<string>
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

        public virtual Dictionary<string, string> setSpecial() => new Dictionary<string, string> { { "Entertainer Routine", $"{entertainerRoutines[NumberGen.gen(entertainerRoutines.Count)]}" } };

        public List<string> setToolsProf() => new List<string> { "Disguise kit", $"{musicalInstrument}" };

        public string setReason() => reasons[NumberGen.gen(reasons.Count)];
    }
}