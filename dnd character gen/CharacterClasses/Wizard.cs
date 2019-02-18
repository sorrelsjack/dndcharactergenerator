using dnd_character_gen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterClasses {
    public class Wizard : ICharacterClass {

        public List<string> setArmorProf() => null;

        public List<string> setEquipment() {
            //Quarterstaff or dagger
            //Compontent pouch or arcane focus
            //Scholar's pack or explorer's pack
            //Spellbook
            throw new NotImplementedException();
        }

        public void setFeatures() {
            throw new NotImplementedException();
        }

        public int setHitDie() => 6;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setLanguages() => null;

        public string setPrimaryStat() => "Intelligence";

        public List<string> setSaves() => new List<string> { "Intelligence", "Wisdom" };

        public List<string> setSkills() { //Choose two from Arcana, History, Insight, Investigation, Medicine, and Religion
            throw new NotImplementedException();
        }

        public int? setSpellAttackMod() { // Spell attack modifier = your proficiency bonus + your Intelligence modifier
            throw new NotImplementedException();
        }

        public int? setSpellSaveDC() { // 8 + your proficiency bonus + your Intelligence modifier
            throw new NotImplementedException();
        }

        public string setSubType() => null;

        public List<string> setToolsProf() => null;

        public List<string> setWeaponProf() => new List<string> { "Daggers", "Darts", "Slings", "Quarterstaffs", "Light Crossbows" };
    }
}
