using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.Interfaces {
    public interface ICharacterBackground {
        List<string> setSkills();
        List<string> setLanguages();
        List<string> setEquipment();
        Dictionary<string, string> setFeatures();
        string setSpecial();
        string setPersonalityTrait();
        string setIdeal();
        string setBond();
        string setFlaw();
    }
}
