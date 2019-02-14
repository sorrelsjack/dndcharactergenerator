using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.Dictionaries {
    public class MartialWeapons {
        public List<string> weapons = new List<string>();

        private MartialWeapons() {
            weapons.Add("Battleaxe");
            weapons.Add("Flail");
            weapons.Add("Glaive");
            weapons.Add("Greataxe");
            weapons.Add("Greatsword");
            weapons.Add("Halberd");
            weapons.Add("Lance");
            weapons.Add("Longsword");
            weapons.Add("Maul");
            weapons.Add("Morningstar");
            weapons.Add("Pike");
            weapons.Add("Rapier");
            weapons.Add("Scimitar");
            weapons.Add("Shortsword");
            weapons.Add("Trident");
            weapons.Add("War Pick");
            weapons.Add("Warhammer");
            weapons.Add("Whip");

            weapons.Add("Blowgun");
            weapons.Add("Crossbow, hand");
            weapons.Add("Crossbow, heavy");
            weapons.Add("Longbow");
            weapons.Add("Net");
        }

        private static MartialWeapons instance;

        public static MartialWeapons Instance {
            get {
                if(instance == null) {
                    instance = new MartialWeapons();
                }
                return instance;
            }
        }
    }
}
