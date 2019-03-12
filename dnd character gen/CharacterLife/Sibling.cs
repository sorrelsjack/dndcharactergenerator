using dnd_character_gen.Extensions;
using System.Collections.Generic;

namespace dnd_character_gen.CharacterLife
{
    public class Sibling : Individual
    {
        public string birthOrder = "";

        public override string getString() {
            Dictionary<string, string> siblingAttributes = new Dictionary<string, string>
            {
                { "Status", status },
                { "Cause of Death", causeOfDeath },
                { "Birth Order", birthOrder },
                { "Relationship", relationship },
                { "Race", race },
                { "Alignment", alignment },
                { "Class", adventureClass },
                { "Occupation", occupation }
            };

            string siblingString = "";

            foreach (var item in siblingAttributes) {
                if (!string.IsNullOrWhiteSpace(item.Value))
                    siblingString += $"\n{item.Key}: {item.Value}";
            }

            return siblingString;
        }

        public void setBirthOrder()
        {
            int randomNumber = DiceRoll.roll(2, 6);

            if (randomNumber == 2)
                birthOrder = "Twin, triplet, or quadruplet";
            else if (3 <= randomNumber && randomNumber <= 7)
                birthOrder = "Older";
            else if (8 <= randomNumber && randomNumber <= 12)
                birthOrder = "Younger";
        }

        public void setRace(string race)
        {
            this.race = race;
        }
    }
}