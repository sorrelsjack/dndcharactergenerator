using System;
using System.Collections.Generic;
using System.Linq;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterBackgrounds
{
    public class GuildArtisan : ICharacterBackground
    {
        private string guild = "";
        private string artisansTools = "";

        private List<string> personalityTraits = new List<string> 
        {
            "I believe that anything worth doing is worth doing right. I can’t help it— I’m a perfectionist.",
            "I’m a snob who looks down on those who can’t appreciate fine art.",
            "I always want to know how things work and what makes people tick.",
            "I’m full of witty aphorisms and have a proverb for every occasion.",
            "I’m rude to people who lack my commitment to hard work and fair play.",
            "I like to talk at length about my profession.",
            "I don’t part with my money easily and will haggle tirelessly to get the best deal possible.",
            "I’m well known for my work, and I want to make sure everyone appreciates it. I'm always taken aback when people haven’t heard of me."
        };

        private List<string> ideals = new List<string> 
        {
            "Community. It is the duty of all civilized people to strengthen the bonds of community and the security of civilization. (Lawful)",
            "Generosity. My talents were given to me so that I could use them to benefit the world. (Good)",
            "Freedom. Everyone should be free to pursue his or her own livelihood. (Chaotic)",
            "Greed. I’m only in it for the money. (Evil)",
            "People. I’m committed to the people I care about, not to ideals. (Neutral)",
            "Aspiration. I work hard to be the best there is at my craft."
        };

        private List<string> bonds = new List<string> 
        {
            "The workshop where I learned my trade is the most important place in the world to me.",
            "I created a great work for someone, and then found them unworthy to receive it. I’m still looking for someone worthy.",
            "I owe my guild a great debt for forging me into the person I am today.",
            "I pursue wealth to secure someone's love.",
            "One day I will return to my guild and prove that I am the greatest artisan of them all.",
            "I will get revenge on the evil forces that destroyed my place of business and ruined my livelihood."
        };

        private List<string> flaws = new List<string> 
        {
            "I’ll do anything to get my hands on something rare or priceless.",
            "I'm quick to assume that someone is trying to cheat me.",
            "No one must ever learn that I once stole money from guild coffers.",
            "I’m never satisfied with what I have— I always want more.",
            "I would kill to acquire a noble title.",
            "I’m horribly jealous of anyone who can outshine my handiwork. Everywhere I go, I’m surrounded by rivals."
        };

        private List<string> reasons = new List<string> 
        {
            "I was apprenticed to a master who taught me the guild’s business.",
            "I helped a guild artisan keep a secret or complete a task, and in return I was taken on as an apprentice.",
            "One of my family members who belonged to the guild made a place for me.",
            "I was always good with my hands, so I took the opportunity to learn a trade.",
            "I wanted to get away from my home situation and start a new life.",
            "I learned the essentials of my craft from a mentor but had to join the guild to finish my training."
        };

        public GuildArtisan()
        {
            this.guild = GuildBusinesses.Instance.guilds.Keys.ElementAt(NumberGen.gen(GuildBusinesses.Instance.guilds.Count));
            this.artisansTools = GuildBusinesses.Instance.guilds[guild];
        }

        public string setBond() => bonds[NumberGen.gen(bonds.Count)];

        public virtual List<string> setEquipment() => new List<string>
        {
            $"{artisansTools}", "Letter of introduction from guild", "Set of traveler's clothes", "Belt pouch containing 15 gp"
        };

        public virtual Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Guild Membership", "If you are in good standing with your guild, your guild can arrange for you to meet powerful politicians." }
        };

        public string setFlaw() => flaws[NumberGen.gen(flaws.Count)];

        public string setIdeal() => ideals[NumberGen.gen(ideals.Count)];

        public virtual List<string> setLanguages() =>
            new List<string> { Languages.Instance.languages[NumberGen.gen(Languages.Instance.languages.Count)] };

        public string setPersonalityTrait() => personalityTraits[NumberGen.gen(personalityTraits.Count)];

        public string setReason() => reasons[NumberGen.gen(reasons.Count)];

        public List<string> setSkills() => new List<string> { "Insight", "Persuasion" };

        public Dictionary<string, string> setSpecial() => new Dictionary<string, string> 
        {
            { "Guild Business", $"{guild}" }
        };

        public virtual List<string> setToolsProf() => new List<string> { $"{artisansTools}" };
    }
}