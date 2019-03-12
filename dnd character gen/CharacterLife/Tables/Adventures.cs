using dnd_character_gen.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterLife.Tables {
    public class Adventures 
    {
        public Adventures()
        {

        }

        public string Roll() 
        {
            string result = "";
            int randomNumber = NumberGen.gen(101);

            if (1 <= randomNumber && randomNumber <= 10)
                result = $"You nearly died. You have nasty scars on your body, and you are missing an ear, {DiceRoll.roll(1, 3)} fingers, or {DiceRoll.roll(1, 4)} toes.";
            else if (11 <= randomNumber && randomNumber <= 20)
                result = "You suffered a grievous injury. Although the wound healed, it still pains you from time to time.";
            else if (21 <= randomNumber && randomNumber <= 30)
                result = "You were wounded, but in time you fully recovered.";
            else if (31 <= randomNumber && randomNumber <= 40)
                result = "You contracted a disease while exploring a filthy warren.You recovered from the disease, but you have a persistent cough, pockmarks on your skin, or prematurely gray hair.";
            else if (41 <= randomNumber && randomNumber <= 50)
                result = "You were poisoned by a trap or a monster. You recovered, but the next time you must make a saving throw against poison, you make the saving throw with disadvantage.";
            else if (51 <= randomNumber && randomNumber <= 60)
                result = "You lost something of sentimental value to you during your adventure. Remove one trinket from your possessions."; //TODO: Can I do something with this
            else if (61 <= randomNumber && randomNumber <= 70)
                result = "You were terribly frightened by something you encountered and ran away, abandoning your companions to their fate.";
            else if (71 <= randomNumber && randomNumber <= 80)
                result = "You learned a great deal during your adventure. The next time you make an ability check or a saving throw, you have advantage on the roll.";
            else if (81 <= randomNumber && randomNumber <= 90)
                result = $"You found some treasure on your adventure. You have {DiceRoll.roll(2, 6)} gp left from your share of it.";
            else if (91 <= randomNumber && randomNumber <= 99)
                result = $"You found a considerable amount of treasure on your adventure. You have {DiceRoll.roll(1, 20) + 50} gp left of your share of it.";
            else if (randomNumber == 100)
                result = $"You came across a common magic item (of the DM's choice)."; //TODO: generate magic items?

            return result;
        }
    }
}
