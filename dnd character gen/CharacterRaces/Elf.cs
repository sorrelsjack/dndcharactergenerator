using System.Collections.Generic;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterRaces
{
    public class Elf : ICharacterRace
    {
        private List<string> maleNames = new List<string>
        {
            "Adran", "Aelar", "Aramil", "Arannis", "Aust", "Beiro", "Berrian", "Carric", "Enialis", "Erdan", "Erevan",
            "Galinndan", "Hadarai", "Heian", "Himo", "Immeral", "Ivellios", "Laucian", "Mindartis", "Paelias", "Peren",
            "Quarion", "Riardon", "Rolen", "Soveliss", "Thamior", "Tharivol", "Theren", "Varis"
        };

        private List<string> femaleNames = new List<string>
        {
            "Adrie", "Althaea", "Anastrianna", "Andraste", "Antinua", "Bethrynna", "Birel", "Caelynn", "Drusilia", "Enna",
            "Felosial", "Ielenia", "Jelenneth", "Keyleth", "Leshanna", "Lia", "Meriele", "Mialee", "Naivara", "Quelenna",
            "Quillathe", "Sariel", "Shanairra", "Shava", "Silaqui", "Theirastra", "Thia", "Vadania", "Valanthe", "Xanaphia"
        };

        public virtual Dictionary<string, int> setAbilityScores() => new Dictionary<string, int> { { "Dexterity", 2 } };

        public List<string> setArmorProf() => null;

        public virtual Dictionary<string, string> setFeatures() => new Dictionary<string, string> //TODO make this a field and then let sub races take this and combine into
        {
            { "Darkvision", "Accustomed to twilit forests and the night sky, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray." },
            { "Keen Senses", "You have proficiency in the Perception skill." },
            { "Fey Ancestry", "You have advantage on saving throws against being charmed, and magic can’t put you to sleep." },
            { "Trance", "Elves don’t need to sleep. Instead, they meditate deeply, remaining semiconscious, for 4 hours a day. (The Common word for such meditation is “trance.”) While meditating, you can dream after a fashion; such dreams are actually mental exercises that have become reflexive through years of practice. After resting in this way, you gain the same benefit that a human does from 8 hours of sleep." }
        };

        public int setHitPointModifier() => 0;

        public virtual List<string> setLanguages() => new List<string> { "Common", "Elvish" };

        public string setName() => NumberGen.gen(2) == 0
            ? femaleNames[NumberGen.gen(femaleNames.Count)]
            : maleNames[NumberGen.gen(maleNames.Count)];

        public string setSize() => "Medium";

        public List<string> setSkills() => new List<string> { "Perception" };

        public virtual int setSpeed() => 30;

        public List<string> setToolsProf() => null;

        public virtual List<string> setWeaponProf() => null;
    }
}