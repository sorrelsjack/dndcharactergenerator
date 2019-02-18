using dnd_character_gen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterClasses {
    public class Warlock : ICharacterClass {
        public List<string> setArmorProf() => new List<string> { "Light armor" };

        public List<string> setEquipment() {
            //Light crossbow and 20 bolts or any simple weapon
            //Component pouch or arcane focus
            //Scholar's pack or dungeoneer's pack
            //Leather armor, any simple wep, two daggers
            throw new NotImplementedException();
        }

        public void setFeatures() {
            throw new NotImplementedException();
        }

        public int setHitDie() => 8;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setLanguages() {
            throw new NotImplementedException();
        }

        public string setPrimaryStat() => "Charisma";

        public List<string> setSaves() => new List<string> { "Wisdom", "Charisma" };

        public List<string> setSkills() {
            //Skills: Choose two skills from Arcana, Deception, History, Intimidation, Investigation, Nature, and Religion
            throw new NotImplementedException();
        }

        public int? setSpellAttackMod() {
            throw new NotImplementedException();
        }

        public int? setSpellSaveDC() {
            throw new NotImplementedException();
        }

        public string setSubType() { //Patron
            throw new NotImplementedException();
        }

        public List<string> setToolsProf() => null;

        public List<string> setWeaponProf() { //Simple weapons
            throw new NotImplementedException();
        }
    }
}
