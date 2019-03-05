using System.Collections.Generic;
using dnd_character_gen.Extensions;

namespace dnd_character_gen.CharacterLife
{
    public class CharacterBackstory
    {
        public Parent[] parents = new Parent[2]; //TODO: null if parent  is not known
        public List<Sibling> siblings = new List<Sibling>();
        public string birthplace = "";
        public string strangeBirthEvent = ""; //TODO
        public string family = "";
        public string familyLifestyle = "";
        public string childhoodHome = "";
        public string childhoodMemory = "";
        public string age = "";
        public int numberOfLifeEvents = 0;
        public List<string> lifeEvents = new List<string>();

        public Dictionary<string, int> familyLifestyles = new Dictionary<string, int>
        {
            { "Wretched", -40 },
            { "Squalid", -20 },
            { "Poor", -10 },
            { "Modest", 0 },
            { "Comfortable", 10 },
            { "Wealthy", 20 },
            { "Aristocratic", 40 }
        };

        public Dictionary<string, string> ageLifeEvents = new Dictionary<string, string> //TODO: possibly remove
        {
            { "20 years or younger", "1" },
            { "21-30 years", "1d4" },
            { "31-40", "1d6" },
            { "41-50", "1d8" },
            { "51-60", "1d10" },
            { "61 years or older", "1d12" }
        };

        public CharacterBackstory()
        {

        }

        public void setParentage(string race)
        {
            int randomNumber = NumberGen.gen(1, 101); //100 inclusive.
            if (randomNumber < 96)
            {
                if (race.Contains("Half-Elf"))
                {
                    randomNumber = NumberGen.gen(1, 9);
                    if (randomNumber < 6)
                    {
                        randomNumber = NumberGen.gen(2); //One was an elf, the other was human
                    }
                    else if (randomNumber == 6)
                    {
                        //One was an elf, the other was half-elf
                    }
                    else if (randomNumber == 7)
                    {
                        //One was a human, other was half-elf
                    }
                    else if (randomNumber == 8)
                    {
                        //Both were half-elves
                    }
                }
                else if (race.Contains("Half-Orc"))
                {
                    randomNumber = NumberGen.gen(1, 9);
                    if (randomNumber < 4)
                    {
                        //One parent was Orc, other was human
                    }
                    else if (randomNumber == 4 || randomNumber == 5)
                    {
                        //One was Orc, other was half-orc
                    }
                    else if (randomNumber == 6 || randomNumber == 7)
                    {
                        //One was human, other was half-orc
                    }
                    else if (randomNumber == 8)
                    {
                        //Both were half-orcs
                    }
                }
                else if (race == "Tiefling")
                {
                    randomNumber = NumberGen.gen(1, 9);
                    if (randomNumber < 5)
                    {
                        //Both were human, infernal hertiage dormant
                    }
                    else if (randomNumber == 5 || randomNumber == 6)
                    {
                        //One was tiefling, other human
                    }
                    else if (randomNumber == 7)
                    {
                        //One was tiefling, other was devil
                    }
                    else if (randomNumber == 8)
                    {
                        //One was human, other was devil
                    }
                }
                else
                {
                    parents[0].race = race; //TODO: getting NRE here, so init if needed
                    parents[1].race = race;
                }
            }
            else
            {
                //You don't know who your parents are or were. Just keep them as null
            }
        }

        public void setBirthplace()
        {
            int randomNumber = NumberGen.gen(1, 101);
            if (randomNumber <= 50)
                birthplace = "Home";
            else if (51 <= randomNumber && randomNumber <= 55)
                birthplace = "Home of a family friend";
            else if (56 <= randomNumber && randomNumber <= 63)
                birthplace = "Home of a healer or midwife";
            else if (randomNumber == 64 || randomNumber == 65)
                birthplace = "Carriage, cart, or wagon";
            else if (66 <= randomNumber && randomNumber <= 68)
                birthplace = "Barn, shed, or other outbuilding";
            else if (randomNumber == 69 || randomNumber == 70)
                birthplace = "Cave";
            else if (randomNumber == 71 || randomNumber == 72)
                birthplace = "Field";
            else if (randomNumber == 73 || randomNumber == 74)
                birthplace = "Forest";
            else if (75 <= randomNumber && randomNumber <= 77)
                birthplace = "Temple";
            else if (randomNumber == 78)
                birthplace = "Battlefield";
            else if (randomNumber == 79 || randomNumber == 80)
                birthplace = "Alley or street";
            else if (randomNumber == 81 || randomNumber == 82)
                birthplace = "Brothel, tavern, or inn";
            else if (randomNumber == 83 || randomNumber == 84)
                birthplace = "Castle, keep, tower, or palace";
            else if (randomNumber == 85)
                birthplace = "Sewer or rubbish heap";
            else if (86 <= randomNumber && randomNumber <= 88)
                birthplace = "Among people of a different race";
            else if (89 <= randomNumber && randomNumber <= 91)
                birthplace = "On board a boat or ship";
            else if (randomNumber == 92 || randomNumber == 93)
                birthplace = "In a prison or in the headquarters of a secret organization";
            else if (randomNumber == 94 || randomNumber == 95)
                birthplace = "In a sage's laboratory";
            else if (randomNumber == 96)
                birthplace = "In the Feywild";
            else if (randomNumber == 97)
                birthplace = "In the Shadowfell";
            else if (randomNumber == 98)
                birthplace = "On the Astral Plane or the Ethereal Plane";
            else if (randomNumber == 99)
                birthplace = "";
            //On an Inner Plane of Your Choice
            else if (randomNumber == 100)
                birthplace = "";
            //On an Outer Plane of Your Choice, plus a strange event happened. See this page in the book
        }

        public void setSiblings(string race)
        {
            int randomNumber = NumberGen.gen(1, 11);
            int numberOfSiblings = 0;
            //TODO: If elf or dwarf, subtract 2 from roll. Can't use contains bc Half-Elves exist. :/ Maybe contains elf and no hyphen..?
            //If siblings list is null, "None"
            if (randomNumber == 3 || randomNumber == 4)
                numberOfSiblings = 0;
            //1d3 siblings
            else if (randomNumber == 5 || randomNumber == 6)
                numberOfSiblings = 0;
            //1d4 + 1
            else if (randomNumber == 7 || randomNumber == 8)
                numberOfSiblings = 0;
            //1d6 + 2
            else if (randomNumber == 9 || randomNumber == 10)
                numberOfSiblings = 0;
            //1d8 + 3

            while (siblings.Count < numberOfSiblings)
            {
                //Generate siblings here
            }
        }

        public void setFamily() //Who raised you?
        {
            int randomNumber = NumberGen.gen(1, 101); //TODO: Maybe develop this further -- info on family members that arent parents, etc
            if (randomNumber == 1)
                family = "None";
            else if (randomNumber == 2)
                family = "Institution, such as an asylum";
            else if (randomNumber == 3)
                family = "Temple";
            else if (randomNumber == 4 || randomNumber == 5)
                family = "Orphanage";
            else if (randomNumber == 6 || randomNumber == 7)
                family = "Guardian";
            else if (8 <= randomNumber && randomNumber <= 15)
                family = "Paternal or material aunt, uncle, or both; or extended family such as a tribe or clan";
            else if (16 <= randomNumber && randomNumber <= 25)
                family = "Paternal or material grandparent(s)";
            else if (26 <= randomNumber && randomNumber <= 35)
                family = "Adoptive family (same or different race)";
            else if (36 <= randomNumber && randomNumber <= 55)
                family = "Single father or stepfather";
            else if (56 <= randomNumber && randomNumber <= 75)
                family = "Single mother or stepmother";
            else if (76 <= randomNumber && randomNumber <= 100)
                family = "Mother and father";

            //TODO: Do absent parent
        }

        public void setFamilyLifestyle()
        {
            int number = DiceRoll.roll(3, 6);

            if (number == 3)
                familyLifestyle = "Wretched";
            else if (number == 4 || number == 5)
                familyLifestyle = "Squalid";
            else if (6 <= number && number <= 8)
                familyLifestyle = "Poor";
            else if (9 <= number && number <= 12)
                familyLifestyle = "Modest";
            else if (13 <= number && number <= 15)
                familyLifestyle = "Comfortable";
            else if (number == 16 || number == 17)
                familyLifestyle = "Wealthy";
            else if (number == 18)
                familyLifestyle = "Aristocratic";
        }

        public void setChildhoodHome()
        {
            int randomNumber = NumberGen.gen(1, 101);
            randomNumber += familyLifestyles[familyLifestyle];

            if (0 >= randomNumber)
                childhoodHome = "On the streets";
            else if (1 <= randomNumber && randomNumber <= 20)
                childhoodHome = "Rundown shack";
            else if (21 <= randomNumber && randomNumber <= 30)
                childhoodHome = "No permanent residence; you moved around a lot";
            else if (31 <= randomNumber && randomNumber <= 40)
                childhoodHome = "Encampment or village in the wilderness";
            else if (41 <= randomNumber && randomNumber <= 50)
                childhoodHome = "Apartment in a rundown neighborhood";
            else if (51 <= randomNumber && randomNumber <= 70)
                childhoodHome = "Small house";
            else if (71 <= randomNumber && randomNumber <= 90)
                childhoodHome = "Large house";
            else if (91 <= randomNumber && randomNumber <= 110)
                childhoodHome = "Mansion";
            else 
            {
                childhoodHome = "Palace or castle";
            }
        }

        public void setChildhoodMemories(int charismaModifier)
        {
            int randomNumber = DiceRoll.roll(3, 6) + charismaModifier;

            if (3 >= randomNumber)
                childhoodMemory = "I am still haunted by my childhood, when I was treated badly by my peers.";
            else if (randomNumber == 4 || randomNumber == 5)
                childhoodMemory = "I spent most of my childhood alone, with no close friends.";
            else if (6 <= randomNumber && randomNumber <= 8)
                childhoodMemory = "Others saw me as being different or strange, and so I had few companions.";
            else if (9 <= randomNumber && randomNumber <= 12)
                childhoodMemory = "I had a few close friends and lived an ordinary childhood.";
            else if (13 <= randomNumber && randomNumber <= 15)
                childhoodMemory = "I had several friends, and my childhood was generally a happy one.";
            else if (randomNumber == 16 || randomNumber == 17)
                childhoodMemory = "I always found it easy to make friends, and I loved being around people.";
            else 
            {
                childhoodMemory = "Everyone knew who I was, and I had friends everywhere I went.";
            }

        }

        public void setBackgroundDecision(string characterBackground)
        {
            //TODO: may be more appropriate in the actual BG classes
        }

        public void setClassDecision(string characterClass)
        {
            //TODO: may be more appropriate in the actual class classes
        }

        public void setAge()
        {
            int randomNumber = NumberGen.gen(1, 101);

            if (1 <= randomNumber && randomNumber <= 20) {
                age = "20 years or younger";
                numberOfLifeEvents = 1;
            }
            else if (21 <= randomNumber && randomNumber <= 59) 
            {
                age = "21-30 years";
                numberOfLifeEvents = DiceRoll.roll(1, 4);
            }
            else if(60 <= randomNumber && randomNumber <= 69) 
            {
                age = "31-40 years";
                numberOfLifeEvents = DiceRoll.roll(1, 6);
            }
            else if(70 <= randomNumber && randomNumber <= 89) 
            {
                age = "41-50 years";
                numberOfLifeEvents = DiceRoll.roll(1, 8);
            }
            else if(90 <= randomNumber && randomNumber <= 99) 
            {
                age = "51-60 years";
                numberOfLifeEvents = DiceRoll.roll(1, 10);
            }
            else if(randomNumber == 100) 
            {
                age = "61 years or older";
                numberOfLifeEvents = DiceRoll.roll(1, 12);
            }
        }

        public void setLifeEvents()
        {
        }
    }
}