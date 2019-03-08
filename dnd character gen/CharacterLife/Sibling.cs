using dnd_character_gen.Extensions;

namespace dnd_character_gen.CharacterLife
{
    public class Sibling : Individual
    {
        public string birthOrder = "";

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