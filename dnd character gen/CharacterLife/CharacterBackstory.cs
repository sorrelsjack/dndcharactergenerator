using System.Collections.Generic;
using System.Linq;
using dnd_character_gen.CharacterLife.Tables;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterLife
{
    public class CharacterBackstory
    {
        public Parent[] parents = new Parent[2] { new Parent(), new Parent() };
        public List<Sibling> siblings = new List<Sibling>();
        public List<Individual> otherFamilyMembers = new List<Individual>();
        public List<Individual> individuals = new List<Individual>();
        public List<string> lifeEvents = new List<string>();
        public List<string> equipment = new List<string>();

        public string birthplace = "";
        public string strangeBirthEvent = "";
        public string family = "";
        public string familyLifestyle = "";
        public string childhoodHome = "";
        public string childhoodMemory = "";
        public string age = "";
        public int numberOfLifeEvents = 0;

        public string classReason = "";
        public string backgroundReason = "";

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

        public void setAdoptiveFamily()
        {
            //Parents
            //Siblings
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
                string[] outerPlanes = new string[]
                {
                    "The Abyss", "Acheron", "Arcadia", "Concordant Opposition/Outlands", "Elysium", "Gehenna",
                    "Gladsheim/Ysgard", "Hades/The Gray Waste", "Happy Hunting Grounds/Beastlands", "Limbo",
                    "The Nine Hells/Baator", "Nirvana/Mechanus", "Olympus/Arborea/Arvandor", "Pandemonium",
                    "Seven Heavens/Mount Celestia", "Tarterus/Carceri", "Twin Paradises/Bytopia"
                };
                randomNumber = NumberGen.gen(outerPlanes.Length);
                birthplace = outerPlanes[randomNumber];
            }

            randomNumber = DiceRoll.roll(1, 100); //Did a strange event happen at your birth?

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

        public void setFamily()
        {
            int randomNumber = 0;

            while (family == "")
            {
                randomNumber = NumberGen.gen(1, 101);
                if (randomNumber == 1)
                    family = "None";
                else if (randomNumber == 2)
                    family = "Institution, such as an asylum";
                else if (randomNumber == 3)
                    family = "Temple";
                else if (randomNumber == 4 || randomNumber == 5)
                    family = "Orphanage";
                else if (randomNumber == 6 || randomNumber == 7)
                {
                    family = "Guardian";
                    otherFamilyMembers.Add(Individual.generateIndividual());
                }
                else if (8 <= randomNumber && randomNumber <= 15)
                    family = "Paternal or material aunt, uncle, or both; or extended family such as a tribe or clan";
                else if (16 <= randomNumber && randomNumber <= 25)
                {
                    randomNumber = NumberGen.gen(2);
                    family = "Paternal or maternal grandparent(s)";

                    while (otherFamilyMembers.Count < randomNumber)
                    {
                        otherFamilyMembers.Add(Individual.generateIndividual());
                    }
                }
                else if (26 <= randomNumber && randomNumber <= 35)
                {
                    family = "Adoptive family (same or different race)"; //TODO: generate entire family of ADOPTIVE siblings and ADOPTIVE parents.. different than blood relations
                    setAdoptiveFamily();
                }
                else if (36 <= randomNumber && randomNumber <= 55 && parents != null)
                    family = "Single father or stepfather";
                else if (56 <= randomNumber && randomNumber <= 75 && parents != null)
                    family = "Single mother or stepmother";
                else if (76 <= randomNumber && randomNumber <= 100 & parents != null)
                    family = "Mother and father";

                if (randomNumber < 36 && parents.Any())
                {
                    foreach (Parent parent in parents)
                    {
                        if (parent != null)
                            parent.setAbsence();
                    }
                }
                else if (36 <= randomNumber && randomNumber <= 75 && !parents.All(x => x == null))
                {
                    randomNumber = NumberGen.gen(2);
                    parents[randomNumber].setAbsence();
                }
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

        public void setBackgroundDecision(ICharacterBackground background)
        {
            backgroundReason = background.setReason();
        }

        public void setClassDecision(ICharacterClass adventureClass)
        {
            classReason = adventureClass.setReason();
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
                numberOfLifeEvents = DiceRoll.roll(1, 4);
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

            while (lifeEvents.Count < numberOfLifeEvents)
            {
                randomNumber = DiceRoll.roll(1, 100);

                if (1 <= randomNumber && randomNumber <= 10)
                {
                    Tragedies tragedies = new Tragedies(parents, siblings);
                    lifeEvents.Add($"You suffered a tragedy. {tragedies.Roll()}");
                }
                else if (11 <= randomNumber && randomNumber <= 20)
                {
                    Boons boons = new Boons();
                    lifeEvents.Add($"You gained a bit of good fortune. {boons.Roll()}");
                    equipment.Add(boons.GetItem());
                }
                else if (21 <= randomNumber && randomNumber <= 30)
                {
                    Individual individual = Individual.generateIndividual();
                    if (lifeEvents.Contains("You fell in love or got married"))
                        lifeEvents.Add($"You had a child.\n{individual.getString()}");
                    else
                    {
                        lifeEvents.Add($"You fell in love or got married.\n{individual.getString()}");
                    }
                }
                else if (31 <= randomNumber && randomNumber <= 40)
                {
                    Individual adventurer = Individual.generateIndividual();
                    adventurer.relationship = "Hostile";
                    adventurer.setLivingStatus();

                    lifeEvents.Add($"You made an enemy of an adventurer. You are {(DiceRoll.roll(1, 6) % 2 == 0 ? "to blame" : "blameless")} for the rift between you two. " +
                        $"Work with your DM to determine this hostile character’s identity and the danger this enemy poses to you.\n{adventurer.getString()}");
                }
                else if (41 <= randomNumber && randomNumber <= 50)
                {
                    Individual adventurer = Individual.generateIndividual();
                    adventurer.relationship = "Friendly";
                    adventurer.setLivingStatus();

                    lifeEvents.Add($"You made a friend of an adventurer. Work with your DM to add more detail to this friendly character and establish how your friendship began.\n{adventurer.getString()}");
                }
                else if (51 <= randomNumber && randomNumber <= 70)
                {
                    lifeEvents.Add("You spent time working in a job related to your background. Start the game with an extra 2d6 gp.");
                }
                else if (71 <= randomNumber && randomNumber <= 75)
                {
                    Individual individual = Individual.generateIndividual();
                    lifeEvents.Add($"You met someone important. Work out additional details with your DM as needed to fit this character into your backstory.\n{individual.getString()}");
                }
                else if (76 <= randomNumber && randomNumber <= 80)
                {
                    Adventures adventures = new Adventures();
                    lifeEvents.Add($"You went on an adventure. {adventures.Roll()} Work with your DM to determine the nature of the adventure and the creatures you encountered.");
                    equipment.Add(adventures.GetItem());
                }
                else if (81 <= randomNumber && randomNumber <= 85)
                {
                    SupernaturalEvents supernaturalEvents = new SupernaturalEvents();
                    lifeEvents.Add($"You had a supernatural experience. {supernaturalEvents.Roll()}");
                }
                else if (86 <= randomNumber && randomNumber <= 90)
                {
                    Wars wars = new Wars();
                    lifeEvents.Add($"You fought in a battle. {wars.Roll()} Work with your DM to come up with the reason for the battle and the factions involved. It might have been a small conflict between your community and a band of orcs, or it could have been a major battle in a larger war.");
                }
                else if (91 <= randomNumber && randomNumber <= 95)
                {
                    Crimes crimes = new Crimes();
                    Punishments punishments = new Punishments();

                    lifeEvents.Add($"You committed a crime or were wrong accused of doing so, the nature of which was was {crimes.Roll()}. {punishments.Roll()}");
                }
                else if (96 <= randomNumber && randomNumber <= 99)
                {
                    lifeEvents.Add($"You encountered something magical. {new ArcaneMatters().Roll()}");
                }
                else if (randomNumber == 100)
                {
                    WeirdStuff weirdStuff = new WeirdStuff();
                    lifeEvents.Add($"Something truly strange happened to you. {weirdStuff.Roll()}");
                }
            }
        }

        public List<string> setEquipment()
            => equipment;

        private void setTragedy()
        {
        }

        private void setBoon()
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

        private void setWeirdStuff()
        {
        }
    }
}