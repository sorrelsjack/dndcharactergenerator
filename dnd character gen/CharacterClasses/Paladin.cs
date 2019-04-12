﻿using System.Collections.Generic;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterClasses
{
    public class Paladin : ICharacterClass //TODO: nature of paladin quest
    {
        private List<string> reasons = new List<string>
        {
            "A fantastical being appeared before me and called on me to undertake a holy quest.",
            "One of my ancestors left a holy quest unfulfilled, so I intend to finish that work.",
            "The world is a dark and terrible place. I decided to serve as a beacon of light shining out against the gathering shadows.",
            "I served as a paladin’s squire, learning all I needed to swear my own sacred oath.",
            "Evil must be opposed on all fronts. I feel compelled to seek out wickedness and purge it from the world.",
            "Becoming a paladin was a natural consequence of my unwavering faith. In taking my vows, I became the holy sword of my religion."
        };

        public List<string> setArmorProf() => new List<string> { "Light armor", "Medium armor", "Heavy Armor", "Shields" };

        public List<string> setEquipment()
        {
            List<string> equipment = new List<string>();
            int randomNumber = NumberGen.gen(2);
            if (randomNumber == 0)
            {
                equipment.Add(MartialWeapons.Instance.weapons[NumberGen.gen(MartialWeapons.Instance.weapons.Count)]);
                equipment.Add("Shield");
            }
            else
            {
                equipment.Add(MartialWeapons.Instance.weapons[NumberGen.gen(MartialWeapons.Instance.weapons.Count)]);
                equipment.Add(MartialWeapons.Instance.weapons[NumberGen.gen(MartialWeapons.Instance.weapons.Count)]);
            }

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 0
                ? "Five javelins" : SimpleWeapons.Instance.weapons[NumberGen.gen(SimpleWeapons.Instance.weapons.Count)]);

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 0
                ? "Priest's pack" : "Explorer's pack");

            equipment.Add("Chain mail");
            equipment.Add("Holy symbol");

            return equipment;
        }

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Divine Sense", "The presence of strong evil registers on your senses like a noxious odor, and powerful good rings like heavenly music in your ears. As an action, you can open your awareness to detect such forces. Until the end of your next turn, you know the location of any celestial, fiend, or undead within 60 feet of you that is not behind total cover. You know the type (celestial, fiend, or undead) of any being whose presence you sense, but not its identity (the vampire Count Strahd von Zarovich, for instance). Within the same radius, you also detect the presence of any place or object that has been consecrated or desecrated, as with the hallow spell." +
                "\nYou can use this feature a number of times equal to 1 + your Charisma modifier. When you finish a long rest, you regain all expended uses."},
            { "Lay on Hands", "Your blessed touch can heal wounds. You have a pool of healing power that replenishes when you take a long rest. With that pool, you can restore a total number of hit points equal to your paladin level × 5." +
                "\nAs an action, you can touch a creature and draw power from the pool to restore a number of hit points to that creature, up to the maximum amount remaining in your pool." +
                "\nAlternatively, you can expend 5 hit points from your pool of healing to cure the target of one disease or neutralize one poison affecting it. You can cure multiple diseases and neutralize multiple poisons with a single use of Lay on Hands, expending hit points separately for each one." +
                "\nThis feature has no effect on undead and constructs."}
        };

        public int setHitDie() => 10;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setLanguages() => null;

        public string setPrimaryStat() => "Strength";

        public List<string> setSaves() => new List<string> { "Wisdom", "Charisma" };

        public List<string> setSkills()
        {
            List<string> skillProficiencies = new List<string>();
            List<string> availableSkills = new List<string>()
                { "Athletics", "Insight", "Intimidation", "Medicine", "Persuasion", "Religion" };

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

        public string setSubType() => null;

        public List<string> setToolsProf() => null;

        public List<string> setWeaponProf() => new List<string> { "Simple weapons", "Martial weapons" };

        public string setReason() => reasons[NumberGen.gen(reasons.Count)];
    }
}