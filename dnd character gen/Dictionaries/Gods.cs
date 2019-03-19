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
    }

    public class Gods 
    {
        public List<God> gods = new List<God>(); //todo finish filling out gods

        private Gods () 
        {
            //Forgotten realms gods. Maybe include pantheon gods.
            gods.Add(new God("Auril, goddess of winter", "Neutral Evil", new string[] { "Nature", "Tempest" }, "Six-pointed snowflake"));
            gods.Add(new God("Azuth, god of wizards", "Lawful Neutral", new string[] { "Knowledge" }, "Left hand pointing upward, outlined in fire"));
            gods.Add(new God("Bane, god of tyranny", "Lawful Evil", new string[] { "War" }, "Upright black right hand, thumb and fingers together"));
            gods.Add(new God("Beshaba, goddess of misfortune", "Chaotic Evil", new string[] { "Trickery" }, "Black antlers"));
            gods.Add(new God("Bhaal, god of murder", "Neutral Evil", new string[] { "Death" }, "Skull surrounded by a ring of blood droplets"));
            gods.Add(new God("Chauntea, goddess of agriculture", "Neutral Good", new string[] { "Life" }, "Sheaf of grain or a blooming rose over grain"));
            gods.Add(new God("Cyric, god of lies", "Chaotic Evil", new string[] { "Trickery" }, "White jawless skull on black or purple sunburst"));
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
