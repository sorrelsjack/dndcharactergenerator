using dnd_character_gen.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterLife.Tables {
    public class Adventures 
    {
        public Adventures() //TODO: finish adventures table
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

            return result;
        }
    }
}
