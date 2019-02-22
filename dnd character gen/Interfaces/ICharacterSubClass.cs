using System.Collections.Generic;

namespace dnd_character_gen.Interfaces
{
    public interface ICharacterSubClass
    {
        Dictionary<string, string> setFeatures();

        List<string> setArmorProf();

        List<string> setWeaponProf();

        List<string> setLanguageProf();

        List<string> setSkillProf();
    }
}