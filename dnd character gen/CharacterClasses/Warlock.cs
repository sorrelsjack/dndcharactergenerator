using System.Collections.Generic;
using dnd_character_gen.CharacterSubClasses;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterClasses
{
    public class Warlock : ICharacterClass
    {
        private List<string> reasons = new List<string>
        {
            "While wandering around in a forbidden place, I encountered an otherworldly being that offered to enter into a pact with me.",
            "I was examining a strange tome I found in an abandoned library when the entity that would become my patron suddenly appeared before me.",
            "I stumbled into the clutches of my patron after I accidentally stepped through a magical doorway.",
            "When I was faced with a terrible crisis, I prayed to any being who would listen, and the creature that answered became my patron.",
            "My future patron visited me in my dreams and offered great power in exchange for my service.",
            "One of my ancestors had a pact with my patron, so that entity was determined to bind me to the same agreement."
        };

        private string patron;
        private ICharacterSubClass subClass;

        private Dictionary<string, string> _features = new Dictionary<string, string>();

        public List<string> setArmorProf() => new List<string> { "Light armor" };

        public List<string> setEquipment()
        {
            List<string> equipment = new List<string>();
            int randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 0
                ? "Light crossbow and 20 bolts" : SimpleWeapons.Instance.weapons[NumberGen.gen(SimpleWeapons.Instance.weapons.Count)]);

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 0 ? "Component pouch" : "Arcane focus");

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 0 ? "Scholar's pack" : "Dungeoneer's pack");

            equipment.Add("Leather armor");
            equipment.Add(SimpleWeapons.Instance.weapons[NumberGen.gen(SimpleWeapons.Instance.weapons.Count)]);
            equipment.Add("Two daggers");

            return equipment;
        }

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Otherworldly Patron", "At 1st level, you have struck a bargain with an otherworldly being of your choice: the Fiend, which is detailed at the end of the class description, or one from another source. Your choice grants you features at 1st level and again at 6th, 10th, and 14th level."},
            { "Pact Magic", "Your arcane research and the magic bestowed on you by your patron have given you facility with spells. See Spells Rules for the general rules of spellcasting and the Spells Listing for the warlock spell list."}
        };

        public int setHitDie() => 8;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setLanguages() => null;

        public string setPrimaryStat() => "Charisma";

        public List<string> setSaves() => new List<string> { "Wisdom", "Charisma" };

        public List<string> setSkills()
        {
            List<string> skillProficiencies = new List<string>();
            List<string> availableSkills = new List<string>()
                { "Arcana", "Deception", "History", "Intimidation", "Investigation", "Nature", "Religion" };

            string skill = availableSkills[NumberGen.gen(7)];
            skillProficiencies.Add(skill);
            availableSkills.Remove(skill);

            skill = availableSkills[NumberGen.gen(6)];
            skillProficiencies.Add(skill);

            return skillProficiencies;
        }

        public int setSpellAttackMod(int proficiency, Dictionary<string, int> modifiers) =>
            proficiency + modifiers["Charisma"];

        public int setSpellSaveDC(int proficiency, Dictionary<string, int> modifiers) =>
            8 + proficiency + modifiers["Charisma"];

        public string setSubType()
        {
            List<string> patrons = new List<string>() { "Archfey", "Fiend", "Great Old One" };

            patron = patrons[NumberGen.gen(3)];
            if (patron == "Archfey")
                subClass = new ArchfeyWarlock();
            else if (patron == "Fiend")
                subClass = new FiendWarlock();
            else if (patron == "Great Old One")
                subClass = new GreatOldOneWarlock();

            initializeSubType();

            return patron;
        }

        private void initializeSubType()
        {
            foreach (var feature in subClass.setFeatures())
                _features.Add(feature.Key, feature.Value);
        }

        public List<string> setToolsProf() => null;

        public List<string> setWeaponProf() => new List<string> { "Simple weapons" };

        public string setReason() => reasons[NumberGen.gen(reasons.Count)];
    }
}