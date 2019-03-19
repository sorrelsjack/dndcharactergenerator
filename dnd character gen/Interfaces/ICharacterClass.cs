using System.Collections.Generic;

namespace dnd_character_gen.Interfaces
{
    public interface ICharacterClass
    {
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

        string setReason();

        int setSpellSaveDC(int proficiency, Dictionary<string, int> modifiers);

        int setSpellAttackMod(int proficiency, Dictionary<string, int> modifiers);
    }
}