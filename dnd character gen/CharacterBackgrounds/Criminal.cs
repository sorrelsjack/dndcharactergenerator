using System.Collections.Generic;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterBackgrounds
{
    public class Criminal : ICharacterBackground
    {
        private List<string> criminalSpecialities = new List<string>
        {
            "Blackmailer", "Burglar", "Enforcer", "Fence", "Highway Robber", "Hired Killer", "Pickpocket", "Smuggler"
        };

        private List<string> personalityTraits = new List<string>
        {
            "I always have a plan for what to do when things go wrong.",
            "I am always calm, no matter what the situation. I never raise my voice or let my emotions control me.",
            "The first thing I do in a new place is note the locations of everything valuable-or where such things could be hidden.",
            "I would rather make a new friend than a new enemy.",
            "I am incredibly slow to trust. Those who seem the fairest often have the most to hide.",
            "I don't pay attention to the risks in a situation. Never tell me the odds.",
            "The best way to get me to do something is to tell me I can't do it.",
            "I blow up at the slightest insult."
        };

        private List<string> ideals = new List<string>
        {
            "Honor. I don’t steal from others in the trade. (Lawful)",
            "Freedom. Chains are meant to be broken, as are those who would forge them. (Chaotic)",
            "Charity. I steal from the wealthy so that I can help people in need. (Good)",
            "Greed. I will do whatever it takes to become wealthy. (Evil)",
            "People. I’m loyal to my friends, not to any ideals, and everyone else can take a trip down the Styx for all I care. (Neutral)",
            "Redemption. There’s a spark of good in everyone. (Good)"
        };

        private List<string> bonds = new List<string>
        {
            "I’m trying to pay off an old debt I owe to a generous benefactor.",
            "My ill-gotten gains go to support my family.",
            "Something important was taken from me, and I aim to steal it back.",
            "I will become the greatest thief that ever lived.",
            "I’m guilty of a terrible crime. I hope I can redeem myself for it.",
            "Someone I loved died because of a mistake I made. That will never happen again."
        };

        private List<string> flaws = new List<string>
        {
            "When I see something valuable, I can’t think about anything but how to steal it.",
            "When faced with a choice between money and my friends, I usually choose the money.",
            "If there’s a plan, I’ll forget it. If I don’t forget it, I’ll ignore it.",
            "I have a “tell” that reveals when I'm lying.",
            "I turn tail and run when things look bad.",
            "An innocent person is in prison for a crime that I committed. I’m okay with that."
        };

        private List<string> reasons = new List<string> 
        {
            "I resented authority in my younger day and saw a life of crime as the best way to fight against tyranny and oppression.",
            "Necessity forced me to take up the life, since it was the only way I could survive.",
            "I fell in with a gang of reprobates and ne’er-do-wells, and I learned my specialty from them.",
            "A parent or relative taught me my criminal specialty to prepare me for the family business.",
            "I left home and found a place in a thieves’ guild or some other criminal organization.",
            "I was always bored, so I turned to crime to pass the time and discovered I was quite good at it."
        };

        public string setBond() => bonds[NumberGen.gen(bonds.Count)];

        public List<string> setEquipment() => new List<string> { "Crowbar", "Set of dark common clothes including a hood", "Belt pouch containing 15 gp" };

        public virtual Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Criminal Contact", "You have a reliable and trustworthy contact who acts as your liaison to a network of other criminals. You know how to get messages to and from your contact, even over great distances; specifically, you know the local messengers, corrupt caravan masters, and seedy sailors who can deliver messages for you." }
        };

        public string setFlaw() => flaws[NumberGen.gen(flaws.Count)];

        public string setIdeal() => ideals[NumberGen.gen(ideals.Count)];

        public List<string> setLanguages() => null;

        public string setPersonalityTrait() => personalityTraits[NumberGen.gen(personalityTraits.Count)];

        public string setReason() => reasons[NumberGen.gen(reasons.Count)];

        public List<string> setSkills() => new List<string> { "Deception", "Stealth" };

        public Dictionary<string, string> setSpecial() => new Dictionary<string, string> //TODO: actually do something with the special traits from the bgs
        {
            { "Criminal Speciality", $"{criminalSpecialities[NumberGen.gen(criminalSpecialities.Count)]}" }
        };

        public List<string> setToolsProf()
        {
            List<string> tools = new List<string>();

            tools.Add("Thieves' tools");
            tools.Add(GamingSets.Instance.sets[NumberGen.gen(GamingSets.Instance.sets.Count)]);

            return tools;
        }
    }
}