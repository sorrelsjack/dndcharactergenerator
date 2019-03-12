using dnd_character_gen.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterLife.Tables {
    class Punishments {
        public Punishments() {

        }

        public string Roll() {
            int randomNumber = NumberGen.gen(1, 13);

            switch (randomNumber) {
                case 1:
                case 2:
                case 3: return "You did not commit the crime and were exonerated after being accused.";
                case 4:
                case 5:
                case 6: return "You committed the crime or helped do so, but nonetheless the authorities found you not guilty.";
                case 7:
                case 8: return "You were nearly caught in the act. You had to flee and are wanted in the community where the crime occurred.";
                case 9:
                case 10:
                case 11:
                case 12: return $"You were caught and convicted. You spent time in jail, chained to an oar, or performing hard labor. You served a sentence of {DiceRoll.roll(1, 4)} years or succeeded in escaping after that much time.";

                default: return "";
            }
        }
    }
}
