using dnd_character_gen.Extensions;

namespace dnd_character_gen.CharacterLife.Tables
{
    public class Boons
    {
        public Boons()
        {
        }

        public string Roll()
        {
            int randomNumber = NumberGen.gen(1, 11); //TODO: could we maybe have functions to return features and inventory stuff?

            switch (randomNumber)
            {
                case 1: return "A friendly wizard gave you a spell scroll containing one cantrip (of the DM's choice).";
                case 2: return $"You saved the life of a commoner, who now owes you a life debt. This individual accompanies you on your travels and performs mundane tasks for you, but will leave if neglected, abused, or imperiled. Determine details about this character by using the supplemental tables and working with your DM.\n\n"; //TODO: generate an individual??
                case 3: return "You found a riding horse."; //TODO: add horse to inventory?
                case 4: return $"You found some money. You have {DiceRoll.roll(1, 20)} gp in addition to your regular starting funds.";
                case 5: return "A relative bequeathed you a simple weapon of your choice.";
                case 6: return "You found something interesting. You gain one additional trinket."; //todo add trinket to inventory?
                case 7: return "You once performed a service for a local temple. The next time you visit the temple, you can receive healing up to your hit point maximum.";
                case 8: return "A friendly alchemist gifted you with a potion of healing or a flask of acid, as you choose.";
                case 9: return "You found a treasure map.";
                case 10: return $"A distant relative left you a stipend that enables you to live at the comfortable lifestyle for {DiceRoll.roll(1, 20)} years. If you choose to live at a higher lifestyle, you reduce the price of the lifestyle by 2 gp during that time period.";

                default: return "";
            }
        }
    }
}