using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterClasses {
    public class Barbarian : ICharacterClass {

        public Barbarian() {

        }

        public string setSubType() {
            return null;
            //Barbarians don't get a subtype at level 1.
        }

        public string setPrimaryStat() => "Strength";

        public int setHitDie() => 12;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setArmorProf() => new List<string>() { "Light armor", "Medium armor", "Shields" };

        public List<string> setWeaponProf() => new List<string>() { "Simple weapons", "Martial weapons" };

        public List<string> setToolsProf() => null;

        public List<string> setSaves() => new List<string>() { "Strength", "Constitution" };

        public List<string> setSkills() {
            List<string> skillProficiencies = new List<string>();
            List<string> availableSkills = new List<string>()
            { "Animal Handling", "Athletics", "Intimidation", "Nature", "Perception", "Survival"}; //Use global dict to know what stat each is.

            string skill = availableSkills[NumberGen.gen(6)];
            skillProficiencies.Add(skill);
            availableSkills.Remove(skill);

            skill = availableSkills[NumberGen.gen(5)];
            skillProficiencies.Add(skill);

            return availableSkills;
        }

        public List<string> setEquipment() {
            List<string> equipment = new List<string>();
            int randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 1 
                ? "Greataxe" : MartialWeapons.Instance.weapons[NumberGen.gen(MartialWeapons.Instance.weapons.Count)]);

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 1
                ? "Two Handaxe" : SimpleWeapons.Instance.weapons[NumberGen.gen(SimpleWeapons.Instance.weapons.Count)]);

            equipment.Add("Explorer's Pack");
            equipment.Add("Four Javelins");

            return equipment;
        }

        public void setFeatures() {
            //TODO deal with this
        }

        public int? setSpellAttackMod() => null;

        public int? setSpellSaveDC() => null;
    }
}
