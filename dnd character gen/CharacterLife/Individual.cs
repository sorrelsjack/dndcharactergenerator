using dnd_character_gen.Extensions;

namespace dnd_character_gen.CharacterLife
{
    public class Individual
    {
        public string status;
        public string causeOfDeath = "";
        public string relationship;
        public string adventureClass = "";
        public string alignment;
        public string race;
        public string occupation;

        public void setStatus()
        {
            int randomNumber = DiceRoll.roll(3, 6);

            if (randomNumber == 3)
            {
                status = "Dead";
                setCauseOfDeath();
            }
            else if (randomNumber == 4 || randomNumber == 5)
                status = "Missing or unknown";
            else if (6 <= randomNumber && randomNumber <= 8)
                status = "Alive, but doing poorly due to injury, financial trouble, or relationship difficulties";
            else if (9 <= randomNumber && randomNumber <= 12)
                status = "Alive and well";
            else if (13 <= randomNumber && randomNumber <= 15)
                status = "Alive and quite successful";
            else if (randomNumber == 16 || randomNumber == 17)
                status = "Alive and infamous";
            else if (randomNumber == 18)
                status = "Alive and famous";
        }

        public void setCauseOfDeath()
        {
            int randomNumber = NumberGen.gen(1, 12);

            switch (randomNumber)
            {
                case 1: causeOfDeath = "Unknown"; break;
                case 2: causeOfDeath = "Murdered"; break;
                case 3: causeOfDeath = "Killed in battle"; break;
                case 4: causeOfDeath = "Accident related to class or occupation"; break;
                case 5: causeOfDeath = "Accident unrelated to class or occupation"; break;
                case 6:
                case 7: causeOfDeath = "Natural causes, such as disease or old age"; break;
                case 8: causeOfDeath = "Apparent suicide"; break;
                case 9: causeOfDeath = "Torn apart by an animal or natural disaster"; break;
                case 10: causeOfDeath = "Consumed by a monster"; break;
                case 11: causeOfDeath = "Executed for a crime or tortured to death"; break;
                case 12: causeOfDeath = "Bizarre event, such as being hit by a meteorite, struck down by an angry god, or killed by a hatching slaad egg."; break;
            }
        }

        public void setRelationship()
        {
            int randomNumber = DiceRoll.roll(3, 4);

            if (randomNumber == 3 || randomNumber == 4)
                relationship = "Hostile";
            else if (5 <= randomNumber && randomNumber <= 10)
                relationship = "Friendly";
            else if (randomNumber == 11 || randomNumber == 12)
                relationship = "Indifferent";
        }

        public void setAlignment()
        {
            int randomNumber = DiceRoll.roll(3, 6);

            if (randomNumber == 3)
            {
                randomNumber = NumberGen.gen(2);
                alignment = randomNumber == 0 ? "Chaotic Evil" : "Chaotic Neutral";
            }
            else if (randomNumber == 4 || randomNumber == 5)
                alignment = "Lawful Evil";
            else if (6 <= randomNumber && randomNumber <= 8)
                alignment = "Neutral Evil";
            else if (9 <= randomNumber && randomNumber <= 12)
                alignment = "True Neutral";
            else if (13 <= randomNumber && randomNumber <= 15)
                alignment = "Neutral Good";
            else if (randomNumber == 16 || randomNumber == 17)
            {
                randomNumber = NumberGen.gen(2);
                alignment = randomNumber == 0 ? "Lawful Good" : "Lawful Neutral";
            }
            else if (randomNumber == 18)
            {
                randomNumber = NumberGen.gen(2);
                alignment = randomNumber == 0 ? "Chaotic Good" : "Chaotic Neutral";
            }
        }

        public void setOccupation()
        {
            int randomNumber = DiceRoll.roll(1, 100);

            if (1 <= randomNumber && randomNumber <= 5)
                occupation = "Academic";
            else if (6 <= randomNumber && randomNumber <= 10)
            {
                occupation = "Adventurer";
                setClass();
            }
            else if (randomNumber == 11)
                occupation = "Aristocrat";
            else if (12 <= randomNumber && randomNumber <= 26)
                occupation = "Artisan or guild member";
            else if (27 <= randomNumber && randomNumber <= 31)
                occupation = "Criminal";
            else if (32 <= randomNumber && randomNumber <= 36)
                occupation = "Entertainer";
            else if (randomNumber == 37 || randomNumber == 38)
                occupation = "Exile, hermit, or refuge";
            else if (39 <= randomNumber && randomNumber <= 43)
                occupation = "Explorer or wanderer";
            else if (44 <= randomNumber && randomNumber <= 55)
                occupation = "Farmer or herder";
            else if (56 <= randomNumber && randomNumber <= 60)
                occupation = "Hunter or trapper";
            else if (61 <= randomNumber && randomNumber <= 75)
                occupation = "Laborer";
            else if (76 <= randomNumber && randomNumber <= 80)
                occupation = "Merchant";
            else if (81 <= randomNumber && randomNumber <= 85)
                occupation = "Politician or bureaucrat";
            else if (86 <= randomNumber && randomNumber <= 90)
                occupation = "Priest";
            else if (91 <= randomNumber && randomNumber <= 95)
                occupation = "Sailor";
            else if (96 <= randomNumber && randomNumber <= 100)
                occupation = "Soldier";
        }

        public void setClass()
        {
            int randomNumber = DiceRoll.roll(1, 100);

            if (1 <= randomNumber && randomNumber <= 7)
                adventureClass = "Barbarian";
            else if (8 <= randomNumber && randomNumber <= 14)
                adventureClass = "Bard";
            else if (15 <= randomNumber && randomNumber <= 29)
                adventureClass = "Cleric";
            else if (30 <= randomNumber && randomNumber <= 36)
                adventureClass = "Druid";
            else if (37 <= randomNumber && randomNumber <= 52)
                adventureClass = "Fighter";
            else if (53 <= randomNumber && randomNumber <= 58)
                adventureClass = "Monk";
            else if (59 <= randomNumber && randomNumber <= 64)
                adventureClass = "Paladin";
            else if (65 <= randomNumber && randomNumber <= 70)
                adventureClass = "Ranger";
            else if (71 <= randomNumber && randomNumber <= 84)
                adventureClass = "Rogue";
            else if (85 <= randomNumber && randomNumber <= 89)
                adventureClass = "Sorcerer";
            else if (90 <= randomNumber && randomNumber <= 94)
                adventureClass = "Warlock";
            else if (95 <= randomNumber && randomNumber <= 100)
                adventureClass = "Wizard";
        }

        public virtual void setRace()
        {
            int randomNumber = DiceRoll.roll(1, 100);

            if (1 <= randomNumber && randomNumber <= 40)
                race = "Human";
            else if (41 <= randomNumber && randomNumber <= 50)
                race = "Dwarf";
            else if (51 <= randomNumber && randomNumber <= 60)
                race = "Elf";
            else if (61 <= randomNumber && randomNumber <= 70)
                race = "Halfling";
            else if (71 <= randomNumber && randomNumber <= 75)
                race = "Dragonborn";
            else if (76 <= randomNumber && randomNumber <= 80)
                race = "Gnome";
            else if (81 <= randomNumber && randomNumber <= 85)
                race = "Half-Elf";
            else if (86 <= randomNumber && randomNumber <= 90)
                race = "Half-Orc";
            else if (91 <= randomNumber && randomNumber <= 95)
                race = "Tiefling";
            else if (96 <= randomNumber && randomNumber <= 100)
                race = "DM's choice";
        }
    }
}