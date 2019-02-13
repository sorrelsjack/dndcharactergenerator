using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.Interfaces {
    public interface ICharacterClass {
        void setHitDie();
        void setHitPoints();
        void setArmorProf();
        void setWeaponProf();
        void setToolsProf();
        void setSkills();
        void setPrimaryStat();
        void setSaves();
        void setFeatures();
        void setSubType();
        void setEquipment();
        void setSpellSaveDC();
        void setSpellAttackMod();
    }
}
