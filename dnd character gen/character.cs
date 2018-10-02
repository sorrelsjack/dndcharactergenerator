using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen {
    class character {
        string name;
        string adventureClass;
        string background;
        public string playerName = Environment.UserName;
        string race;
        string alignment; //TODO Lawful Good, Chaotic Good, Neutral Good, Lawful Neutral, True Neutral, Chaotic Neutral, Lawful Evil, Chaotic Evil, Neutral Evil
        public int xp = 0;

        public int strength { get; private set; }
        public int dexterity { get; private set; }
        public int constitution { get; private set; }
        public int intelligence { get; private set; }
        public int wisdom { get; private set; }
        public int charisma { get; private set; }

        public int strengthModifier { get; private set; }
        public int dexterityModifier { get; private set; }
        public int constitutionModifier { get; private set; }
        public int intelligenceModifier { get; private set; }
        public int wisdomModifier { get; private set; }
        public int charismaModifier { get; private set; }

        private int generateStat() {
            int stat = 0;
            int[] generatedNumbers = new int[4];
            int lowestValue = 0;
            int lowestValueCount = 0;

            for (int i = 0; i < 3; i++) {
                Random rnd = new Random(Guid.NewGuid().GetHashCode());
                int randomNumber = rnd.Next(1, 7);
                generatedNumbers[i] = randomNumber;
            }

            for (int i = 0; i < generatedNumbers.Length; i++) {
                if(lowestValue > generatedNumbers[i]) {
                    lowestValue = generatedNumbers[i];
                }
            }

            for (int i = 0; i < generatedNumbers.Length; i++) {
                if (lowestValue == generatedNumbers[i] && lowestValueCount < 1) {
                    lowestValueCount++;
                }
                else {
                    stat = stat + generatedNumbers[i];
                }
            }

            return stat;
        }

        public void generateStatArray() {
            int[] statArray = new int[6];
            for (int i = 0; i < 6; i++) {
                statArray[i] = generateStat();
            }
            strength = statArray[0]; //TODO optomise for each class
            dexterity = statArray[1];
            constitution = statArray[2];
            intelligence = statArray[3];
            wisdom = statArray[4];
            charisma = statArray[5];
        }

        public void calculateStatModifier(int stat) {
            int modifier = 0; //TODO calculate modifiers for all stats.. make reusable code
            if (stat == 1) {
                modifier = -5;
            }
            if (stat == 2 || stat == 3) {
                modifier = -4;
            }
            if (stat == 4 || stat == 5) {
                modifier = -3;
            }
            if (stat == 6 || stat == 7) {
                modifier = -2;
            }
            if (stat == 8 || stat == 9) {
                modifier = -1;
            }
            if (stat == 10 || stat == 11) {
                modifier = 0;
            }
            if (stat == 12 || stat == 13) {
                modifier = 1;
            }
            if (stat == 14 || stat == 15) {
                modifier = 2;
            }
            if (stat == 16 || stat == 17) {
                modifier = 3;
            }
            if (stat == 18 || stat == 19) {
                modifier = 4;
            }
            if (stat == 20 || stat == 21) {
                modifier = 5;
            }
        }
    }
}
