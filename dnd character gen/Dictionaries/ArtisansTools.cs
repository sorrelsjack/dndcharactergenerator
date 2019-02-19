using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.Dictionaries
{
    public class ArtisansTools {
        public List<string> tools = new List<string>();

        private ArtisansTools()
        {
            tools.Add("Alchemist's supplies");
            tools.Add("Brewer's supplies");
            tools.Add("Calligrapher's supplies");
            tools.Add("Carpenter's tools");
            tools.Add("Cartographer's tools");
            tools.Add("Cobbler's tools");
            tools.Add("Cook's utensils");
            tools.Add("Glassblower's tools");
            tools.Add("Jeweler's tools");
            tools.Add("Leatherworker's tools");
            tools.Add("Mason's tools");
            tools.Add("Painter's supplies");
            tools.Add("Potter's tools");
            tools.Add("Smith's tools");
            tools.Add("Tinker's tools");
            tools.Add("Weaver's tools");
            tools.Add("Woodcarver's tools");
        }

        private static ArtisansTools instance;

        public static ArtisansTools Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ArtisansTools();
                }
                return instance;
            }
        }
    }
}
