using dnd_character_gen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterClasses {
    public class Wizard : ICharacterClass {
        int hitDie;
        int hitPoints;
        string primaryStat;

        public List<string> armorProficiencies = new List<string>();
        public List<string> weaponProficiencies = new List<string>();
        public List<string> toolProficiencies = new List<string>();
        public List<string> savingThrowProficiencies = new List<string>();
        public List<string> skillProficiencies = new List<string>();
        public List<string> equipment = new List<string>();

        public void setArmorProf() {
            throw new NotImplementedException();
        }

        public void setEquipment() {
            throw new NotImplementedException();
        }

        public void setFeatures() {
            throw new NotImplementedException();
        }

        public void setHitDie() {
            throw new NotImplementedException();
        }

        public void setHitPoints() {
            throw new NotImplementedException();
        }

        public void setPrimaryStat() {
            throw new NotImplementedException();
        }

        public void setSaves() {
            throw new NotImplementedException();
        }

        public void setSkills() {
            throw new NotImplementedException();
        }

        public void setSpellAttackMod() {
            throw new NotImplementedException();
        }

        public void setSpellSaveDC() {
            throw new NotImplementedException();
        }

        public void setSubType() {
            throw new NotImplementedException();
        }

        public void setToolsProf() {
            throw new NotImplementedException();
        }

        public void setWeaponProf() {
            throw new NotImplementedException();
        }
    }
}
