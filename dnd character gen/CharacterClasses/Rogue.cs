using dnd_character_gen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterClasses {
    public class Rogue : ICharacterClass {
        public List<string> setArmorProf() => new List<string> { "Light armor" };

        public List<string> setEquipment() {
            //Rapier or shortsword
            //Shortbow and quiver of 20 arrows or shortsword
            //Burglar's pack, dungeoneer's pack, or explorer's pack
            //Leather armor, two daggers, and thieves' tools
            throw new NotImplementedException();
        }

        public Dictionary<string, string> setFeatures() {
            throw new NotImplementedException();
        }

        public int setHitDie() => 8;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setLanguages() => new List<string> { "Thieves' Cant" };

        public string setPrimaryStat() => "Dexterity";

        public List<string> setSaves() => new List<string> { "Dexterity", "Intelligence" };

        public List<string> setSkills() { //Skills: Choose four from Acrobatics, Athletics, Deception, Insight, Intimidation, Investigation, Perception, Performance, Persuasion, Sleight of Hand, and Stealth
            throw new NotImplementedException();
        }

        public int setSpellAttackMod(int proficiency, Dictionary<string, int> modifiers) => 0;

        public int setSpellSaveDC(int proficiency, Dictionary<string, int> modifiers) => 0;

        public string setSubType() => null;

        public List<string> setToolsProf() => new List<string> { "Thieves' Tools" };

        public List<string> setWeaponProf() { //Weapons: Simple weapons, hand crossbows, longswords, rapiers, shortswords
            throw new NotImplementedException();
        }
    }
}
