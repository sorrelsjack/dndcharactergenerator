using dnd_character_gen.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterLife.Tables {
    public class ArcaneMatters {
        public ArcaneMatters() {

        }

        public string Roll() {
            int randomNumber = NumberGen.gen(1, 11);

            switch (randomNumber) {
                case 1: return "You were charmed or frightened by a spell.";
                case 2: return "You were injured by the effect of a spell.";
                case 3: return "You witnessed a powerful spell being cast by a cleric, a druid, a sorcerer, a warlock, or a wizard.";
                case 4: return "You drank a potion (of the DM's choice).";
                case 5: return "You found a spell scroll (of the DM's choice) and succeeded in casting the spell it contained.";
                case 6: return "You were affected by teleportation magic.";
                case 7: return "You turned invisible for a time.";
                case 8: return "You identified an illusion for what it was.";
                case 9: return "You saw a creature being conjured by magic.";
                case 10: return "Your fortune was read by a diviner. Roll twice on the Life Events table, but don't apply the results. Instead, the DM picks one event as a portent of your future (which might or might not come true).";

                default: return "";
            }

        }
    }
}
