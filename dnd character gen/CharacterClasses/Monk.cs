using dnd_character_gen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterClasses {
    class Monk : ICharacterClass {
        public List<string> armorProficiencies = new List<string>();
        public List<string> toolProficiencies = new List<string>();
        public List<string> savingThrowProficiencies = new List<string>();
        public List<string> skillProficiencies = new List<string>();

        public List<string> setArmorProf() => null;

        public List<string> setEquipment() {
            List<string> equipment = new List<string>();
            //Shortsword or any simple weapon
            //Dungeoneer's pack or Explorer's pack
            equipment.Add("10 Darts");

            return equipment;
        }

        public void setFeatures() {
            throw new NotImplementedException();
        }

        public int setHitDie() => 8;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setLanguages() => null;

        public string setPrimaryStat() => "Dexterity";

        public List<string> setSaves() => new List<string>() { "Strength", "Dexterity" };

        public List<string> setSkills() {
            //Acrobatics, Athletics, History, Insight, Religion, Stealth
            throw new NotImplementedException();
        }

        public int? setSpellAttackMod() => null;

        public int? setSpellSaveDC() => null;

        public string setSubType() {
            //Some monk stuff idk
            throw new NotImplementedException();
        }

        public List<string> setToolsProf() {
            //Artisan's tools and musical instrument
            throw new NotImplementedException();
        }

        public List<string> setWeaponProf() {
            List<string> weaponProficiencies = new List<string>();
            weaponProficiencies.Add("Shortswords");
            //Simple weapons
            return weaponProficiencies;
        }
    }
}
