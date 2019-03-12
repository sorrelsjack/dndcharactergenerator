using System.Collections.Generic;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterClasses
{
    public class Ranger : ICharacterClass
    {
        public List<string> setArmorProf() => new List<string> { "Light armor", "Medium armor", "Shields" };

        public List<string> setEquipment()
        {
            List<string> equipment = new List<string>();
            int randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 0
                ? "Scale mail" : "Leather armor");

            randomNumber = NumberGen.gen(2);
            if (randomNumber == 0)
            {
                equipment.Add("Two shortswords");
            }
            else
            {
                equipment.Add(SimpleWeapons.Instance.weapons[NumberGen.gen(SimpleWeapons.Instance.weapons.Count)]);
                equipment.Add(SimpleWeapons.Instance.weapons[NumberGen.gen(SimpleWeapons.Instance.weapons.Count)]);
            }

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 0
                ? "Wooden Shield" : SimpleWeapons.Instance.weapons[NumberGen.gen(SimpleWeapons.Instance.weapons.Count)]);

            randomNumber = NumberGen.gen(2);
            equipment.Add(randomNumber == 0
                ? "Dungeoneer's pack" : "Explorer's pack");

            equipment.Add("Longbow");
            equipment.Add("Quiver of 20 arrows");

            return equipment;
        }

        public Dictionary<string, string> setFeatures()
        {
            List<string> availableFavoredEnemies = new List<string>
            {
                "Aberrations", "Beasts", "Celestials", "Constructs", "Dragons", "Elementals", "Fey", "Fiends", "Giants",
                "Monstrosities", "Oozes", "Plants", "Undead"
            };

            List<string> availableFavoredHumanoidEnemies = new List<string>()
            {
                "Gnolls", "Orcs"
            }; //TODO fill this out with all of them.

            List<string> availableFavoredTerrain = new List<string>
            {
                "Arctic", "Coast", "Desert", "Forest", "Grassland", "Mountain", "Swamp", "The Underdark"
            };

            string favoredEnemies = NumberGen.gen(2) == 0
                ? availableFavoredEnemies[NumberGen.gen(13)]
                : "Gnolls and Orcs";

            string favoredTerrain = availableFavoredTerrain[NumberGen.gen(8)]; //TODO: replace features with actual ones

            Dictionary<string, string> features = new Dictionary<string, string>
            {
                { "Favored Enemy", $"-Significant experience studying, tracking, hunting, and talking to {favoredEnemies}." +
                                   "\n-Advantage on Wisdom (Survival) checks to track favored enemies, as well as Intelligence checks on information about them." +
                                   "\n-Gain your favored enemy's language." },

                { "Natural Explorer", $"-Familiar with one type of natural environment. ({favoredTerrain})" +
                                      "\n-Difficult terrain doesn't slow group's travel, group can't become lost except through magical means, remain alert to danger even when doing other activities," +
                                      " move stealthily at a normal pace when traveling alone, find twice as much food as usual when foraging, learn exact number of creatures tracked, as well as their sizes" +
                                      " and how long ago they passed through the area." }
            };

            return features;
        }

        public int setHitDie() => 10;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setLanguages() => null; //TODO use language of favored enemy

        public string setPrimaryStat() => "Dexterity";

        public List<string> setSaves() => new List<string> { "Strength", "Dexterity" };

        public List<string> setSkills()
        {
            List<string> skillProficiencies = new List<string>();
            List<string> availableSkills = new List<string>()
            { "Animal Handling", "Athletics", "Insight", "Investigation", "Nature", "Perception", "Stealth", "Survival" };

            string skill = availableSkills[NumberGen.gen(8)];
            skillProficiencies.Add(skill);
            availableSkills.Remove(skill);

            skill = availableSkills[NumberGen.gen(7)];
            skillProficiencies.Add(skill);
            availableSkills.Remove(skill);

            skill = availableSkills[NumberGen.gen(7)];
            skillProficiencies.Add(skill);

            return skillProficiencies;
        }

        public int setSpellAttackMod(int proficiency, Dictionary<string, int> modifiers) => proficiency + modifiers["Wisdom"];

        public int setSpellSaveDC(int proficiency, Dictionary<string, int> modifiers) => 8 + proficiency + modifiers["Wisdom"];

        public string setSubType() => null;

        public List<string> setToolsProf() => null;

        public List<string> setWeaponProf() => new List<string> { "Simple weapons", "Martial weapons" };
    }
}