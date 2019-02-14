using dnd_character_gen.Dictionaries;
using dnd_character_gen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterClasses {
    public class Cleric : ICharacterClass {
        public List<string> armorProficiencies = new List<string>();
        public List<string> weaponProficiencies = new List<string>();
        public List<string> toolProficiencies = new List<string>();
        public List<string> savingThrowProficiencies = new List<string>();
        public List<string> skillProficiencies = new List<string>();

        public List<string> setArmorProf() => new List<string>() { "Light armor", "Medium armor", "Shields" }; //What if we need to add more later if there's more proficiences?

        public List<string> setEquipment() {
            List<string> equipment = new List<string>();
            //Mace or Warhammer (if proficient)
            //Scale mail, leather armor, or chain mail (if proficient)
            //Light crossbow and 20 bolts or any simple weapon
            //Priests pack or explorer's pack
            equipment.Add("Shield");
            equipment.Add("Holy Symbol");

            return equipment;
        }

        public void setFeatures() {
            throw new NotImplementedException();
        }

        public int setHitDie() => 8;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution; //TODO could this go in the main class?

        public List<string> setLanguages() => null;

        public string setPrimaryStat() => "Wisdom";

        public List<string> setSaves() => new List<string>() { "Wisdom", "Charisma" };

        public List<string> setSkills() => null; //TODO fix. History, Insight, Medicine, Persuasion, Religion

        public int? setSpellAttackMod() {
            throw new NotImplementedException();
        }

        public int? setSpellSaveDC() {
            throw new NotImplementedException();
        }

        public string setSubType() {
            List<string> domains = new List<string>() 
            { "Knowledge", "Life", "Light", "Nature", "Tempest", "Trickery", "War" };

            //TODO fill this out. Pick one at random!
            //TODO codify the benefits of each subtype...

            return null;
        }

        public List<string> setToolsProf() => null;

        //TODO if proficient in simple weapons, return that list

        public List<string> setWeaponProf() => SimpleWeapons.Instance.weapons;
    }
}
