using System;

namespace dnd_character_gen.Extensions
{
    public class NumberGen
    {
        public static int gen(int endNumber)
        { //Use this wherever we need a random number.
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            return rnd.Next(1, endNumber) - 1;
        }
    }
}