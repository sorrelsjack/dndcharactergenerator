using System.Collections.Generic;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterClasses
{
    public class Wizard : ICharacterClass
    {
        private List<string> reasons = new List<string>
        {
            "An old wizard chose me from among several candidates to serve an apprenticeship.",
            "When I became lost in a forest, a hedge wizard found me, took me in, and taught me the rudiments of magic.",
            "I grew up listening to tales of great wizards and knew I wanted to follow their path. I strove to be accepted at an academy of magic and succeeded.",
            "One of my relatives was an accomplished wizard who decided I was smart enough to learn the craft.",
            "While exploring an old tomb, library, or temple, I found a spellbook. I was immediately driven to learn all I could about becoming a wizard.",
            "I was a prodigy who demonstrated mastery of the arcane arts at an early age. When I became old enough to set out on my own, I did so to learn more magic and expand my power."
        };

        public List<string> setArmorProf() => null;

        public List<string> setEquipment()
        {
            List<string> equipment = new List<string>();
            int randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 0 ? "Quarterstaff" : "Dagger");

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 0 ? "Component pouch" : "Arcane focus");

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 0 ? "Scholar's pack" : "Explorer's pack");

            equipment.Add("Spellbook");

            return equipment;
        }

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Spellcasting", "As a student of arcane magic, you have a spellbook containing spells that show the first glimmerings of your true power. See Spells Rules for the general rules of spellcasting and the Spells Listing for the wizard spell list." },
            { "Arcane Recovery", "You have learned to regain some of your magical energy by studying your spellbook. Once per day when you finish a short rest, you can choose expended spell slots to recover. The spell slots can have a combined level that is equal to or less than half your wizard level (rounded up), and none of the slots can be 6th level or higher." +
                "\nFor example, if you’re a 4th-level wizard, you can recover up to two levels worth of spell slots. You can recover either a 2nd-level spell slot or two 1st-level spell slots."}
        };

        public int setHitDie() => 6;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setLanguages() => null;

        public string setPrimaryStat() => "Intelligence";

        public List<string> setSaves() => new List<string> { "Intelligence", "Wisdom" };

        public List<string> setSkills()
        {
            List<string> skillProficiencies = new List<string>();
            List<string> availableSkills = new List<string>() { "Arcana", "History", "Insight", "Investigation", "Medicine", "Religion" };

            string skill = availableSkills[NumberGen.gen(6)];
            skillProficiencies.Add(skill);
            availableSkills.Remove(skill);

            skill = availableSkills[NumberGen.gen(5)];
            skillProficiencies.Add(skill);

            return skillProficiencies;
        }

        public int setSpellAttackMod(int proficiency, Dictionary<string, int> modifiers) =>
            proficiency + modifiers["Intelligence"];

        public int setSpellSaveDC(int proficiency, Dictionary<string, int> modifiers) =>
            8 + proficiency + modifiers["Intelligence"];

        public string setSubType() => null;

        public List<string> setToolsProf() => null;

        public List<string> setWeaponProf() => new List<string> { "Daggers", "Darts", "Slings", "Quarterstaffs", "Light Crossbows" };

        public string setReason() => reasons[NumberGen.gen(reasons.Count)];
    }
}