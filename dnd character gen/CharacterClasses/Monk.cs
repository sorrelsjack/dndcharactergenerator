using System.Collections.Generic;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterClasses
{
    internal class Monk : ICharacterClass
    {
        private List<string> reasons = new List<string>
        {
            "I was chosen to study at a secluded monastery. There, I was taught the fundamental techniques required to eventually master a tradition.",
            "I sought instruction to gain a deeper understanding of existence and my place in the world.",
            "I stumbled into a portal to the Shadowfell and took refuge in a strange monastery, where I learned how to defend myself against the forces of darkness.",
            "I was overwhelmed with grief after losing someone close to me, and I sought the advice of philosophers to help me cope with my loss.",
            "I could feel that a special sort of power lay within me, so I sought out those who could help me call it forth and master it. ",
            "I was wild and undisciplined as a youngster, but then I realized the error of my ways. I applied to a monastery and became a monk as a way to live a life of discipline."
        };

        public List<string> setArmorProf() => null;

        public List<string> setEquipment()
        {
            List<string> equipment = new List<string>();
            int randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 0
                ? "Shortsword" : SimpleWeapons.Instance.weapons[NumberGen.gen(SimpleWeapons.Instance.weapons.Count)]);

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 0
                ? "Dungeoneer's pack" : "Explorer's pack");

            equipment.Add("10 Darts");

            return equipment;
        }

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            {"Unarmored Defense", "Beginning at 1st level, while you are wearing no armor and not wielding a shield, your AC equals 10 + your Dexterity modifier + your Wisdom modifier." },
            { "Martial Arts", "At 1st level, your practice of martial arts gives you mastery of combat styles that use unarmed strikes and monk weapons, which are shortswords and any simple melee weapons that don’t have the two-handed or heavy property." +
                "\nYou gain the following benefits while you are unarmed or wielding only monk weapons and you aren’t wearing armor or wielding a shield:" +
                "\n- You can use Dexterity instead of Strength for the attack and damage rolls of your unarmed strikes and monk weapons." +
                "\n- You can roll a d4 in place of the normal damage of your unarmed strike or monk weapon. This die changes as you gain monk levels, as shown in the Martial Arts column of the Monk table." +
                "\n- When you use the Attack action with an unarmed strike or a monk weapon on your turn, you can make one unarmed strike as a bonus action. For example, if you take the Attack action and attack with a quarterstaff, you can also make an unarmed strike as a bonus action, assuming you haven’t already taken a bonus action this turn." +
                "\nCertain monasteries use specialized forms of the monk weapons. For example, you might use a club that is two lengths of wood connected by a short chain (called a nunchaku) or a sickle with a shorter, straighter blade (called a kama). Whatever name you use for a monk weapon, you can use the game statistics provided for the weapon in the Weapons section." }
        };

        public int setHitDie() => 8;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setLanguages() => null;

        public string setPrimaryStat() => "Dexterity";

        public List<string> setSaves() => new List<string>() { "Strength", "Dexterity" };

        public List<string> setSkills()
        {
            List<string> skillProficiencies = new List<string>();
            List<string> availableSkills = new List<string>()
            { "Acrobatics", "Athletics", "History", "Insight", "Religion", "Stealth" };

            string skill = availableSkills[NumberGen.gen(6)];
            skillProficiencies.Add(skill);
            availableSkills.Remove(skill);

            skill = availableSkills[NumberGen.gen(5)];
            skillProficiencies.Add(skill);

            return skillProficiencies;
        }

        public int setSpellAttackMod(int proficiency, Dictionary<string, int> modifiers) => 0;

        public int setSpellSaveDC(int proficiency, Dictionary<string, int> modifiers) => 0;

        public string setSubType() => null;

        public List<string> setToolsProf()
        {
            List<string> toolProficiencies = new List<string>();

            toolProficiencies.Add(ArtisansTools.Instance.tools[NumberGen.gen(ArtisansTools.Instance.tools.Count)]);
            toolProficiencies.Add(MusicalInstruments.Instance.instruments[NumberGen.gen(MusicalInstruments.Instance.instruments.Count)]);

            return toolProficiencies;
        }

        public List<string> setWeaponProf()
        {
            List<string> weaponProficiencies = new List<string>();

            weaponProficiencies.Add("Simple weapons");
            weaponProficiencies.Add("Shortswords");

            return weaponProficiencies;
        }

        public string setReason() => reasons[NumberGen.gen(reasons.Count)];
    }
}