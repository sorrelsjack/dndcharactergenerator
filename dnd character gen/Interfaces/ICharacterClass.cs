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
        void setFeatures();
        string setSubType();
        List<string> setEquipment();
        int? setSpellSaveDC();
        int? setSpellAttackMod();
        //Spells known? Cantrips? Spell slots?
    }
}
