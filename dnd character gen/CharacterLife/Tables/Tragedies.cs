using dnd_character_gen.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterLife.Tables {
    class Tragedies {
        public Tragedies() {

        }

        public string Roll() {
            int randomNumber = NumberGen.gen(1, 13);

            switch (randomNumber) {
                case 1:
                case 2: return "A family member or a close friend died. Roll on the Cause of Death supplemental table to find out how."; 
                case 3: return "A friendship ended bitterly, and the other person is now hostile to you. The cause might have been a misunderstanding or something you or the former friend did.";
                case 4: return "You lost all your possessions in a disaster, and you had to rebuild your life.";
                case 5: return "You were imprisoned for a crime you didn’t commit and spent 1d6 years at hard labor, in jail, or shackled to an oar in a slave galley.";
                case 6: return "War ravaged your home community, reducing everything to rubble and ruin. In the aftermath, you either helped your town rebuild or moved somewhere else.";
                case 7: return "A lover disappeared without a trace. You have been looking for that person ever since.";
                case 8: return "A terrible blight in your home community caused crops to fail, and many starved. You lost a sibling or some other family member.";
                case 9: return "You did something that brought terrible shame to you in the eyes of your family. You might have been involved in a scandal, dabbled in dark magic, or offended someone important. The attitude of your family members toward you becomes indifferent at best, though they might eventually forgive you.";
                case 10: return "For a reason you were never told, you were exiled from your community. You then either wandered in the wilderness for a time or promptly found a new place to live.";
                case 11: return "A romantic relationship ended. Roll a d6. An odd number means it ended with bad feelings, while an even number means it ended amicably."; //TODO roll
                case 12: return "A current or prospective romantic partner of yours died. Roll on the Cause of Death supplemental table to find out how. If the result is murder, roll a d12. On a 1, you were responsible, whether directly or indirectly."; //TODO: roll

                default: return "";
            }
        }
    }
}
