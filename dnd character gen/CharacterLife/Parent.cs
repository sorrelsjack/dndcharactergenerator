using dnd_character_gen.Extensions;
using System.Collections.Generic;

namespace dnd_character_gen.CharacterLife
{
    public class Parent : Individual
    {
        public string absenceReason = "";

        public Parent()
        {
        }

        public string getString() 
        {
            Dictionary<string, string> parentAttributes = new Dictionary<string, string>
            {
                { "Status", status },
                { "Cause of Death", causeOfDeath },
                { "Reason for Absence", absenceReason },
                { "Relationship", relationship },
                { "Race", race },
                { "Alignment", alignment },
                { "Class", adventureClass },
                { "Occupation", occupation }
            };

            string parentString = "";

            foreach(var item in parentAttributes) 
            {
                if (!string.IsNullOrWhiteSpace(item.Value))
                    parentString += $"\n{item.Key}: {item.Value}";
            }

            return parentString;
        }

        public void setRace(string race) //TODO: Fix issue where entire race shows up
        {
            this.race = race;
        }

        public void setAbsence() 
        {
            int randomNumber = DiceRoll.roll(1, 4);

            switch (randomNumber) 
            {
                case 1: absenceReason = "Died"; setCauseOfDeath(); break;
                case 2: absenceReason = "Imprisoned, enslaved, or otherwise taken away"; break;
                case 3: absenceReason = "Abandoned you"; break;
                case 4: absenceReason = "Disappeared to an unknown fate"; break;
            }

        }
    }
}