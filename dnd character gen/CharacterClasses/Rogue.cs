using dnd_character_gen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterClasses {
    public class Rogue : ICharacterClass {
        public List<string> armorProficiencies = new List<string>();
        public List<string> weaponProficiencies = new List<string>();
        public List<string> toolProficiencies = new List<string>();
        public List<string> savingThrowProficiencies = new List<string>();
        public List<string> skillProficiencies = new List<string>();
        public List<string> equipment = new List<string>();

        public List<string> setArmorProf() {
            throw new NotImplementedException();
        }

        public List<string> setEquipment() {
            throw new NotImplementedException();
        }

        public void setFeatures() {
            throw new NotImplementedException();
        }

        public int setHitDie() {
            throw new NotImplementedException();
        }

        public int setHitPoints(int hitDie, int constitution) {
            throw new NotImplementedException();
        }

        public List<string> setLanguages() {
            throw new NotImplementedException();
        }

        public string setPrimaryStat() {
            throw new NotImplementedException();
        }

        public List<string> setSaves() {
            throw new NotImplementedException();
        }

        public List<string> setSkills() {
            throw new NotImplementedException();
        }

        public int? setSpellAttackMod() {
            throw new NotImplementedException();
        }

        public int? setSpellSaveDC() {
            throw new NotImplementedException();
        }

        public string setSubType() {
            throw new NotImplementedException();
        }

        public List<string> setToolsProf() {
            throw new NotImplementedException();
        }

        public List<string> setWeaponProf() {
            throw new NotImplementedException();
        }
    }
}
