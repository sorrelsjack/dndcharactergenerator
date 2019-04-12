using System.Collections.Generic;
using dnd_character_gen.CharacterRaces;

namespace dnd_character_gen.CharacterSubRaces
{
    public class ForestGnome : Gnome
    {
        public override Dictionary<string, int> setAbilityScores() => new Dictionary<string, int>
        {
            { "Intelligence", 2 },
            { "Dexterity", 1 }
        };

        public override Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Darkvision", "Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray." },
            { "Natural Illusionist", "You know the minor illusion cantrip. Intelligence is your spellcasting ability for it." },
            { "Speak with Small Beasts", "Through sounds and gestures, you can communicate simple ideas with Small or smaller beasts. Forest gnomes love animals and often keep squirrels, badgers, rabbits, moles, woodpeckers, and other creatures as beloved pets." },
            { "Gnome Cunning", "You have advantage on all Intelligence, Wisdom, and Charisma saving throws against magic." }
        };
    }
}