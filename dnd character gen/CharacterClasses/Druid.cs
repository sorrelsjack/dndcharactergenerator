using dnd_character_gen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterClasses {
    public class Druid : ICharacterClass {
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
            List<string> equipment = new List<string>();
            //Wooden Shield or Simple weapon
            //Scimitar or Simple weapon

            equipment.Add("Leather Armor");
            equipment.Add("Explorer's Pack");
            equipment.Add("Druidic Focus");

            return equipment;
        }

        public void setFeatures() {
            throw new NotImplementedException();
        }

        public int setHitDie() => 8;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setLanguages() => new List<string>() { "Druidic" };

        public string setPrimaryStat() => "Wisdom";

        public List<string> setSaves() => new List<string>() { "Intelligence", "Wisdom" };

        public List<string> setSkills() {
            //Two from Arcana, Animal Handling, Insight, Medicine, Nature, Perception, Religion, Survival
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

        public List<string> setToolsProf() => new List<string>() { "Herbalism Kit" };

        public List<string> setWeaponProf() => new List<string>() 
            { "Clubs", "Daggers", "Darts", "Javelins", "Maces", "Quarterstaffs", "Scimitars", "Sickles", "Slings", "Spears" };
    }
}
