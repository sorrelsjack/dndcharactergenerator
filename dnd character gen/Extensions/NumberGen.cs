using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.Extensions {
    public class NumberGen {
        public static int gen(int endNumber) { //Use this wherever we need a random number.
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            return rnd.Next(1, endNumber + 1); //Take the # of items and add one.
        }
    }
}
