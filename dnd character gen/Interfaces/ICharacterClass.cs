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
        string setPrimaryStat();
        List<string> setSaves();
        void setFeatures();
        void setSubType();
        void setEquipment();
        int? setSpellSaveDC();
        int? setSpellAttackMod();
        //Spells known? Cantrips? Spell slots?
    }
}
