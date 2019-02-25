using System.Collections.Generic;

namespace dnd_character_gen.CharacterRaces
{
    public class MountainDwarf : Dwarf //TODO: Finish?
    {
        public override Dictionary<string, int> setAbilityScores() => new Dictionary<string, int>
        {
            { "Constitution", 2 },
            { "Strength", 2 }
        };

        public override List<string> setArmorProf() => new List<string> { "Light armor", "Medium armor" };
    }
}