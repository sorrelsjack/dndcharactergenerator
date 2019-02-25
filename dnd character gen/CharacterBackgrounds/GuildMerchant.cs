using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterBackgrounds
{
    public class GuildMerchant : GuildArtisan
    {
        private int randomNumber = 0;

        public GuildMerchant() 
        {
            randomNumber = NumberGen.gen(2);
        }

        public override Dictionary<string, string> setFeatures() => new Dictionary<string, string> 
        {
            { "Variant Guild Artisan: Guild Merchant", " You don’t craft items yourself but earn a living by buying and selling the works of others (or the raw materials artisans need to practice their craft). Your guild might be a large merchant consortium (or family) with interests across the region. Perhaps you transported goods from one place to another, by ship, wagon, or caravan, or bought them from traveling traders and sold them in your own little shop. In some ways, the traveling merchant’s life lends itself to adventure far more than the life of an artisan. Rather than proficiency with artisan’s tools, you might be proficient with navigator’s tools or an additional language. And instead of artisan’s tools, you can start with a mule and a cart." }
        };

        public override List<string> setToolsProf() => (randomNumber == 0) ? new List<string> { "Navigator's tools" } : null;

        public override List<string> setEquipment() => new List<string>
        {
            "Mule and a cart", $"{(randomNumber == 0 ? "Navigator's tools" : "" )}", "Letter of introduction from guild",
            "Set of traveler's clothes", "Belt pouch containing 15 gp"
        };

        public override List<string> setLanguages() 
        {
            List<string> languages = new List<string>();
            string language;

            if (randomNumber == 1) 
            {
                while (languages.Count < 2) {
                    language = Languages.Instance.languages[NumberGen.gen(Languages.Instance.languages.Count)];
                    if (!languages.Contains(language))
                        languages.Add(language);
                }
                return languages;
            }
            else 
            {
                return new List<string> { Languages.Instance.languages[NumberGen.gen(Languages.Instance.languages.Count)] };
            }
        } 
    }
}
