using System.Collections.Generic;
using dnd_character_gen.Extensions;

namespace dnd_character_gen.CharacterLife.Tables
{
    internal class SupernaturalEvents
    {
        public SupernaturalEvents()
        {
        }

        public string Roll()
        {
            string result = "";
            int randomNumber = NumberGen.gen(101);

            if (1 <= randomNumber && randomNumber <= 5)
                result = $"You were ensorcelled by a fey and enslaved for {DiceRoll.roll(1, 6)} years before you escaped.";
            else if (6 <= randomNumber && randomNumber <= 10)
                result = "You saw a demon and ran away before it could do anything to you.";
            else if (11 <= randomNumber && randomNumber <= 15)
                result = "A devil tempted you. Make a DC 10 Wisdom saving throw. On a failed save, your alignment shifts one step toward evil (if it’s not evil already), and you start the game with an additional 1d20 + 50 gp."; //TODO: wtf to do with this
            else if (16 <= randomNumber && randomNumber <= 20)
                result = "You woke up one morning miles from your home, with no idea how you got there.";
            else if (21 <= randomNumber && randomNumber <= 30)
                result = "You visited a holy site and felt the presence of the divine there.";
            else if (31 <= randomNumber && randomNumber <= 40)
                result = "You witnessed a falling red star, a face appearing in the frost, or some other bizarre happening. You are certain that it was an omen of some sort.";
            else if (41 <= randomNumber && randomNumber <= 50)
                result = "You escaped certain death and believe it was the intervention of a god that saved you.";
            else if (51 <= randomNumber && randomNumber <= 60)
                result = "You witnessed a minor miracle.";
            else if (61 <= randomNumber && randomNumber <= 70)
                result = "You explored an empty house and found it to be haunted.";
            else if (71 <= randomNumber && randomNumber <= 75)
            {
                Dictionary<int, string> creatures = new Dictionary<int, string>
                {
                    { 1, "Celestial" },
                    { 2, "Devil" },
                    { 3, "Demon" },
                    { 4, "Fey" },
                    { 5, "Elemental" },
                    { 6, "Undead" }
                };

                result = $"You were briefly possessed by a(n) {creatures[DiceRoll.roll(1, 6)]}.";
            }
            else if (76 <= randomNumber && randomNumber <= 80)
                result = "You saw a ghost.";
            else if (81 <= randomNumber && randomNumber <= 85)
                result = "You saw a ghoul feeding on a corpse.";
            else if (86 <= randomNumber && randomNumber <= 90)
                result = "A celestial or fiend visited you in your dreams to give a warning of dangers to come.";
            else if (91 <= randomNumber && randomNumber <= 95)
                result = "You briefly visited the Feywild or the Shadowfell.";
            else if (96 <= randomNumber && randomNumber <= 100)
                result = "You saw a portal that you believe leads to another plane or existence.";

            return result;
        }
    }
}