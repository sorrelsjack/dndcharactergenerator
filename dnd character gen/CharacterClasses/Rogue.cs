using System.Collections.Generic;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterClasses
{
    public class Rogue : ICharacterClass
    {
        private List<string> reasons = new List<string>
        {
            "I’ve always been nimble and quick of wit, so I decided to use those talents to help me make my way in the world.",
            "An assassin or a thief wronged me, so I focused my training on mastering the skills of my enemy to better combat foes of that sort.",
            "An experienced rogue saw something in me and taught me several useful tricks.",
            "I decided to turn my natural lucky streak into the basis of a career, though I still realize that improving my skills is essential.",
            "I took up with a group of ruffians who showed me how to get what I want through sneakiness rather than direct confrontation.",
            "I’m a sucker for a shiny bauble or a sack of coins, as long as I can get my hands on it without risking life and limb."
        };

        public List<string> setArmorProf() => new List<string> { "Light armor" };

        public List<string> setEquipment()
        {
            List<string> equipment = new List<string>();
            int randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 0
                ? "Rapier" : "Shortsword");

            randomNumber = NumberGen.gen(2);
            if (randomNumber == 0)
            {
                equipment.Add("Shortbow");
                equipment.Add("Quiver of 20 arrows");
            }
            else
            {
                equipment.Add("Shortsword");
            }

            randomNumber = NumberGen.gen(3);
            if (randomNumber == 0)
                equipment.Add("Burglar's pack");
            else if (randomNumber == 1)
                equipment.Add("Dungeoneer's pack");
            else if (randomNumber == 2)
                equipment.Add("Explorer's pack");

            equipment.Add("Leather armor");
            equipment.Add("Two daggers");
            equipment.Add("Thieves' tools");

            return equipment;
        }

        public Dictionary<string, string> setFeatures()
        {
            Dictionary<string, string> features = new Dictionary<string, string>
            {
                { "Expertise", "At 1st level, choose two of your skill proficiencies, or one of your skill proficiencies and your proficiency with thieves’ tools. Your proficiency bonus is doubled for any ability check you make that uses either of the chosen proficiencies." },
                { "Sneak Attack", "Beginning at 1st level, you know how to strike subtly and exploit a foe’s distraction. Once per turn, you can deal an extra 1d6 damage to one creature you hit with an attack if you have advantage on the attack roll. The attack must use a finesse or a ranged weapon. You don’t need advantage on the attack roll if another enemy of the target is within 5 feet of it, that enemy isn’t incapacitated, and you don’t have disadvantage on the attack roll. The amount of the extra damage increases as you gain levels in this class, as shown in the Sneak Attack column of the Rogue table." },
                { "Thieves' Cant", "During your rogue training you learned thieves’ cant, a secret mix of dialect, jargon, and code that allows you to hide messages in seemingly normal conversation. Only another creature that knows thieves’ cant understands such messages. It takes four times longer to convey such a message than it does to speak the same idea plainly. In addition, you understand a set of secret signs and symbols used to convey short, simple messages, such as whether an area is dangerous or the territory of a thieves’ guild, whether loot is nearby, or whether the people in an area are easy marks or will provide a safe house for thieves on the run." }
            };

            return features;
        }

        public int setHitDie() => 8;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setLanguages() => new List<string> { "Thieves' Cant" };

        public string setPrimaryStat() => "Dexterity";

        public List<string> setSaves() => new List<string> { "Dexterity", "Intelligence" };

        public List<string> setSkills()
        {
            List<string> skillProficiencies = new List<string>();
            List<string> availableSkills = new List<string>()
                { "Acrobatics", "Athletics", "Deception", "Insight", "Intimidation", "Investigation", "Perception", "Performance", "Persuasion", "Sleight of Hand", "Stealth" };

            string skill = availableSkills[NumberGen.gen(11)];
            skillProficiencies.Add(skill);
            availableSkills.Remove(skill);

            skill = availableSkills[NumberGen.gen(10)];
            skillProficiencies.Add(skill);
            availableSkills.Remove(skill);

            skill = availableSkills[NumberGen.gen(9)];
            skillProficiencies.Add(skill);
            availableSkills.Remove(skill);

            skill = availableSkills[NumberGen.gen(8)];
            skillProficiencies.Add(skill);

            return skillProficiencies;
        }

        public int setSpellAttackMod(int proficiency, Dictionary<string, int> modifiers) => 0;

        public int setSpellSaveDC(int proficiency, Dictionary<string, int> modifiers) => 0;

        public string setSubType() => null;

        public List<string> setToolsProf() => new List<string> { "Thieves' Tools" };

        public List<string> setWeaponProf() => new List<string> { "Simple weapons", "Hand crossbows", "Longswords", "Rapiers", "Shortswords" };

        public string setReason() => reasons[NumberGen.gen(reasons.Count)];
    }
}