using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterClasses {
    public class Fighter : ICharacterClass {
        public List<string> setArmorProf() => new List<string> { "Light armor", "Medium armor", "Heavy armor", "Shields" };

        public List<string> setEquipment() {
            //Chain mail or leather armor, longbow, and 20 arrows
            //Martial weapon and shield or two martial weapons
            //Light crossbow and 20 bolts or two handaxes
            //Dungeoneer's pack or explorer's pack
            throw new NotImplementedException();
        }

        public Dictionary<string, string> setFeatures() {
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
            List<string> skillProficiencies = new List<string>();
            List<string> availableSkills = new List<string>()
                { "Acrobatics", "Animal Handling", "Athletics", "History", "Insight", "Intimidation", "Perception", "Survival" };

            string skill = availableSkills[NumberGen.gen(8)];
            skillProficiencies.Add(skill);
            availableSkills.Remove(skill);

            skill = availableSkills[NumberGen.gen(7)];
            skillProficiencies.Add(skill);

            return skillProficiencies;
        }

        public int setSpellAttackMod(int proficiency, Dictionary<string, int> modifiers) => 0;

        public int setSpellSaveDC(int proficiency, Dictionary<string, int> modifiers) => 0;

        public string setSubType() {
            List<string> fightingStyle = new List<string>() 
            { "Archery", "Defense", "Dueling", "Great Weapon Fighting", "Protection", "Two-Weapon Fighting" };

            return fightingStyle[NumberGen.gen(6)];
        }

        public List<string> setToolsProf() => null;

        public List<string> setWeaponProf() => new List<string> { "Simple weapons", "Martial weapons" };
    }
}
