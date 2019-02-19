using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.Interfaces
{
    public interface ICharacterSubClass {
        string setName(); //Don't really need this?
        Dictionary<string, string> setFeatures();
        List<string> setArmorProf();
        List<string> setWeaponProf();
    }
}
