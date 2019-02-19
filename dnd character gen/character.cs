using dnd_character_gen.CharacterClasses;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;
using System;
using System.Collections.Generic;
using dnd_character_gen.CharacterSubClasses;

namespace dnd_character_gen {
    public class Character {

        public Character()
        {
            generateBasicInfo();
        }

        #region Basic Info
        public string name;
        public string characterClassSubtype; //Instead of this, make the field ClassName + (Subtype)
        public int level = 1;
        public string background;
        public string race;
        public string alignment;
        public int xp = 0;
        #endregion

        #region Class, Subclass, Race, and Background interfaces
        public ICharacterClass characterClass { get; set; }
        public ICharacterSubClass characterSubClass { get; set; }
        public ICharacterRace characterRace { get; set; }
        public ICharacterBackground characterBackground { get; set; }
        #endregion

        #region AC, Init, Speed, HP, Spell Save DC
        int armorClass { get; set; }
        int initiative { get; set; }
        int movementSpeed { get; set; }
        int hitDie { get; set; }
        int hitPoints { get; set; }
        int spellSaveDC { get; set; }
        #endregion

        #region Proficiencies
        public int proficiencyBonus = 2;
        public List<string> armorProficiencies = new List<string>();
        public List<string> weaponProficiencies = new List<string>();
        public List<string> toolProficiencies = new List<string>();
        public List<string> savingThrowProficiencies = new List<string>();
        public List<string> skillProficiencies = new List<string>();
        public List<string> languageProficiencies = new List<string>();
        #endregion

        public List<string> equipment = new List<string>();
        public Dictionary<string, string> features = new Dictionary<string, string>();

        #region Stats and Modifiers
        string primaryStat { get; set; }

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
        #endregion

        public Dictionary<string, string> classFeatures { get; set; }

        #region Basic Character Generator Method
        public void generateBasicInfo() {
            generateClass();
            initializeClass();
            this.background = generateBackground();
            this.race = generateRace();
            this.alignment = generateAlignment();
        }
        #endregion

        public void initializeClass() {
            characterClassSubtype = characterClass.setSubType(); //TODO deal with an issue where class, race, and background could have same skills.
            initializeSubClass();

            primaryStat = characterClass.setPrimaryStat();
            hitDie = characterClass.setHitDie();
            hitPoints = characterClass.setHitPoints(hitDie, constitutionModifier); //TODO make this generate in the correct order.

            armorProficiencies.AddRange(characterClass.setArmorProf()); //Prevent dupes. Also, take into account subclass. Same for below.
            weaponProficiencies.AddRange(characterClass.setWeaponProf());
            toolProficiencies.AddRange(characterClass.setToolsProf());
            savingThrowProficiencies.AddRange(characterClass.setSaves());

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

        public void initializeSubClass() {
            if (characterClassSubtype == "Knowledge")
                characterSubClass = new KnowledgeCleric();
            if(characterClassSubtype == "Life")
                characterSubClass = new LifeCleric();
            if(characterClassSubtype == "Light")
                characterSubClass = new LightCleric();
            if(characterClassSubtype == "Nature")
                characterSubClass = new NatureCleric();
            if(characterClassSubtype == "Tempest")
                characterSubClass = new TempestCleric();
            if(characterClassSubtype == "Trickery")
                characterSubClass = new TrickeryCleric();
            if(characterClassSubtype == "War")
                characterSubClass = new WarCleric();

            foreach(var feature in characterSubClass.setFeatures())
                classFeatures.Add(feature.Key, feature.Value);
            armorProficiencies.AddRange(characterSubClass.setArmorProf());
            weaponProficiencies.AddRange(characterSubClass.setWeaponProf());
        }

        #region
        private void generateClass() {
            int randomNumber = NumberGen.gen(12);
            if (randomNumber == 1) {
                characterClass = new Barbarian();
            }
            else if (randomNumber == 2) {
                characterClass = new Bard();
            }
            else if (randomNumber == 3) {
                characterClass = new Cleric();
            }
            else if (randomNumber == 4) {

                characterClass = new Druid();
            }
            else if (randomNumber == 5) {
                characterClass = new Fighter();
            }
            else if (randomNumber == 6) {
                characterClass = new Monk();
            }
            else if (randomNumber == 7) {
                characterClass = new Paladin();
            }
            else if (randomNumber == 8) {
                characterClass = new Ranger();
            }
            else if (randomNumber == 9) {
                characterClass = new Rogue();
            }
            else if (randomNumber == 10) {
                characterClass = new Sorcerer();
            }
            else if (randomNumber == 11) {
                characterClass = new Warlock();
            }
            else if(randomNumber == 12) {
                characterClass = new Wizard();
            }
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
        #endregion
    }
}
