using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterClasses {
    public class Barbarian : ICharacterClass {
        int hitDie;
        int hitPoints;
        string primaryStat;

        public List<string> armorProficiencies = new List<string>();
        public List<string> weaponProficiencies = new List<string>();
        public List<string> toolProficiencies = new List<string>();
        public List<string> savingThrowProficiencies = new List<string>();
        public List<string> skillProficiencies = new List<string>();
        public List<string> equipment = new List<string>();

        public Barbarian() {

        }

        public void setSubType() {
            throw new NotImplementedException();
        }

        public void setPrimaryStat() {
            primaryStat = "Strength";
        }

        public void setHitDie() {
            hitDie = 12;
        }

        public void setHitPoints() {
            //Need con modifier for this.
            throw new NotImplementedException();
        }

        public void setArmorProf() {
            armorProficiencies.Add("Light armor");
            armorProficiencies.Add("Medium armor");
            armorProficiencies.Add("Shields");
        }

        public void setWeaponProf() {
            weaponProficiencies.Add("Simple weapons");
            weaponProficiencies.Add("Martial weapons");
        }

        public void setToolsProf() {
            
        }

        public void setSaves() {
            savingThrowProficiencies.Add("Strength");
            savingThrowProficiencies.Add("Constitution");
        }

        public void setSkills() {
            List<string> availableSkills = new List<string>()
            { "Animal Handling", "Athletics", "Intimidation", "Nature", "Perception", "Survival"}; //TODO Figure out how to determine modifiers..?

            string skill = availableSkills[NumberGen.gen(6)];
            skillProficiencies.Add(skill);
            availableSkills.Remove(skill);

            skill = availableSkills[NumberGen.gen(5)];
            skillProficiencies.Add(skill);
        }

        public void setEquipment() {
            //TODO put in a way to choose btween equipment
            throw new NotImplementedException();
        }

        public void setFeatures() {
            //TODO deal with this
        }

        public void setSpellAttackMod() {
            //TODO deal with this
        }

        public void setSpellSaveDC() {
            //TODO deal with this
        }
    }
}
