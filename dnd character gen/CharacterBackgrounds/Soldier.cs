using System.Collections.Generic;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterBackgrounds
{
    public class Soldier : ICharacterBackground
    {
        private List<string> trophies = new List<string> { "Dagger", "Broken blade", "Piece of a banner" };

        private List<string> specialties = new List<string>
        {
            "Officer", "Scout", "Infantry", "Cavalry", "Healer", "Quartermaster", "Standard bearer",
            "Support staff (Cook, blacksmith, or the like)"
        };

        private List<string> personalityTraits = new List<string>
        {
            "I’m always polite and respectful.",
            "I’m haunted by memories of war. I can’t get the images of violence out of my mind.",
            "I’ve lost too many friends, and I’m slow to make new ones.",
            "I’m full of inspiring and cautionary tales from my military experience relevant to almost every combat situation.",
            "I can stare down a hell hound without flinching.",
            "I enjoy being strong and like breaking things.",
            "I have a crude sense of humor.",
            "I face problems head-on. A simple, direct solution is the best path to success."
        };

        private List<string> ideals = new List<string>
        {
            "Greater Good. Our lot is to lay down our lives in defense of others. (Good)",
            "Responsibility. I do what I must and obey just authority. (Lawful)",
            "Independence. When people follow orders blindly, they embrace a kind of tyranny. (Chaotic)",
            "Might. In life as in war, the stronger force wins. (Evil)",
            "Live and Let Live. Ideals aren’t worth killing over or going to war for. (Neutral)",
            "Nation. My city, nation, or people are all that matter. (Any)"
        };

        private List<string> bonds = new List<string>
        {
            "I would still lay down my life for the people I served with.",
            "Someone saved my life on the battlefield. To this day, I will never leave a friend behind.",
            "My honor is my life.",
            "I’ll never forget the crushing defeat my company suffered or the enemies who dealt it.",
            "Those who fight beside me are those worth dying for.",
            "I fight for those who cannot fight for themselves."
        };

        private List<string> flaws = new List<string>
        {
            "The monstrous enemy we faced in battle still leaves me quivering with fear.",
            "I have little respect for anyone who is not a proven warrior.",
            "I made a terrible mistake in battle that cost many lives—and I would do anything to keep that mistake secret.",
            "My hatred of my enemies is blind and unreasoning.",
            "I obey the law, even if the law causes misery.",
            "I’d rather eat my armor than admit when I’m wrong."
        };

        private List<string> reasons = new List<string> 
        {
            "I joined the militia to help protect my community from monsters.",
            "A relative of mine was a soldier, and I wanted to carry on the family tradition.",
            "The local lord forced me to enlist in the army.",
            "War ravaged my homeland while I was growing up. Fighting was the only life I ever knew.",
            "I wanted fame and fortune, so I joined a mercenary company, selling my sword to the highest bidder.",
            "Invaders attacked my homeland. It was my duty to take up arms in defense of my people."
        };

        private string gamingSet = GamingSets.Instance.sets[NumberGen.gen(GamingSets.Instance.sets.Count)];

        public string setBond() => bonds[NumberGen.gen(bonds.Count)];

        public List<string> setEquipment() => new List<string>
        {
            "Insignia of rank", $"Trophy taken from a fallen enemy: {trophies[NumberGen.gen(trophies.Count)]}",
            $"{(gamingSet == "Dice set" ? "Set of bone dice" : "Deck of cards")}", "Set of common clothes", "Pouch containing 10 gp"
        };

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Military Rank", "You have a military rank from your career as a soldier. Soldiers loyal to your former military organization still recognize your authority and influence, and they defer to you if they are of a lower rank. You can invoke your rank to exert influence over other soldiers and requisition simple equipment or horses for temporary use. You can also usually gain access to friendly military encampments and fortresses where your rank is recognized." }
        };

        public string setFlaw() => flaws[NumberGen.gen(flaws.Count)];

        public string setIdeal() => ideals[NumberGen.gen(ideals.Count)];

        public List<string> setLanguages() => null;

        public string setPersonalityTrait() => personalityTraits[NumberGen.gen(personalityTraits.Count)];

        public List<string> setSkills() => new List<string> { "Athletics", "Intimidation" };

        public Dictionary<string, string> setSpecial() => new Dictionary<string, string>
        {
            { "Specialty", $"{specialties[NumberGen.gen(specialties.Count)]}" }
        };

        public List<string> setToolsProf() => new List<string> { $"{gamingSet}", "Vehicles (land)" };

        public string setReason() => reasons[NumberGen.gen(reasons.Count)];
    }
}