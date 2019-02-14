using dnd_character_gen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterClasses {
    public class Fighter : ICharacterClass {
        public List<string> weaponProficiencies = new List<string>();
        public List<string> toolProficiencies = new List<string>();
        public List<string> savingThrowProficiencies = new List<string>();
        public List<string> skillProficiencies = new List<string>();
        public List<string> equipment = new List<string>();

        public List<string> setArmorProf() {
            List<string> armorProficiencies = new List<string>();
            //All armor
            armorProficiencies.Add("Shields");
            return armorProficiencies;
        }

        public List<string> setEquipment() {
            //Chain mail or leather armor, longbow, and 20 arrows
            //Martial weapon and shield or two martial weapons
            //Light crossbow and 20 bolts or two handaxes
            //Dungeoneer's pack or explorer's pack
            throw new NotImplementedException();
        }

        public void setFeatures() {
            throw new NotImplementedException();
        }

        public int setHitDie() => 10;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setLanguages() => null;

        public string setPrimaryStat() {
            //Strength or Dex... Melee vs Ranged
            throw new NotImplementedException();
        }

        public List<string> setSaves() => new List<string>() { "Strength", "Constitution" };

        public List<string> setSkills() {
            //Two from Acrobatics, Animal Handling, Athletics, History, Insight, Intimidation, Perception, Survival
            throw new NotImplementedException();
        }

        public int? setSpellAttackMod() => null;

        public int? setSpellSaveDC() => null;

        public string setSubType() {
            List<string> fightingStyle = new List<string>() 
            { "Archery", "Defense", "Dueling", "Great Weapon Fighting", "Protection", "Two-Weapon Fighting" };
            //TODO do stuff with this
            throw new NotImplementedException();
        }

        public List<string> setToolsProf() => null;

        public List<string> setWeaponProf() {
            //Simple weapons and martial weapons
            throw new NotImplementedException();
        }
    }
}
