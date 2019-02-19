using dnd_character_gen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterClasses {
    public class Sorcerer : ICharacterClass {
        public List<string> setArmorProf() => null;

        public List<string> setEquipment() {
            //Light crossbow and 20 bolts or simple wep
            //Component pouch or arcane focus
            //Dungeoneer's pack or explorer's pack
            //Two daggers
            throw new NotImplementedException();
        }

        public Dictionary<string, string> setFeatures() {
            throw new NotImplementedException();
        }

        public int setHitDie() => 6;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setLanguages() => null;

        public string setPrimaryStat() => "Charisma";

        public List<string> setSaves() => new List<string> { "Constitution", "Charisma" };

        public List<string> setSkills() { //Skills: Choose two from Arcana, Deception, Insight, Intimidation, Persuasion, and Religion
            throw new NotImplementedException();
        }

        public int setSpellAttackMod(int proficiency, Dictionary<string, int> modifiers) =>
            proficiency + modifiers["Charisma"];

        public int setSpellSaveDC(int proficiency, Dictionary<string, int> modifiers) =>
            8 + proficiency + modifiers["Charisma"];

        public string setSubType() { //Origin
            throw new NotImplementedException();
        }

        public List<string> setToolsProf() => null;

        public List<string> setWeaponProf() => new List<string> { "Daggers", "Darts", "Slings", "Quarterstaffs", "Light Crossbows" };
    }
}
