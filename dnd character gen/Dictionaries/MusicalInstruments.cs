using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.Dictionaries {
    public class MusicalInstruments {
        public List<string> instruments = new List<string>();

        private MusicalInstruments() {
            instruments.Add("Bagpipes");
            instruments.Add("Drum");
            instruments.Add("Dulcimer");
            instruments.Add("Flute");
            instruments.Add("Lute");
            instruments.Add("Lyre");
            instruments.Add("Horn");
            instruments.Add("Pan flute");
            instruments.Add("Shawm");
            instruments.Add("Viol");
        }

        private static MusicalInstruments instance;

        public static MusicalInstruments Instance {
            get {
                if(instance == null) {
                    instance = new MusicalInstruments();
                }
                return instance;
            }
        }
    }
}
