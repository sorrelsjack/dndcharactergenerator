using dnd_character_gen.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterLife.Tables {
    class Crimes {
        public Crimes() {

        }

        public string Roll() {
            int randomNumber = NumberGen.gen(1, 9);

            switch (randomNumber) {
                case 1: return "Murder";
                case 2: return "Theft";
                case 3: return "Burglary";
                case 4: return "Assault";
                case 5: return "Smuggling";
                case 6: return "Kidnapping";
                case 7: return "Extortion";
                case 8: return "Counterfeiting";

                default: return "";
            }
        }
    }
}
