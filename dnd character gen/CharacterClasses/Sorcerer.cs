using System.Collections.Generic;
using dnd_character_gen.CharacterSubClasses;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterClasses
{
    public class Sorcerer : ICharacterClass
    {
        private List<string> reasons = new List<string>
        {
            "When I was born, all the water in the house froze solid, the milk spoiled, or all the iron turned to copper. My family is convinced that this event was a harbinger of stranger things to come for me.",
            "I suffered a terrible emotional or physical strain, which brought forth my latent magical power. I have fought to control it ever since.",
            "My immediate family never spoke of my ancestors, and when I asked, they would change the subject. It wasn’t until I started displaying strange talents that the full truth of my heritage came out.",
            "When a monster threatened one of my friends, I became filled with anxiety. I lashed out instinctively and blasted the wretched thing with a force that came from within me.",
            "Sensing something special in me, a stranger taught me how to control my gift.",
            "After I escaped from a magical conflagration, I realized that though I was unharmed, I was not unchanged. I began to exhibit unusual abilities that I am just beginning to understand."
        };

        private string origin;
        private ICharacterSubClass subClass;

        private Dictionary<string, string> _features = new Dictionary<string, string>();
        private List<string> _languageProficiencies = new List<string>();

        public List<string> setArmorProf() => null;

        public List<string> setEquipment()
        {
            List<string> equipment = new List<string>();
            int randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 0
                ? "Light crossbow and 20 bolts" : SimpleWeapons.Instance.weapons[NumberGen.gen(SimpleWeapons.Instance.weapons.Count)]);

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 0
                ? "Component pouch" : "Arcane focus");

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 0
                ? "Dungeoneer's pack" : "Explorer's pack");

            equipment.Add("Two daggers");

            return equipment;
        }

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Spellcasting", "An event in your past, or in the life of a parent or ancestor, left an indelible mark on you, infusing you with arcane magic. This font of magic, whatever its origin, fuels your spells. See Spells Rules for the general rules of spellcasting and the Spells Listing for the sorcerer spell list." },
            { "Sorcerous Origin", "Choose a sorcerous origin, which describes the source of your innate magical power: Draconic Bloodline, detailed at the end of the class description, or one from another source." +
                "\nYour choice grants you features when you choose it at 1st level and again at 6th, 14th, and 18th level." }
        };

        public int setHitDie() => 6;

        public int setHitPoints(int hitDie, int constitution) => origin != "Draconic Bloodline" ? hitDie + constitution : hitDie + constitution + 1;

        public List<string> setLanguages() => _languageProficiencies;

        public string setPrimaryStat() => "Charisma";

        public List<string> setSaves() => new List<string> { "Constitution", "Charisma" };

        public List<string> setSkills()
        {
            List<string> skillProficiencies = new List<string>();
            List<string> availableSkills = new List<string>()
                { "Arcana", "Deception", "Insight", "Intimidation", "Persuasion", "Religion" };

            string skill = availableSkills[NumberGen.gen(6)];
            skillProficiencies.Add(skill);
            availableSkills.Remove(skill);

            skill = availableSkills[NumberGen.gen(5)];
            skillProficiencies.Add(skill);

            return skillProficiencies;
        }

        public int setSpellAttackMod(int proficiency, Dictionary<string, int> modifiers) =>
            proficiency + modifiers["Charisma"];

        public int setSpellSaveDC(int proficiency, Dictionary<string, int> modifiers) =>
            8 + proficiency + modifiers["Charisma"];

        public string setSubType()
        {
            List<string> origins = new List<string> { "Draconic Bloodline", "Wild Magic" };

            origin = origins[NumberGen.gen(2)];
            if (origin == "Draconic Bloodline")
                subClass = new DraconicBloodlineSorcerer();
            else if (origin == "Wild Magic")
                subClass = new WildMagicSorcerer();

            initializeSubType();

            return origin;
        }

        private void initializeSubType()
        {
            foreach (var feature in subClass.setFeatures())
                _features.Add(feature.Key, feature.Value);

            var subClassLanguageProf = subClass.setLanguageProf();
            if (subClassLanguageProf != null)
                _languageProficiencies.AddRange(subClassLanguageProf);
        }

        public List<string> setToolsProf() => null;

        public List<string> setWeaponProf() => new List<string> { "Daggers", "Darts", "Slings", "Quarterstaffs", "Light Crossbows" };

        public string setReason() => reasons[NumberGen.gen(reasons.Count)];
    }
}