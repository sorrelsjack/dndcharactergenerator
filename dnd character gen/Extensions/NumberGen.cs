using System;

namespace dnd_character_gen.Extensions
{
    public class NumberGen
    {
        public static int gen(int endNumber)
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            return rnd.Next(0, endNumber);
        }

        public static int gen(int startNumber, int endNumber) //Inclusive of one. I was NOT going to refactor the above method to accomodate this functionality.
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            return rnd.Next(startNumber, endNumber);
        }
    }
}