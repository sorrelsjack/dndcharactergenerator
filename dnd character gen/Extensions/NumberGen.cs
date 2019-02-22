﻿using System;

namespace dnd_character_gen.Extensions
{
    public class NumberGen
    {
        public static int gen(int endNumber)
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            return rnd.Next(0, endNumber);
        }
    }
}