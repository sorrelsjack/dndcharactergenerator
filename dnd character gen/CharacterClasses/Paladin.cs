﻿using dnd_character_gen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterClasses {
    public class Paladin : ICharacterClass {
        public List<string> setArmorProf() => new List<string> { "Shields" }; //And all armor.

        public List<string> setEquipment() {
            /*(a) a martial weapon and a shield or (b) two martial weapons
(a) five javelins or (b) any simple melee weapon
(a) a priest’s pack or (b) an explorer’s pack
Chain mail and a holy symbol
             * 
             *
             * */
            throw new NotImplementedException();
        }

        public Dictionary<string, string> setFeatures() {
            throw new NotImplementedException();
        }

        public int setHitDie() => 10;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setLanguages() => null;

        public string setPrimaryStat() => "Strength";

        public List<string> setSaves() => new List<string> { "Wisdom", "Charisma" };

        public List<string> setSkills() { //Choose two from Athletics, Insight, Intimidation, Medicine, Persuasion, and Religion
            throw new NotImplementedException();
        }

        public int setSpellAttackMod(int proficiency, Dictionary<string, int> modifiers) =>
            proficiency + modifiers["Charisma"];

        public int setSpellSaveDC(int proficiency, Dictionary<string, int> modifiers) => 
            8 + proficiency + modifiers["Charisma"];

        public string setSubType() => null;

        public List<string> setToolsProf() => null;

        public List<string> setWeaponProf() { //Simple and Martial
            throw new NotImplementedException();
        }
    }
}
