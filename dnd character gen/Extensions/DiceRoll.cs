namespace dnd_character_gen.Extensions
{
    public class DiceRoll
    {
        public static int roll(int numberOfDie, int dieSides) //TODO: fix this so it takes two numbers as params
        {
            int number = numberOfDie;
            int die = dieSides;
            int total = 0;

            for (int i = 0; i < number; i++)
            {
                total += NumberGen.gen(1, die);
            }

            return total;
        }
    }
}