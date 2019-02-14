using dnd_character_gen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterClasses {
    public class Bard : ICharacterClass {
        public List<string> armorProficiencies = new List<string>();
        public List<string> weaponProficiencies = new List<string>();
        public List<string> toolProficiencies = new List<string>();
        public List<string> savingThrowProficiencies = new List<string>();
        public List<string> skillProficiencies = new List<string>();

        public int setHitDie() => 8;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setArmorProf() => new List<string>() { "Light armor" };

        public List<string> setWeaponProf() => new List<string>() 
        { "Simple weapons", "Hand crossbows", "Longswords", "Rapiers", "Shortswords" };

        public List<string> setToolsProf() {
            //Three instruments.
            throw new NotImplementedException();
        }

        public List<string> setSkills() {
            //Any three.
            throw new NotImplementedException();
        }

        public string setPrimaryStat() => "Charisma";

        public List<string> setSaves() => new List<string>() { "Dexterity", "Charisma" };

        public void setFeatures() {
            throw new NotImplementedException();
        }

        public string setSubType() {
            throw new NotImplementedException();
        }

        public List<string> setEquipment() {
            List<string> equipment = new List<string>();
            //Rapier, Longsword, or any simple weapon
            //Diplomat's Pack or Entertainer's Pack
            //Lute or other instrument

            equipment.Add("Leather Armor");
            equipment.Add("Dagger");

            return equipment;
        }

        public int? setSpellSaveDC() {
            throw new NotImplementedException();
        }

        public int? setSpellAttackMod() {
            throw new NotImplementedException();
        }
    }
}
