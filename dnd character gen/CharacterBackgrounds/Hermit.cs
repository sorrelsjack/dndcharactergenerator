using System.Collections.Generic;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterBackgrounds
{
    public class Hermit : ICharacterBackground
    {
        private List<string> livesOfSeclusion = new List<string>
        {
            "I was searching for spiritual enlightenment.",
            "I was partaking in communal living in accordance with dictates of a religious order.",
            "I was exiled for a crime I didn't commit.",
            "I retreated from society after a life-altering event.",
            "I needed a quiet place to work on my art, literature, music, or manifesto.",
            "I needed to commune with nature, far from civilization.",
            "I was the caretaker of an ancient ruin or relic.",
            "I was a pilgrim in search of a person, place, or relic of spiritual significance."
        };

        private List<string> personalityTraits = new List<string>
        {
            "I’ve been isolated for so long that I rarely speak, preferring gestures and the occasional grunt.",
            "I am utterly serene, even in the face of disaster.",
            "The leader of my community had something wise to say on every topic, and I am eager to share that wisdom.",
            "I feel tremendous empathy for all who suffer.",
            "I’m oblivious to etiquette and social expectations.",
            "I connect everything that happens to me to a grand, cosmic plan.",
            "I often get lost in my own thoughts and contemplation, becoming oblivious to my surroundings.",
            "I am working on a grand philosophical theory and love sharing my ideas."
        };

        private List<string> ideals = new List<string>
        {
            "Greater Good. My gifts are meant to be shared with all, not used for my own benefit. (Good)",
            "Logic. Emotions must not cloud our sense of what is right and true, or our logical thinking. (Lawful)",
            "Free Thinking. Inquiry and curiosity are the pillars of progress. (Chaotic)",
            "Power. Solitude and contemplation are paths toward mystical or magical power. (Evil)",
            "Live and Let Live. Meddling in the affairs of others only causes trouble. (Neutral)",
            "Self-Knowledge. If you know yourself, there’s nothing left to know. (Any)"
        };

        private List<string> bonds = new List<string>
        {
            "Nothing is more important than the other members of my hermitage, order, or association.",
            "I entered seclusion to hide from the ones who might still be hunting me. I must someday confront them.",
            "I’m still seeking the enlightenment I pursued in my seclusion, and it still eludes me.",
            "I entered seclusion because I loved someone I could not have.",
            "Should my discovery come to light, it could bring ruin to the world.",
            "My isolation gave me great insight into a great evil that only I can destroy."
        };

        private List<string> flaws = new List<string>
        {
            "Now that I've returned to the world, I enjoy its delights a little too much.",
            "I harbor dark, bloodthirsty thoughts that my isolation and meditation failed to quell.",
            "I am dogmatic in my thoughts and philosophy.",
            "I let my need to win arguments overshadow friendships and harmony.",
            "I’d risk too much to uncover a lost bit of knowledge.",
            "I like keeping secrets and won’t share them with anyone."
        };

        public string setBond() => bonds[NumberGen.gen(bonds.Count)];

        public List<string> setEquipment() => new List<string>
        {
            "Scroll case stuffed full of notes from your studies or prayers", "Winter blanket",
            "Set of common clothes", "Herbalism kit", "5 gp"
        };

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Discovery", "The quiet seclusion of your extended hermitage gave you access to a unique and pow erful discovery. The exact nature of this revelation depends on the nature of your seclusion. Work with your DM to determine the details of your discovery and its impact on the campaign." }
        };

        public string setFlaw() => flaws[NumberGen.gen(flaws.Count)];

        public string setIdeal() => ideals[NumberGen.gen(ideals.Count)];

        public List<string> setLanguages() => new List<string> { Languages.Instance.languages[NumberGen.gen(Languages.Instance.languages.Count)] };

        public string setPersonalityTrait() => personalityTraits[NumberGen.gen(personalityTraits.Count)];

        public List<string> setSkills() => new List<string> { "Medicine", "Religion" };

        public Dictionary<string, string> setSpecial() => new Dictionary<string, string>
        {
            { "Life of Seclusion", $"{livesOfSeclusion[NumberGen.gen(livesOfSeclusion.Count)]}" }
        };

        public List<string> setToolsProf() => new List<string> { "Herbalism kit" };
    }
}