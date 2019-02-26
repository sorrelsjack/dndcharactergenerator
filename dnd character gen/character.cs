using System;
using System.Collections.Generic;
using System.Linq;
using dnd_character_gen.CharacterBackgrounds;
using dnd_character_gen.CharacterClasses;
using dnd_character_gen.CharacterRaces;
using dnd_character_gen.CharacterSubRaces;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen
{
    public class Character
    {
        public Character()
        {
        }

        #region Basic Info

        public string name;
        public string characterClassSubtype = "";
        public int level = 1;
        public string background;
        public string race;
        public string alignment;
        public int xp = 0;

        public string size = "";

        #endregion Basic Info

        #region Personality Info

        public string personalityTrait = "";
        public string ideal = "";
        public string bond = "";
        public string flaw = "";

        #endregion Personality Info

        #region Class, Subclass, Race, and Background interfaces

        public ICharacterClass characterClass { get; set; }
        public ICharacterSubClass characterSubClass { get; set; }
        public ICharacterRace characterRace { get; set; }
        public ICharacterBackground characterBackground { get; set; }

        #endregion Class, Subclass, Race, and Background interfaces

        #region AC, Init, Speed, HP, Spell Save DC

        public int armorClass { get; set; }
        public int initiative { get; set; }
        public int movementSpeed { get; set; }
        public int hitDie { get; set; }
        public int hitPoints { get; set; }
        public int spellSaveDC { get; set; }

        #endregion AC, Init, Speed, HP, Spell Save DC

        #region Proficiencies

        public int proficiencyBonus = 2;
        public List<string> armorProficiencies = new List<string>();
        public List<string> weaponProficiencies = new List<string>();
        public List<string> toolProficiencies = new List<string>();
        public List<string> savingThrowProficiencies = new List<string>();
        public List<string> skillProficiencies = new List<string>();
        public List<string> languageProficiencies = new List<string>();

        #endregion Proficiencies

        public List<string> equipment = new List<string>();
        public Dictionary<string, string> features = new Dictionary<string, string>();

        #region Stats and Modifiers

        private string primaryStat { get; set; }

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
        public int spellAttackModifier { get; set; }

        #endregion Stats and Modifiers

        public Dictionary<string, string> classFeatures { get; set; }

        #region Basic Character Generator Method

        public void generateBasicInfo()
        {
            generateClass();
            initializeClass();
            this.background = generateBackground();
            initializeBackground();
            this.race = generateRace();
            initializeRace();
            this.alignment = generateAlignment();
        }

        #endregion Basic Character Generator Method

        public void initializeClass()
        {
            characterClassSubtype = characterClass.setSubType();

            primaryStat = characterClass.setPrimaryStat();
            hitDie = characterClass.setHitDie();

            var classArmorProficiencies = characterClass.setArmorProf();
            if (classArmorProficiencies != null)
                armorProficiencies.AddRange(classArmorProficiencies);

            var classWeaponProficiencies = characterClass.setWeaponProf();
            if (classWeaponProficiencies != null)
                weaponProficiencies.AddRange(classWeaponProficiencies);

            var classToolProficiencies = characterClass.setToolsProf();
            if (classToolProficiencies != null)
                toolProficiencies.AddRange(classToolProficiencies);

            var classSavingThrowProficiencies = characterClass.setSaves();
            if (classSavingThrowProficiencies != null)
                savingThrowProficiencies.AddRange(classSavingThrowProficiencies);

            equipment.AddRange(characterClass.setEquipment());
            classFeatures = characterClass.setFeatures();

            spellAttackModifier = characterClass.setSpellAttackMod(proficiencyBonus, new Dictionary<string, int>
            {
                { "Strength", strengthModifier },
                { "Dexterity", dexterityModifier },
                { "Constitution", constitutionModifier },
                { "Intelligence", intelligenceModifier },
                { "Wisdom", wisdomModifier },
                { "Charisma", charismaModifier }
            });
            spellSaveDC = characterClass.setSpellSaveDC(proficiencyBonus, new Dictionary<string, int>
            {
                { "Strength", strengthModifier },
                { "Dexterity", dexterityModifier },
                { "Constitution", constitutionModifier },
                { "Intelligence", intelligenceModifier },
                { "Wisdom", wisdomModifier },
                { "Charisma", charismaModifier }
            });
        }

        private void generateClass()
        {
            int randomNumber = NumberGen.gen(12);

            if (randomNumber == 0)
                characterClass = new Barbarian();
            else if (randomNumber == 1)
                characterClass = new Bard();
            else if (randomNumber == 2)
                characterClass = new Cleric();
            else if (randomNumber == 3)
                characterClass = new Druid();
            else if (randomNumber == 4)
                characterClass = new Fighter();
            else if (randomNumber == 5)
                characterClass = new Monk();
            else if (randomNumber == 6)
                characterClass = new Paladin();
            else if (randomNumber == 7)
                characterClass = new Ranger();
            else if (randomNumber == 8)
                characterClass = new Rogue();
            else if (randomNumber == 9)
                characterClass = new Sorcerer();
            else if (randomNumber == 10)
                characterClass = new Warlock();
            else if (randomNumber == 11)
                characterClass = new Wizard();
        }

        public void initializeBackground() //TODO: In the future, optimize so that if there's duplicates, reroll some stuff.
        {
            characterBackground.setSkills();
            characterBackground.setLanguages();
            characterBackground.setEquipment();
            characterBackground.setToolsProf();
            characterBackground.setFeatures();
            characterBackground.setSpecial();

            personalityTrait = characterBackground.setPersonalityTrait();
            ideal = characterBackground.setIdeal();
            bond = characterBackground.setBond();
            flaw = characterBackground.setFlaw();
        }

        private string generateBackground()
        {
            //TODO need a method to resolve conflicts between things selected in background and class and race
            string background = "";
            int randomNumber = NumberGen.gen(18);

            if (randomNumber == 0)
            {
                background = "Acolyte";
                characterBackground = new Acolyte();
            }
            else if (randomNumber == 1)
            {
                background = "Charlatan";
                characterBackground = new Charlatan();
            }
            else if (randomNumber == 2)
            {
                background = "Criminal";
                characterBackground = new Criminal();
            }
            else if (randomNumber == 3)
            {
                background = "Entertainer";
                characterBackground = new Entertainer();
            }
            else if (randomNumber == 4)
            {
                background = "Folk Hero";
                characterBackground = new FolkHero();
            }
            else if (randomNumber == 5)
            {
                background = "Entertainer (Gladiator)";
                characterBackground = new Gladiator();
            }
            else if (randomNumber == 6)
            {
                background = "Guild Artisan";
                characterBackground = new GuildArtisan();
            }
            else if (randomNumber == 7)
            {
                background = "Guild Artisan (Guild Merchant)";
                characterBackground = new GuildMerchant();
            }
            else if (randomNumber == 8)
            {
                background = "Hermit";
                characterBackground = new Hermit();
            }
            else if (randomNumber == 9)
            {
                background = "Knight";
                characterBackground = new Knight();
            }
            else if (randomNumber == 10)
            {
                background = "Noble";
                characterBackground = new Noble();
            }
            else if (randomNumber == 11)
            {
                background = "Outlander";
                characterBackground = new Outlander();
            }
            else if (randomNumber == 12)
            {
                background = "Pirate";
                characterBackground = new Pirate();
            }
            else if (randomNumber == 13)
            {
                background = "Sage";
                characterBackground = new Sage();
            }
            else if (randomNumber == 14)
            {
                background = "Sailor";
                characterBackground = new Sailor();
            }
            else if (randomNumber == 15)
            {
                background = "Soldier";
                characterBackground = new Soldier();
            }
            else if (randomNumber == 16)
            {
                background = "Spy";
                characterBackground = new Spy();
            }
            else if (randomNumber == 17)
            {
                background = "Urchin";
                characterBackground = new Urchin();
            }

            return background;
        }

        public void initializeRace()
        {
            name = characterRace.setName();
            characterRace.setAbilityScores();
            size = characterRace.setSize();
            movementSpeed = characterRace.setSpeed();
        }

        #region Race Generator

        private string generateRace() //TODO: Fix where I overwrote base class stuff when I wasn't supposed to...
        {
            string race = "";
            int randomNumber = NumberGen.gen(9);

            if (randomNumber == 0)
            {
                race = "Dragonborn";
                characterRace = new Dragonborn();
            }
            else if (randomNumber == 1)
            {
                randomNumber = NumberGen.gen(3);
                if (randomNumber == 0)
                {
                    race = "Hill Dwarf";
                    characterRace = new HillDwarf();
                }
                else if (randomNumber == 1)
                {
                    race = "Mark Of Warding Dwarf";
                    characterRace = new MarkOfWardingDwarf();
                }
                else if (randomNumber == 2)
                {
                    race = "Mountain Dwarf";
                    characterRace = new MountainDwarf();
                }
            }

            if (randomNumber == 2)
            {
                randomNumber = NumberGen.gen(3);
                if (randomNumber == 0)
                {
                    race = "High Elf";
                    characterRace = new HighElf();
                }
                else if (randomNumber == 1)
                {
                    race = "Wood Elf";
                    characterRace = new WoodElf();
                }
                else if (randomNumber == 2)
                {
                    race = "Dark Elf";
                    characterRace = new DarkElf();
                }
            }

            if (randomNumber == 3)
            {
                randomNumber = NumberGen.gen(3);
                if (randomNumber == 0)
                {
                    race = "Deep Gnome";
                    characterRace = new DeepGnome();
                }
                else if (randomNumber == 1)
                {
                    race = "Mark Of Scribing Gnome";
                    characterRace = new MarkOfScribingGnome();
                }
                else if (randomNumber == 2)
                {
                    race = "Rock Gnome";
                    characterRace = new RockGnome();
                }
            }

            if (randomNumber == 4)
            {
                randomNumber = NumberGen.gen(2);
                if (randomNumber == 0)
                {
                    race = "Mark of Detection Half-Elf";
                    characterRace = new MarkOfDetectionHalfElf();
                }
                else
                {
                    race = "Mark of Storm Half-Elf";
                    characterRace = new MarkOfStormHalfElf();
                }
            }

            if (randomNumber == 5)
            {
                randomNumber = NumberGen.gen(4);
                if (randomNumber == 0)
                {
                    race = "Lightfoot Halfling";
                    characterRace = new LightfootHalfling();
                }
                else if (randomNumber == 1)
                {
                    race = "Mark of Healing Halfling";
                    characterRace = new MarkOfHealingHalfling();
                }
                else if (randomNumber == 2)
                {
                    race = "Mark of Hospitality Halfling";
                    characterRace = new MarkOfHospitalityHalfling();
                }
                else if (randomNumber == 3)
                {
                    race = "Stout Halfling";
                    characterRace = new StoutHalfling();
                }
            }

            if (randomNumber == 6)
            {
                randomNumber = NumberGen.gen(2);
                if (randomNumber == 0)
                {
                    race = "Half-Orc";
                    characterRace = new HalfOrc();
                }
                else
                {
                    race = "Mark of Finding Half-Orc";
                    characterRace = new MarkOfFindingHalfOrc();
                }
            }

            if (randomNumber == 7)
            {
                randomNumber = NumberGen.gen(4);
                if (randomNumber == 0)
                {
                    race = "Mark of Handling Human";
                    characterRace = new MarkOfHandlingHuman();
                }
                else if (randomNumber == 1)
                {
                    race = "Mark of Making Human";
                    characterRace = new MarkOfMakingHuman();
                }
                else if (randomNumber == 2)
                {
                    race = "Mark of Passage Human";
                    characterRace = new MarkOfPassageHuman();
                }
                else if (randomNumber == 3)
                {
                    race = "Mark of Sentinel Human";
                    characterRace = new MarkOfSentinelHuman();
                }
            }

            if (randomNumber == 8)
            {
                race = "Tiefling";
                characterRace = new Tiefling();
            }

            return race;
        }

        #endregion Race Generator

        private string generateAlignment()
        {
            string alignment = "";
            int randomNumber = NumberGen.gen(9);

            if (randomNumber == 0)
                alignment = "Lawful Good";
            else if (randomNumber == 1)
                alignment = "Neutral Good";
            else if (randomNumber == 2)
                alignment = "Chaotic Good";
            else if (randomNumber == 3)
                alignment = "Lawful Neutral";
            else if (randomNumber == 4)
                alignment = "True Neutral";
            else if (randomNumber == 5)
                alignment = "Chaotic Neutral";
            else if (randomNumber == 6)
                alignment = "Lawful Evil";
            else if (randomNumber == 7)
                alignment = "Neutral Evil";
            else if (randomNumber == 8)
                alignment = "Chaotic Evil";

            return alignment;
        }

        private int generateStat()
        {
            int stat = 0;
            int[] generatedNumbers = new int[4];
            int lowestValue = 0;
            int lowestValueCount = 0;

            for (int i = 0; i < 3; i++)
            {
                Random rnd = new Random(Guid.NewGuid().GetHashCode()); //TODO convert this to my extension method
                int randomNumber = rnd.Next(1, 7);
                generatedNumbers[i] = randomNumber;
            }

            for (int i = 0; i < generatedNumbers.Length; i++)
            {
                if (lowestValue > generatedNumbers[i])
                {
                    lowestValue = generatedNumbers[i];
                }
            }

            for (int i = 0; i < generatedNumbers.Length; i++)
            {
                if (lowestValue == generatedNumbers[i] && lowestValueCount < 1)
                {
                    lowestValueCount++;
                }
                else
                {
                    stat = stat + generatedNumbers[i];
                }
            }
            return stat;
        }

        public void generateStatArray()
        {
            int randomNumber = 0;
            List<int> statArray = new List<int>();
            Dictionary<string, int> sortedStats = new Dictionary<string, int>
            {
                { "Strength", 0 },
                { "Dexterity", 0 },
                { "Constitution", 0 },
                { "Intelligence", 0 },
                { "Wisdom", 0 },
                { "Charisma", 0 }
            };

            for (int i = 0; i < 6; i++)
            {
                statArray.Add(generateStat());
            }

            //TODO: Add racial bonuses here

            statArray = statArray.OrderBy(x => x).ToList<int>(); //Ordering by lowest to highest value.

            sortedStats[primaryStat] = statArray[statArray.Count - 1];
            statArray.RemoveAt(statArray.Count - 1);

            while (statArray.Count > 0)
            {
                randomNumber = NumberGen.gen(statArray.Count);
                var nextKey = sortedStats.FirstOrDefault(x => x.Value == 0);
                sortedStats[nextKey.Key] = statArray[randomNumber];
                statArray.RemoveAt(randomNumber);
            }

            strength = sortedStats["Strength"];
            dexterity = sortedStats["Dexterity"];
            constitution = sortedStats["Constitution"];
            intelligence = sortedStats["Intelligence"];
            wisdom = sortedStats["Wisdom"];
            charisma = sortedStats["Charisma"];

            strengthModifier = calculateStatModifier(strength);
            dexterityModifier = calculateStatModifier(dexterity);
            constitutionModifier = calculateStatModifier(constitution);
            intelligenceModifier = calculateStatModifier(intelligence);
            wisdomModifier = calculateStatModifier(wisdom);
            charismaModifier = calculateStatModifier(charisma);

            hitPoints = characterClass.setHitPoints(hitDie, constitutionModifier); //TODO: Maybe find a more appropriate place for this? idk
        }

        private int calculateStatModifier(int stat)
        {
            int modifier = 0;

            if (stat == 1)
                modifier = -5;
            if (stat == 2 || stat == 3)
                modifier = -4;
            if (stat == 4 || stat == 5)
                modifier = -3;
            if (stat == 6 || stat == 7)
                modifier = -2;
            if (stat == 8 || stat == 9)
                modifier = -1;
            if (stat == 10 || stat == 11)
                modifier = 0;
            if (stat == 12 || stat == 13)
                modifier = 1;
            if (stat == 14 || stat == 15)
                modifier = 2;
            if (stat == 16 || stat == 17)
                modifier = 3;
            if (stat == 18 || stat == 19)
                modifier = 4;
            if (stat == 20 || stat == 21)
                modifier = 5;

            return modifier;
        }
    }
}