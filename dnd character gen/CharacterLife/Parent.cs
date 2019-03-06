using dnd_character_gen.Extensions;

namespace dnd_character_gen.CharacterLife
{
    public class Parent : Individual //TODO: Complete
    {
        public string absenceReason = "";

        public Parent()
        {
        }

        public void setRace(string race)
        {
            this.race = race;
        }

        public void setAbsence() 
        {
            int randomNumber = DiceRoll.roll(1, 4);

            switch (randomNumber) 
            {
                case 1: absenceReason = "Died"; setCauseOfDeath(); break;
                case 2: absenceReason = "Imprisoned, enslaved, or otherwise taken away."; break;
                case 3: absenceReason = "Abandoned you."; break;
                case 4: absenceReason = "Disappeared to an unknown fate"; break;
            }

        }
    }
}