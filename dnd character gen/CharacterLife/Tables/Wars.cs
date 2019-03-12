using dnd_character_gen.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterLife.Tables {
    class Wars {
        public Wars() {

        }

        public string Roll() {
            int randomNumber = NumberGen.gen(1, 13);

            switch (randomNumber) {
                case 1: return "You were knocked out and left for dead. You woke up hours later with no recollection of the battle.";
                case 2:
                case 3: return "You were badly injured in the fight, and you still bear the awful scars of those wounds.";
                case 4: return "You ran away from the battle to save your life, but you still feel shame for your cowardice.";
                case 5:
                case 6:
                case 7: return "You suffered only minor injuries, and the wounds all healed without leaving scars.";
                case 8:
                case 9: return "You survived the battle, but you suffer from terrible nightmares in which you relive the experience.";
                case 10:
                case 11: return "You escaped the battle unscathed, though many of your friends were injured or lost.";
                case 12: return "You acquitted yourself well in battle and are remembered as a hero. You might have received a medal for your bravery.";

                default: return "";
            }
        }
    }
}
