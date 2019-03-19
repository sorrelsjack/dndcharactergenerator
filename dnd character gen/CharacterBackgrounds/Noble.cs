using System.Collections.Generic;
using System.Linq;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterBackgrounds
{
    public class Noble : ICharacterBackground
    {
        private Dictionary<string, string> feature = new Dictionary<string, string>();

        private Dictionary<string, string> features = new Dictionary<string, string>
        {
            { "Position of Privilege",  "Thanks to your noble birth, people are inclined to think the best of you. You are welcome in high society, and people assume you have the right to be wherever you are. The common folk make every effort to accommodate you and avoid your displeasure, and other people of high birth treat you as a member of the same social sphere. You can secure an audience with a local noble if you need to." },
            { "Retainers", "You have the service of three retainers loyal to your family. These retainers can be attendants or messengers, and one might be a majordomo. Your retainers are commoners who can perform mundane tasks for you, but they do not fight for you, will not follow you into obviously dangerous areas (such as dungeons), and will leave if they are frequently endangered or abused" }
        };

        private List<string> personalityTraits = new List<string>
        {
            "My eloquent flattery makes everyone I talk to feel like the most wonderful and important person in the world.",
            "The common folk love me for my kindness and generosity.",
            "No one could doubt by looking at my regal bearing that I am a cut above the unwashed masses.",
            "I take great pains to always look my best and follow the latest fashions.",
            "I don’t like to get my hands dirty, and I won’t be caught dead in unsuitable accommodations.",
            "Despite my noble birth, I do not place myself above other folk. We all have the same blood.",
            "My favor, once lost, is lost forever.",
            "If you do me an injury, I will crush you, ruin your name, and salt your fields."
        };

        private List<string> ideals = new List<string>
        {
            "Respect. Respect is due to me because of my position, but all people regardless of station deserve to be treated with dignity. (Good)",
            "Responsibility. It is my duty to respect the authority of those above me, just as those below me must respect mine. (Lawful)",
            "Independence. I must prove that I can handle myself without the coddling of my family. (Chaotic)",
            "Power. If I can attain more power, no one will tell me what to do. (Evil)",
            "Family. Blood runs thicker than water. (Any)",
            "Noble Obligation. It is my duty to protect and care for the people beneath me. (Good)"
        };

        private List<string> bonds = new List<string>
        {
            "I will face any challenge to win the approval of my family.",
            "My house’s alliance with another noble family must be sustained at all costs.",
            "Nothing is more important than the other members of my family.",
            "I am in love with the heir of a family that my family despises.",
            "My loyalty to my sovereign is unwavering.",
            "The common folk must see me as a hero of the people."
        };

        private List<string> flaws = new List<string>
        {
            "I secretly believe that everyone is beneath me.",
            "I hide a truly scandalous secret that could ruin my family forever.",
            "I too often hear veiled insults and threats in every word addressed to me, and I’m quick to anger.",
            "I have an insatiable desire for carnal pleasures.",
            "In fact, the world does revolve around me.",
            "By my words and actions, I often bring shame to my family."
        };

        private List<string> reasons = new List<string> 
        {
            "I come from an old and storied family, and it fell to me to preserve the family name.",
            "My family has been disgraced, and I intend to clear our name.",
            "My family recently came by its title, and that elevation thrust us into a new and strange world.",
            "My family has a title, but none of my ancestors have distinguished themselves since we gained it.",
            "My family is filled with remarkable people. I hope to live up to their example.",
            "I hope to increase my family’s power and influence."
        };

        public Noble()
        {
            int randomNumber = NumberGen.gen(features.Count);
            feature.Add(features.ElementAt(randomNumber).Key, features.ElementAt(randomNumber).Value);
        }

        public string setBond() => bonds[NumberGen.gen(bonds.Count)];

        public virtual List<string> setEquipment() => new List<string> { "Set of fine clothes", "Signet ring", "Scroll of pedigree", "Purse containing 25 gp" };

        public virtual Dictionary<string, string> setFeatures() => feature;

        public string setFlaw() => flaws[NumberGen.gen(flaws.Count)];

        public string setIdeal() => ideals[NumberGen.gen(ideals.Count)];

        public List<string> setLanguages() => new List<string> { Languages.Instance.languages[NumberGen.gen(Languages.Instance.languages.Count)] };

        public string setPersonalityTrait() => personalityTraits[NumberGen.gen(personalityTraits.Count)];

        public List<string> setSkills() => new List<string> { "History", "Persuasion" };

        public Dictionary<string, string> setSpecial() => null;

        public List<string> setToolsProf() => new List<string> { GamingSets.Instance.sets[NumberGen.gen(GamingSets.Instance.sets.Count)] };

        public string setReason() => reasons[NumberGen.gen(reasons.Count)];
    }
}