using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterClasses {
    public class Bard : ICharacterClass {
        public int setHitDie() => 8;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setArmorProf() => new List<string>() { "Light armor" };

        public List<string> setWeaponProf() => new List<string>() 
        { "Simple weapons", "Hand crossbows", "Longswords", "Rapiers", "Shortswords" };

        public List<string> setToolsProf() {
            List<string> toolProficiencies = new List<string>();
            string skill = "";

            while (toolProficiencies.Count < 3) {
                skill = MusicalInstruments.Instance.instruments[NumberGen.gen(MusicalInstruments.Instance.instruments.Count)];

                if (!toolProficiencies.Contains(skill)) {
                    toolProficiencies.Add(skill);
                }
            }

            return toolProficiencies;
        }

        public List<string> setSkills() {
            List<string> skillProficiencies = new List<string>();
            string skill = "";

            while (skillProficiencies.Count < 3) {
                skill = Skills.Instance.skills.Keys.ElementAt(NumberGen.gen(Skills.Instance.skills.Count));

                if (!skillProficiencies.Contains(skill)) {
                    skillProficiencies.Add(skill);
                }
            }

            return skillProficiencies;
        }

        public string setPrimaryStat() => "Charisma";

        public List<string> setSaves() => new List<string>() { "Dexterity", "Charisma" };

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string> 
        {
            { "Spellcasting", "You have learned to untangle and reshape the fabric of reality in harmony with your wishes and music. Your spells are part of your vast repertoire, magic that you can tune to different situations. See Spells Rules for the general rules of spellcasting and the Spells Listing for the bard spell list."},
            { "Bardic Inspiration", "You can inspire others through stirring words or music. To do so, you use a bonus action on your turn to choose one creature other than yourself within 60 feet of you who can hear you. That creature gains one Bardic Inspiration die, a d6." +
                "\nOnce within the next 10 minutes, the creature can roll the die and add the number rolled to one ability check, attack roll, or saving throw it makes. The creature can wait until after it rolls the d20 before deciding to use the Bardic Inspiration die, but must decide before the DM says whether the roll succeeds or fails. Once the Bardic Inspiration die is rolled, it is lost. A creature can have only one Bardic Inspiration die at a time." +
                "\nYou can use this feature a number of times equal to your Charisma modifier (a minimum of once). You regain any expended uses when you finish a long rest." +
                "\nYour Bardic Inspiration die changes when you reach certain levels in this class. The die becomes a d8 at 5th level, a d10 at 10th level, and a d12 at 15th level." }
        };

        public string setSubType() => null;

        public List<string> setEquipment() {
            List<string> equipment = new List<string>();
            int randomNumber = NumberGen.gen(3);

            if (randomNumber == 0)
                equipment.Add("Rapier");
            else if (randomNumber == 1)
                equipment.Add("Longsword");
            else if (randomNumber == 2)
                equipment.Add(SimpleWeapons.Instance.weapons[NumberGen.gen(SimpleWeapons.Instance.weapons.Count)]);

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 0
                ? "Diplomat's Pack" : "Entertainer's Pack");

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 0
                ? "Lute" : MusicalInstruments.Instance.instruments[NumberGen.gen(MusicalInstruments.Instance.instruments.Count)]);

            equipment.Add("Leather Armor");
            equipment.Add("Dagger");

            return equipment;
        }

        public int setSpellSaveDC(int proficiency, Dictionary<string, int> modifiers) => 8 + proficiency + modifiers["Charisma"];

        public int setSpellAttackMod(int proficiency, Dictionary<string, int> modifiers) => proficiency + modifiers["Charisma"];

        public List<string> setLanguages() => null;
    }
}
