using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterSubClasses
{
    public class FiendWarlock : ICharacterSubClass {
        public List<string> setArmorProf() => null;

        public Dictionary<string, string> setFeatures() => new Dictionary<string, string> {
            { "Dark One's Blessing", "-When you kill a hostile creature, you gain temporary hit points equal to your Charisma modifier + your warlock level" }
        };

        public List<string> setLanguageProf() => null;

        public string setName()
        {
            throw new NotImplementedException();
        }

        public List<string> setSkillProf() => null;

        public List<string> setWeaponProf() => null;
    }
}
