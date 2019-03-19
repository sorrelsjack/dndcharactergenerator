using System.Collections.Generic;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterClasses
{
    public class Druid : ICharacterClass
    {
        private List<string> reasons = new List<string> 
        {
            "I saw too much devastation in the wild places, too much of nature’s splendor ruined by the despoilers. I joined a circle of druids to fight back against the enemies of nature.",
            "I found a place among a group of druids after I fled a catastrophe.",
            "I have always had an affinity for animals, so I explored my talent to see how I could best use it.",
            "I befriended a druid and was moved by druidic teachings. I decided to follow my friend’s guidance and give something back to the world.",
            "While I was growing up, I saw spirits all around me — entities no one else could perceive. I sought out the druids to help me understand the visions and communicate with these beings.",
            "I have always felt disgust for creatures of unnatural origin. For this reason, I immersed myself in the study of the druidic mysteries and became a champion of the natural order."
        };

        public List<string> setArmorProf() => new List<string> { "Light armor", "Medium armor", "Shields" };

        public List<string> setEquipment()
        {
            List<string> equipment = new List<string>();
            int randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 0
                ? "Wooden Shield" : SimpleWeapons.Instance.weapons[NumberGen.gen(SimpleWeapons.Instance.weapons.Count)]);

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 0
                ? "Scimitar" : SimpleWeapons.Instance.weapons[NumberGen.gen(SimpleWeapons.Instance.weapons.Count)]);

            equipment.Add("Leather Armor");
            equipment.Add("Explorer's Pack");
            equipment.Add("Druidic Focus");

            return equipment;
        }

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Druidic", "You know Druidic, the secret language of druids. You can speak the language and use it to leave hidden messages. You and others who know this language automatically spot such a message. Others spot the message’s presence with a successful DC 15 Wisdom (Perception) check but can’t decipher it without magic."},
            { "Spellcasting", "Drawing on the divine essence of nature itself, you can cast spells to shape that essence to your will. See Spells Rules for the general rules of spellcasting and the Spells Listing for the druid spell list." }
        };

        public int setHitDie() => 8;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setLanguages() => new List<string>() { "Druidic" };

        public string setPrimaryStat() => "Wisdom";

        public List<string> setSaves() => new List<string>() { "Intelligence", "Wisdom" };

        public List<string> setSkills()
        {
            List<string> skillProficiencies = new List<string>();
            List<string> availableSkills = new List<string>()
            { "Arcana", "Animal Handling", "Medicine", "Nature", "Perception", "Religion", "Surival" };

            string skill = availableSkills[NumberGen.gen(7)];
            skillProficiencies.Add(skill);
            availableSkills.Remove(skill);

            skill = availableSkills[NumberGen.gen(6)];
            skillProficiencies.Add(skill);

            return skillProficiencies;
        }

        public int setSpellAttackMod(int proficiency, Dictionary<string, int> modifiers) =>
            proficiency + modifiers["Wisdom"];

        public int setSpellSaveDC(int proficiency, Dictionary<string, int> modifiers) =>
            8 + proficiency + modifiers["Wisdom"];

        public string setSubType() => null;

        public List<string> setToolsProf() => new List<string>() { "Herbalism Kit" };

        public List<string> setWeaponProf() => new List<string>()
            { "Clubs", "Daggers", "Darts", "Javelins", "Maces", "Quarterstaffs", "Scimitars", "Sickles", "Slings", "Spears" };

        public string setReason() => reasons[NumberGen.gen(reasons.Count)];
    }
}