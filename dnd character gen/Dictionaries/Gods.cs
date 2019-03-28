using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.Dictionaries {
    public class God
    {
        public string name = "";
        public string alignment = "";
        public string[] domains;
        public string symbol = "";

        public God(string name, string alignment, string[] domains, string symbol) 
        {
            this.name = name;
            this.alignment = alignment;
            this.domains = domains;
            this.symbol = symbol;
        }

        public string getString(string name) {
            God god = Gods.Instance.gods.FirstOrDefault(x => x.name.Contains(name));
            string godString = "";

            godString += $"\nName: {god.name}";
            godString += $"\nAlignment: {god.alignment}";
            godString += $"\nDomains: {string.Join(", ", god.domains)}";
            godString += $"\nSymbol: {god.symbol}";

            return godString;
        }
    }

    public static class GodExtensions 
    {
        public static string getString(this God god) {
            string godString = "";

            godString += $"\nName: {god.name}";
            godString += $"\nAlignment: {god.alignment}";
            godString += $"\nDomains: {string.Join(", ", god.domains)}";
            godString += $"\nSymbol: {god.symbol}";

            return godString;
        }
    }

    public class Gods 
    {
        public List<God> gods = new List<God>();

        private Gods () 
        {
            gods.Add(new God("Auril, goddess of winter", "Neutral Evil", new string[] { "Nature", "Tempest" }, "Six-pointed snowflake"));
            gods.Add(new God("Azuth, god of wizards", "Lawful Neutral", new string[] { "Knowledge" }, "Left hand pointing upward, outlined in fire"));
            gods.Add(new God("Bane, god of tyranny", "Lawful Evil", new string[] { "War" }, "Upright black right hand, thumb and fingers together"));
            gods.Add(new God("Beshaba, goddess of misfortune", "Chaotic Evil", new string[] { "Trickery" }, "Black antlers"));
            gods.Add(new God("Bhaal, god of murder", "Neutral Evil", new string[] { "Death" }, "Skull surrounded by a ring of blood droplets"));
            gods.Add(new God("Chauntea, goddess of agriculture", "Neutral Good", new string[] { "Life" }, "Sheaf of grain or a blooming rose over grain"));
            gods.Add(new God("Cyric, god of lies", "Chaotic Evil", new string[] { "Trickery" }, "White jawless skull on black or purple sunburst"));
            gods.Add(new God("Deneir, god of writing", "Neutral Good", new string[] { "Knowledge" }, "Lit candle above an open eye"));
            gods.Add(new God("Eldath, goddess of peace", "Neutral Good", new string[] { "Life", "Nature" }, "Waterfall plunging into still pool"));
            gods.Add(new God("Gond, god of craft", "Neutral", new string[] { "Knowledge" }, "Toothed cog with four spokes"));
            gods.Add(new God("Helm, god of protection", "Lawful Neutral", new string[] { "Life", "Light" }, "Staring eye on upright left gauntlet"));
            gods.Add(new God("Ilmater, god of endurance", "Lawful Good", new string[] { "Life" }, "Hands bound at the wrist with red cord"));
            gods.Add(new God("Kelemvor, god of the dead", "Lawful Neutral", new string[] { "Death" }, "Upright skeletal arm holding balanced scales"));
            gods.Add(new God("Lathander, god of birth and renewal", "Neutral Good", new string[] { "Life", "Light" }, "Road traveling into a sunrise"));
            gods.Add(new God("Leira, goddess of illusion", "Chaotic Neutral", new string[] { "Trickery" }, "Point-down triangle containing a swirl of mist"));
            gods.Add(new God("Lliira, goddess of joy", "Chaotic Good", new string[] { "Life" }, "Triangle of three six-pointed stars"));
            gods.Add(new God("Loviatar, goddess of pain", "Lawful Evil", new string[] { "Death" }, "Nine-tailed barbed scourage"));
            gods.Add(new God("Malar, god of the hunt", "Chaotic Evil", new string[] { "Nature" }, "Clawed paw"));
            gods.Add(new God("Mask, god of thieves", "Chaotic Neutral", new string[] { "Trickery" }, "Black mask"));
            gods.Add(new God("Mielikki, goddess of forests", "Neutral Good", new string[] { "Nature" }, "Unicorn's head"));
            gods.Add(new God("Milil, god of poetry and song", "Neutral Good", new string[] { "Light" }, "Five-stringed harp made of leaves"));
            gods.Add(new God("Myrkul, god of death", "Neutral Evil", new string[] { "Death" }, "White human skull"));
            gods.Add(new God("Mystra, goddess of magic", "Neutral Good", new string[] { "Knowledge" }, "Circle of seven stars, or nine stars encircling a flowing red mist, or a single star"));
            gods.Add(new God("Oghma, god of knowledge", "Neutral", new string[] { "Knowledge" }, "Blank scroll"));
            gods.Add(new God("Savras, god of divination and fate", "Lawful Neutral", new string[] { "Knowledge" }, "Crystal ball containing many kinds of eyes"));
            gods.Add(new God("Selûne, goddess of the moon", "Chaotic Good", new string[] { "Knowledge", "Life" }, "Pair of eyes surrounded by seven stars"));
            gods.Add(new God("Shar, goddess of darkness and loss", "Neutral Evil", new string[] { "Death", "Trickery" }, "Black disk encircled with a border"));
            gods.Add(new God("Silvanus, god of wild nature", "Neutral", new string[] { "Nature" }, "Oak leaf"));
            gods.Add(new God("Sune, goddess of love and beauty", "Chaotic Good", new string[] { "Life", "Light" }, "Face of a beautiful red-haired woman"));
            gods.Add(new God("Talona, goddess of disease and poison", "Chaotic Evil", new string[] { "Death" }, "Three teardrops on a triangle"));
            gods.Add(new God("Talos, god of storms", "Chaotic Evil", new string[] { "Tempest" }, "Three lightning bolts radiating from a central point"));
            gods.Add(new God("Tempus, god of war", "Neutral", new string[] { "War" }, "Upright flaming sword"));
            gods.Add(new God("Torm, god of courage and self-sacrifice", "Lawful Good", new string[] { "War" }, "White right gauntlet"));
            gods.Add(new God("Tymora, goddess of good fortune", "Chaotic Good", new string[] { "Trickery" }, "Face-up coin"));
            gods.Add(new God("Tyr, god of justice", "Lawful Good", new string[] { "War" }, "Balanced scale resting on a warhammer"));
            gods.Add(new God("Umberlee, goddess of the sea", "Chaotic Evil", new string[] { "Tempest" }, "Wave curling left and right"));
            gods.Add(new God("Waukeen, goddess of trade", "Neutral", new string[] { "Knowledge", "Trickery" }, "Upright coin with Waukeen's profile facing left"));
        }

        private static Gods instance;

        public static Gods Instance {
            get {
                if (instance == null) {
                    instance = new Gods();
                }

                return instance;
            }
        }
    }
}
