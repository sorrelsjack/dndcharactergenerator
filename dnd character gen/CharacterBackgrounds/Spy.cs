using System.Collections.Generic;

namespace dnd_character_gen.CharacterBackgrounds
{
    public class Spy : Criminal
    {
        public override Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Criminal Variant: Spy", "Although your capabilities are not much different from those of a burglar or smuggler, you learned and practiced them in a very different context: as an espionage agent.You might have been an officially sanctioned agent of the crown, or perhaps you sold the secrets you uncovered to the highest bidder." }
        };
    }
}