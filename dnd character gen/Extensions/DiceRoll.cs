namespace dnd_character_gen.Extensions
{
    public class DiceRoll
    {
        public static int roll(string dice)
        {
            int number = dice[0];
            int die = dice[2];
            int total = 0;

            for (int i = 0; i < number; i++)
            {
                total += NumberGen.gen(1, die);
            }

            return total;
        }
    }
}