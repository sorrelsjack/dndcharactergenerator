using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;

namespace dnd_character_gen.CharacterLife.Tables
{
    public class Boons
    {
        private string item = "";

        public Boons()
        {
        }

        public string Roll()
        {
            int randomNumber = NumberGen.gen(1, 11);

            switch (randomNumber)
            {
                case 1:
                    item = "Spell scroll (DM's choice)";
                    return "A friendly wizard gave you a spell scroll containing one cantrip (of the DM's choice).";

                case 2: return $"You saved the life of a commoner, who now owes you a life debt. This individual accompanies you on your travels and performs mundane tasks for you, but will leave if neglected, abused, or imperiled. Determine details about this character by using the supplemental tables and working with your DM.\n\n"; //TODO: generate an individual??
                case 3:
                    item = "Riding Horse";
                    return "You found a riding horse.";

                case 4:
                    item = $"{DiceRoll.roll(1, 20)} gp";
                    return $"You found some money. You have {item} in addition to your regular starting funds.";

                case 5:
                    item = SimpleWeapons.Instance.weapons[NumberGen.gen(SimpleWeapons.Instance.weapons.Count)];
                    return $"A relative bequeathed you a simple weapon of your choice. For you, this was a(n) {item}.";

                case 6:
                    item = Trinkets.Instance.trinkets[NumberGen.gen(Trinkets.Instance.trinkets.Length)];
                    return $"You found something interesting. You gain one additional trinket. For you, this was a(n) {item}.";

                case 7: return "You once performed a service for a local temple. The next time you visit the temple, you can receive healing up to your hit point maximum.";
                case 8:
                    item = NumberGen.gen(2) == 0 ? "Potion of healing" : "Flask of acid";
                    return $"A friendly alchemist gifted you with a potion of healing or a flask of acid, as you choose. For you, this was a(n) {item}.";

                case 9:
                    item = "Treasure map";
                    return "You found a treasure map.";

                case 10: return $"A distant relative left you a stipend that enables you to live at the comfortable lifestyle for {DiceRoll.roll(1, 20)} years. If you choose to live at a higher lifestyle, you reduce the price of the lifestyle by 2 gp during that time period.";

                default: return "";
            }
        }

        public string GetItem()
            => item;
    }
}