using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.Interfaces {
    public interface ICharacterClass {
        int setHitDie();
        int setHitPoints(int hitDie, int constitution);
        List<string> setArmorProf();
        List<string> setWeaponProf();
        List<string> setToolsProf();
        List<string> setSkills();
        List<string> setLanguages();
        string setPrimaryStat();
        List<string> setSaves();
        Dictionary<string, string> setFeatures();
        string setSubType();
        List<string> setEquipment();
        int setSpellSaveDC(int proficiency, Dictionary<string, int> modifiers);
        int setSpellAttackMod(int proficiency, Dictionary<string, int> modifiers);
        //Spells known? Cantrips? Spell slots?
    }
}
