using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.Dictionaries {
    public class SimpleWeapons {
        public List<string> weapons = new List<string>();

        private SimpleWeapons() {
            weapons.Add("Club");
            weapons.Add("Dagger");
            weapons.Add("Greatclub");
            weapons.Add("Handaxe");
            weapons.Add("Javelin");
            weapons.Add("Light Hammer");
            weapons.Add("Mace");
            weapons.Add("Quarterstaff");
            weapons.Add("Sickle");
            weapons.Add("Spear");

            weapons.Add("Crossbow, light");
            weapons.Add("Dart");
            weapons.Add("Shortbow");
            weapons.Add("Sling");
        }

        private static SimpleWeapons instance;

        public static SimpleWeapons Instance {
            get {
                if(instance == null) {
                    instance = new SimpleWeapons();
                }
                return instance;
            }
        }
    }
}
