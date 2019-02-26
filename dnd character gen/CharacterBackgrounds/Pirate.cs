using System.Collections.Generic;

namespace dnd_character_gen.CharacterBackgrounds
{
    public class Pirate : Sailor
    {
        public override Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Bad Reputation", "No matter where you go, people are afraid of you due to your reputation. When you are in a civilized settlement, you can get away with minor criminal offenses, such as refusing to pay for food at a tavern or breaking down doors at a local shop, since most people will not report your activity to the authorities." },
            { "Sailor Variant: Pirate", "You spent your youth under the sway of a dread pirate, a ruthless cutthroat w ho taught you how to survive in a world of sharks and savages. You’ve indulged in larceny on the high seas and sent more than one deserving soul to a briny grave. Fear and bloodshed are no strangers to you, and you’ve garnered a somewhat unsavory reputation in many a port town. If you decide that your sailing career involved piracy, you can choose the Bad Reputation feature instead of the Ship’s Passage feature." }
        };
    }
}