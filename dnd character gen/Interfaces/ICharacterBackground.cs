using System.Collections.Generic;

namespace dnd_character_gen.Interfaces
{
    public interface ICharacterBackground
    {
        List<string> setSkills();

        List<string> setLanguages();

        List<string> setEquipment();

        List<string> setToolsProf();

        Dictionary<string, string> setFeatures();

        Dictionary<string, string> setSpecial();

        string setPersonalityTrait();

        string setIdeal();

        string setBond();

        string setFlaw();

        string setReason();
    }
}