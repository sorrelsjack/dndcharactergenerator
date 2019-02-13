using dnd_character_gen.CharacterClasses;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen {
    public class Character {
        public string name;
        public string adventureClass; //TODO replace with interface
        public int level = 1;
        public string background;
        public string race;
        public string alignment;
        public int xp = 0;

        public List<string> skillProficiencies = new List<string>(); //TODO populate this with race, class, and background skills. Check to make sure a skill isn't picked twice.

        public ICharacterClass characterClass { get; set; }
        public ICharacterRace characterRace { get; set; }
        public ICharacterBackground characterBackground { get; set; }

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

        public int hitDie { get; set; }

        public int proficiencyBonus = 2;

        public void generateBasicInfo() {
            this.adventureClass = generateClass();
            this.background = generateBackground();
            this.race = generateRace();
            this.alignment = generateAlignment();
        }

        private string generateClass() {
            string adventureClass = "";
            int randomNumber = NumberGen.gen(12);
            if (randomNumber == 1) {
                adventureClass = "Barbarian";
                characterClass = new Barbarian();
            }
            else if (randomNumber == 2) {
                adventureClass = "Bard";
            }
            else if (randomNumber == 3) {
                adventureClass = "Cleric";
            }
            else if (randomNumber == 4) {
                adventureClass = "Druid";
            }
            else if (randomNumber == 5) {
                adventureClass = "Fighter";
            }
            else if (randomNumber == 6) {
                adventureClass = "Monk";
            }
            else if (randomNumber == 7) {
                adventureClass = "Paladin";
            }
            else if (randomNumber == 8) {
                adventureClass = "Ranger";
            }
            else if (randomNumber == 9) {
                adventureClass = "Rogue";
            }
            else if (randomNumber == 10) {
                adventureClass = "Sorcerer";
            }
            else if (randomNumber == 11) {
                adventureClass = "Warlock";
            }
            else if(randomNumber == 12) {
                adventureClass = "Wizard";
            }
            return adventureClass;
        }

        private string generateBackground() {
            string background = "";
            int randomNumber = NumberGen.gen(18);

            if (randomNumber == 1)
                background = "Acolyte";
            else if (randomNumber == 2)
                background = "Charlatan";
            else if (randomNumber == 3)
                background = "Criminal";
            else if (randomNumber == 4)
                background = "Entertainer";
            else if (randomNumber == 5)
                background = "Folk Hero";
            else if (randomNumber == 6)
                background = "Gladiator";
            else if (randomNumber == 7)
                background = "Guild Artisan";
            else if (randomNumber == 8)
                background = "Guild Merchant";
            else if (randomNumber == 9)
                background = "Hermit";
            else if (randomNumber == 10)
                background = "Knight";
            else if (randomNumber == 11)
                background = "Noble";
            else if (randomNumber == 12)
                background = "Outlander";
            else if (randomNumber == 13)
                background = "Pirate";
            else if (randomNumber == 14)
                background = "Sage";
            else if (randomNumber == 15)
                background = "Sailor";
            else if (randomNumber == 16)
                background = "Solider";
            else if (randomNumber == 17)
                background = "Spy";
            else if (randomNumber == 18)
                background = "Urchin";

            return background;
        }

        private string generateRace() {
            string race = "";
            int randomNumber = NumberGen.gen(9);

            if (randomNumber == 1)
                race = "Dragonborn";
            if (randomNumber == 2)
                race = "Dwarf";
            if (randomNumber == 3)
                race = "Elf";
            if (randomNumber == 4)
                race = "Gnome";
            if (randomNumber == 5)
                race = "Half-Elf";
            if (randomNumber == 6)
                race = "Halfling";
            if (randomNumber == 7)
                race = "Half-Orc";
            if (randomNumber == 8)
                race = "Human";
            if (randomNumber == 9)
                race = "Tiefling";

            return race;
        }

        private string generateAlignment() {
            string alignment = "";
            int randomNumber = NumberGen.gen(9);

            if (randomNumber == 1) {
                alignment = "Lawful Good";
            }
            else if(randomNumber == 2) {
                alignment = "Neutral Good";
            }
            else if (randomNumber == 3) {
                alignment = "Chaotic Good";
            }
            else if(randomNumber == 4) {
                alignment = "Lawful Neutral";
            }
            else if (randomNumber == 5) {
                alignment = "True Neutral";
            }
            else if (randomNumber == 6) {
                alignment = "Chaotic Neutral";
            }
            else if (randomNumber == 7) {
                alignment = "Lawful Evil";
            }
            else if(randomNumber == 8) {
                alignment = "Neutral Evil";
            }
            else if(randomNumber == 9) {
                alignment = "Chaotic Evil";
            }
            return alignment;
        }

        private int generateStat() {
            int stat = 0;
            int[] generatedNumbers = new int[4];
            int lowestValue = 0;
            int lowestValueCount = 0;

            for (int i = 0; i < 3; i++) {
                Random rnd = new Random(Guid.NewGuid().GetHashCode()); //TODO convert this to my extension method
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
            strength = statArray[0]; //TODO optomize for each class.. Prioritize certain stats for certain classes.
            dexterity = statArray[1];
            constitution = statArray[2];
            intelligence = statArray[3];
            wisdom = statArray[4];
            charisma = statArray[5];

            strengthModifier = calculateStatModifier(strength);
            dexterityModifier = calculateStatModifier(dexterity);
            constitutionModifier = calculateStatModifier(constitution);
            intelligenceModifier = calculateStatModifier(intelligence);
            wisdomModifier = calculateStatModifier(wisdom);
            charismaModifier = calculateStatModifier(charisma);
        }

        private int calculateStatModifier(int stat) {
            int modifier = 0;
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
            return modifier;
        }
    }
}
