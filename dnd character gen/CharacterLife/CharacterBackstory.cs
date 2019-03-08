using System.Collections.Generic;
using System.Linq;
using dnd_character_gen.Extensions;

namespace dnd_character_gen.CharacterLife
{
    public class CharacterBackstory
    {
        public Parent[] parents = new Parent[2] { new Parent(), new Parent() };
        public List<Sibling> siblings = new List<Sibling>();
        public List<Individual> individual = new List<Individual>();
        public string birthplace = "";
        public string strangeBirthEvent = "";
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
                        parents[0].setRace("Elf");
                        parents[1].setRace("Human");
                    }
                    else if (randomNumber == 6)
                    {
                        parents[0].setRace("Elf");
                        parents[1].setRace("Half-Elf");
                    }
                    else if (randomNumber == 7)
                    {
                        parents[0].setRace("Human");
                        parents[1].setRace("Half-Elf");
                    }
                    else if (randomNumber == 8)
                    {
                        parents[0].setRace("Half-Elf");
                        parents[1].setRace("Half-Elf");
                    }
                }
                else if (race.Contains("Half-Orc"))
                {
                    randomNumber = NumberGen.gen(1, 9);
                    if (randomNumber < 4)
                    {
                        parents[0].setRace("Orc");
                        parents[1].setRace("Human");
                    }
                    else if (randomNumber == 4 || randomNumber == 5)
                    {
                        parents[0].setRace("Orc");
                        parents[1].setRace("Half-Orc");
                    }
                    else if (randomNumber == 6 || randomNumber == 7)
                    {
                        parents[0].setRace("Half-Orc");
                        parents[1].setRace("Human");
                    }
                    else if (randomNumber == 8)
                    {
                        parents[0].setRace("Half-Orc");
                        parents[1].setRace("Half-Orc");
                    }
                }
                else if (race == "Tiefling")
                {
                    randomNumber = NumberGen.gen(1, 9);
                    if (randomNumber < 5)
                    {
                        parents[0].setRace("Human");
                        parents[1].setRace("Human");
                    }
                    else if (randomNumber == 5 || randomNumber == 6)
                    {
                        parents[0].setRace("Tiefling");
                        parents[1].setRace("Human");
                    }
                    else if (randomNumber == 7)
                    {
                        parents[0].setRace("Tiefling");
                        parents[1].setRace("Devil");
                    }
                    else if (randomNumber == 8)
                    {
                        parents[0].setRace("Devil");
                        parents[1].setRace("Human");
                    }

                    parents[0].setAlignment();
                    parents[1].setAlignment();
                }
                else
                {
                    parents[0].race = race;
                    parents[1].race = race;
                }

                foreach (Parent parent in parents)
                {
                    parent.setOccupation();
                    parent.setAlignment();
                    parent.setRelationship();
                }
            }
            else
            {
                parents[0] = parents[1] = null;
                //You don't know who your parents are or were.
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
            {
                string[] innerPlanes = new string[] { "Air Plane", "Earth Plane", "Fire Plane", "Water Plane" };
                randomNumber = NumberGen.gen(innerPlanes.Length);                
                birthplace = innerPlanes[randomNumber];
            }
            else if (randomNumber == 100) 
            {
                string[] outerPlanes = new string[] { };
                randomNumber = NumberGen.gen(outerPlanes.Length);
                birthplace = outerPlanes[randomNumber];
            }

            randomNumber = DiceRoll.roll(1, 101); //Does a strange event happen at your birth?
                
            if (randomNumber == 100)
                setStrangeBirthEvent();

        }

        private void setStrangeBirthEvent() 
        {
            //When you were born,
            string[] strangeBirthEvents = new string[] 
            { "the moon briefly turned red",
              "all the milk within a mile spoiled",
              "the water in the area froze solid in midsummer",
              "all the iron at your birthplace rusted or turned to silver" };
        }

        public void setSiblings(string race)
        {
            int randomNumber = NumberGen.gen(1, 11);
            int numberOfSiblings = 0;

            if (randomNumber == 3 || randomNumber == 4)
                numberOfSiblings = DiceRoll.roll(1, 3);
            else if (randomNumber == 5 || randomNumber == 6)
                numberOfSiblings = DiceRoll.roll(1, 4) + 1;
            else if (randomNumber == 7 || randomNumber == 8)
                numberOfSiblings = DiceRoll.roll(1, 6) + 2;
            else if (randomNumber == 9 || randomNumber == 10)
                numberOfSiblings = DiceRoll.roll(1, 8) + 3;

            if (race.Contains("Dwarf") || race.Contains("Elf") && !race.Contains("Half-Elf"))
                numberOfSiblings -= 2;

            while (siblings.Count < numberOfSiblings)
            {
                Sibling sibling = new Sibling();

                sibling.setBirthOrder();
                sibling.setStatus();
                sibling.setRelationship();
                sibling.setAlignment();
                sibling.setOccupation();
                sibling.setRace(race);

                siblings.Add(sibling);
            }
        }

        public void setFamily() //TODO: Who raised you?
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
                family = "Paternal or maternal grandparent(s)";
            else if (26 <= randomNumber && randomNumber <= 35)
                family = "Adoptive family (same or different race)";
            else if (36 <= randomNumber && randomNumber <= 55)
                family = "Single father or stepfather";
            else if (56 <= randomNumber && randomNumber <= 75)
                family = "Single mother or stepmother";
            else if (76 <= randomNumber && randomNumber <= 100)
                family = "Mother and father";

            if (randomNumber < 36)
            {
                foreach(Parent parent in parents) 
                {
                    parent.setAbsence();
                }
            }
            else if (36 <= randomNumber && randomNumber <= 75)
            {
                randomNumber = NumberGen.gen(2);
                parents[randomNumber].setAbsence();
            }
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

            if (1 <= randomNumber && randomNumber <= 20)
            {
                age = "20 years or younger";
                numberOfLifeEvents = 1;
            }
            else if (21 <= randomNumber && randomNumber <= 59)
            {
                age = "21-30 years";
                numberOfLifeEvents = DiceRoll.roll(1, 4); //TODO: is this end Number inclusive?
            }
            else if (60 <= randomNumber && randomNumber <= 69)
            {
                age = "31-40 years";
                numberOfLifeEvents = DiceRoll.roll(1, 6);
            }
            else if (70 <= randomNumber && randomNumber <= 89)
            {
                age = "41-50 years";
                numberOfLifeEvents = DiceRoll.roll(1, 8);
            }
            else if (90 <= randomNumber && randomNumber <= 99)
            {
                age = "51-60 years";
                numberOfLifeEvents = DiceRoll.roll(1, 10);
            }
            else if (randomNumber == 100)
            {
                age = "61 years or older";
                numberOfLifeEvents = DiceRoll.roll(1, 12);
            }
        }

        public void setLifeEvents()
        {
            int randomNumber = 0;

            while(lifeEvents.Count < numberOfLifeEvents) 
            {
                randomNumber = DiceRoll.roll(1, 101);

                if (1 <= randomNumber && randomNumber <= 10) {
                    //You suffered a tragedy. Roll on the Tragedies table.
                }
                else if (11 <= randomNumber && randomNumber <= 20) {
                    //You gained a bit of good fortune. Roll on the Boons table.
                }
                else if (21 <= randomNumber && randomNumber <= 30) {
                    //You fell in love or got married. If you get this result more than once, you can choose to have a child instead. Work with your DM to determine the identity of your love interest.
                }
                else if (31 <= randomNumber && randomNumber <= 40) {
                    //You made an enemy of an adventurer. Roll a d6. An odd number indicates you are to
                    //blame for the rift, and an even number indicates you are blameless.Use the
                    //supplemental tables and work with your DM to determine this hostile character’s identity
                    //and the danger this enemy poses to you.
                }
                else if (41 <= randomNumber && randomNumber <= 50) {
                    //You made a friend of an adventurer. Use the supplemental tables and work with your DM to add more detail to this friendly character and establish how your friendship began.
                }
                else if (51 <= randomNumber && randomNumber <= 70) {
                    //You spent time working in a job related to your background. Start the game with an extra 2d6 gp.
                }
                else if (71 <= randomNumber && randomNumber <= 75) {
                    //You met someone important. Use the supplemental tables to determine this character’s
                    //identity and how this individual feels about you. Work out additional details with your
                    //DM as needed to fit this character into your backstory.
                }
                else if (76 <= randomNumber && randomNumber <= 80) {
                    //You met someone important. Use the supplemental tables to determine this character’s
                    //identity and how this individual feels about you. Work out additional details with your
                    //DM as needed to fit this character into your backstory.
                }
                else if (81 <= randomNumber && randomNumber <= 85) {
                    //You had a supernatural experience. Roll on the Supernatural Events table to find out what it was.
                }
                else if (86 <= randomNumber && randomNumber <= 90) {
                    //You fought in a battle. Roll on the War table to learn what happened to you. Work with
                    //your DM to come up with the reason for the battle and the factions involved.It might
                    //have been a small conflict between your community and a band of orcs, or it could have d100 Event been a major battle in a larger war
                }
                else if (91 <= randomNumber && randomNumber <= 95) {
                    //You committed a crime or were wrongly accused of doing so. Roll on the Crime table to
                    //determine the nature of the offense and on the Punishment table to see what became of you.
                }
                else if (96 <= randomNumber && randomNumber <= 99) {
                    //You encountered something magical. Roll on the Arcane Matters table.
                }
                else if (randomNumber == 100) {
                    //Something truly strange happened to you. Roll on the Weird Stuff table.
                }
            }
        }

        private void setTragedy()
        {
        }

        private void setBoon()
        {
        }

        private void generateIndividual()
        {
        }

        private void setAdventure()
        {
        }

        private void setSupernaturalEvent()
        {
        }

        private void setWar()
        {
        }

        private void setCrime()
        {
        }

        private void setPunishment()
        {
        }

        private void setArcaneMatters()
        {
        }

        private void setweirdStuff()
        {
        }
    }
}