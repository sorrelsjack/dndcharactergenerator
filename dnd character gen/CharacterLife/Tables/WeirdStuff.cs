using dnd_character_gen.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterLife.Tables {
    class WeirdStuff {
        public WeirdStuff() {

        }

        public string Roll() {
            int randomNumber = NumberGen.gen(1, 13);

            switch (randomNumber) {
                case 1: return $"You were turned into a toad and remained in that form for {DiceRoll.roll(1, 4)} weeks.";
                case 2: return "You were petrified and remained a stone statue for a time until someone freed you.";
                case 3: return $"You were enslaved by a hag, a satyr, or some other being and lived in that creature’s thrall for {DiceRoll.roll(1, 6)} years.";
                case 4: return $"A dragon held you as a prisoner for {DiceRoll.roll(1, 4)} months until adventurers killed it.";
                case 5: return "You were taken captive by a race of evil humanoids such as drow, kuo-toa, or quaggoths. You lived as a slave in the Underdark until you escaped.";
                case 6: return "You served a powerful adventurer as a hireling. You have only recently left that service. Use the supplemental tables and work with your DM to determine the basic details about your former employer." +
                        $"\n{Individual.generateIndividual().getString()}";
                case 7: return $"You went insane for {DiceRoll.roll(1, 6)} years and recently regained your sanity. A tic or some other bit of odd behavior might linger.";
                case 8: return "A lover of yours was secretly a silver dragon.";
                case 9: return "You were captured by a cult and nearly sacrificed on an altar to the foul being the cultists served. You escaped, but you fear they will find you.";
                case 10: return "You met a demigod, an archdevil, an archfey, a demon lord, or a titan, and you lived to tell the tale.";
                case 11: return "You were swallowed by a giant fish and spent a month in its gullet before you escaped.";
                case 12: return "A powerful being granted you a wish, but you squandered it on something frivolous.";

                default: return "";
            }
        }
    }
}
