using System.Collections.Generic;
using dnd_character_gen.Extensions;

namespace dnd_character_gen.CharacterLife.Tables
{
    internal class Tragedies
    {
        private Individual individual;

        public Tragedies(Parent[] parents, List<Sibling> siblings) //And adoptive family and any pals from childhood :)
        {
        }

        public string Roll()
        {
            int randomNumber = NumberGen.gen(1, 13);

            switch (randomNumber)
            { //TODO complete tragedy table rolls
                case 1:
                case 2: return "A family member or a close friend died. Roll on the Cause of Death supplemental table to find out how."; //this. If it's a clos friend, generate them and then kill them lol
                case 3: return $"A friendship ended bitterly, and the other person is now hostile to you. The cause might have been a misunderstanding or something you or the former friend did.\n\n{new Individual().getString()}";
                case 4: return "You lost all your possessions in a disaster, and you had to rebuild your life.";
                case 5: return $"You were imprisoned for a crime you didn’t commit and spent {DiceRoll.roll(1, 6)} years at hard labor, in jail, or shackled to an oar in a slave galley.";
                case 6: return "War ravaged your home community, reducing everything to rubble and ruin. In the aftermath, you either helped your town rebuild or moved somewhere else.";
                case 7:
                    individual = new Individual("???");
                    individual = Individual.generateIndividual();
                    return $"A lover disappeared without a trace. You have been looking for that person ever since.\n\n{individual.getString()}";

                case 8: return "A terrible blight in your home community caused crops to fail, and many starved. You lost a sibling or some other family member."; //this
                case 9: return "You did something that brought terrible shame to you in the eyes of your family. You might have been involved in a scandal, dabbled in dark magic, or offended someone important. The attitude of your family members toward you becomes indifferent at best, though they might eventually forgive you.";
                case 10: return "For a reason you were never told, you were exiled from your community. You then either wandered in the wilderness for a time or promptly found a new place to live.";
                case 11:
                    individual = new Individual();
                    individual = Individual.generateIndividual();
                    return $"A romantic relationship ended. {(DiceRoll.roll(1, 6) % 2 == 0 ? "It ended amicably." : "It ended with bad feelings.")}\n\n{individual.getString()}";

                case 12:
                    individual = new Individual("Dead");
                    individual = Individual.generateIndividual();
                    int murderChance = DiceRoll.roll(1, 12);
                    return $"A current or prospective romantic partner of yours died. " +
                           $"{(individual.causeOfDeath == "Murdered" ? (murderChance == 1 ? "You were directly or indirectly responsible for their death." : "You were not responsible for their death.") : "")}\n\n{individual.getString()}";

                default: return "";
            }
        }
    }
}