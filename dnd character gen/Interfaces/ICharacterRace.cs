using System.Collections.Generic;

namespace dnd_character_gen.Interfaces
{
    public interface ICharacterRace
    {
        string setName();

        Dictionary<string, int> setAbilityScores();

        string setSize();

        int setSpeed();

        int setHitPointModifier();

        List<string> setSkills();

        List<string> setToolsProf();

        List<string> setWeaponProf();

        List<string> setArmorProf();

        Dictionary<string, string> setFeatures();

        List<string> setLanguages();
    }
}