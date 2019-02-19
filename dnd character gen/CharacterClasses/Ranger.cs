using dnd_character_gen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterClasses {
    public class Ranger : ICharacterClass {
        public List<string> setArmorProf() => new List<string> { "Light armor", "Medium armor", "Shields" };

        public List<string> setEquipment() {
            //Scale mail or leather armor
            //Two shortswords or two simple melee weapons
            //Dungeoneer's pack or an explorer's pack
            //A longbow and a quiver of 20 arrows
            throw new NotImplementedException();
        }

        public Dictionary<string, string> setFeatures() {
            throw new NotImplementedException();
        }

        public int setHitDie() => 10;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setLanguages() { //Favored enemy
            throw new NotImplementedException();
        }

        public string setPrimaryStat() => "Dexterity";

        public List<string> setSaves() => new List<string> { "Strength", "Dexterity" };

        public List<string> setSkills() { //Skills: Choose three from Animal Handling, Athletics, Insight, Investigation, Nature, Perception, Stealth, and Survival
            throw new NotImplementedException();
        }

        public int setSpellAttackMod(int proficiency, Dictionary<string, int> modifiers) => proficiency + modifiers["Wisdom"];

        public int setSpellSaveDC(int proficiency, Dictionary<string, int> modifiers) => 8 + proficiency + modifiers["Wisdom"];

        public string setSubType() => null;

        public List<string> setToolsProf() => null;

        public List<string> setWeaponProf() => new List<string> { "Simple weapons", "Martial weapons" };
    }
}
