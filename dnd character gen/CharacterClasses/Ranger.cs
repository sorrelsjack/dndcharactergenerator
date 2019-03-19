using System.Collections.Generic;
using System.Linq;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterClasses
{
    public class Ranger : ICharacterClass
    {
        private List<string> _favoredEnemies = new List<string>();

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
                "Humans", "Dwarves", "Elves", "Ogres", "Gnomes", "Goblinoids", "Halflings", "Gnolls", "Orcs", "Lizardfolk", "Kobolds"
            };

            List<string> availableFavoredTerrain = new List<string>
            {
                "Arctic", "Coast", "Desert", "Forest", "Grassland", "Mountain", "Swamp", "The Underdark"
            };

            int randomNumber = NumberGen.gen(2);
            if (randomNumber == 0)
            {
                randomNumber = NumberGen.gen(availableFavoredEnemies.Count);
                _favoredEnemies.Add(availableFavoredEnemies[randomNumber]);
            }
            else
            {
                while (_favoredEnemies.Count < 2)
                {
                    randomNumber = NumberGen.gen(availableFavoredHumanoidEnemies.Count); //TODO: Test to see if favored enemies work and are generated properly
                    string enemy = availableFavoredHumanoidEnemies[randomNumber];
                    if (!_favoredEnemies.Contains(enemy))
                        _favoredEnemies.Add(enemy);
                }
            }

            string favoredTerrain = availableFavoredTerrain[NumberGen.gen(8)];

            Dictionary<string, string> features = new Dictionary<string, string>
            {
                { "Favored Enemy", $"Beginning at 1st level, you have significant experience studying, tracking, hunting, and even talking to a certain type of enemy." +
                                   $"\nYour favored enemies are: {string.Join(" and ", _favoredEnemies)}" + //TODO: WHat if theres only one favored enemy
                                   "\nYou have advantage on Wisdom (Survival) checks to track your favored enemies, as well as on Intelligence checks to recall information about them." +
                                   "\nWhen you gain this feature, you also learn one language of your choice that is spoken by your favored enemies, if they speak one at all." },

                { "Natural Explorer", $"You are particularly familiar with one type of natural environment and are adept at traveling and surviving in such regions. Choose one type of favored terrain: arctic, coast, desert, forest, grassland, mountain, swamp, or the Underdark. When you make an Intelligence or Wisdom check related to your favored terrain, your proficiency bonus is doubled if you are using a skill that you’re proficient in." +
                                      "\nWhile traveling for an hour or more in your favored terrain, you gain the following benefits:" +
                                      "\n- Difficult terrain doesn’t slow your group’s travel." +
                                      "\n- Your group can’t become lost except by magical means." +
                                      "\n- Even when you are engaged in another activity while traveling(such as foraging, navigating, or tracking), you remain alert to danger." +
                                      "\n- If you are traveling alone, you can move stealthily at a normal pace." +
                                      "\n- When you forage, you find twice as much food as you normally would." +
                                      "\n- While tracking other creatures, you also learn their exact number, their sizes, and how long ago they passed through the area." }
            };

            return features;
        }

        public int setHitDie() => 10;

        public int setHitPoints(int hitDie, int constitution) => hitDie + constitution;

        public List<string> setLanguages() => Languages.Instance.languageMap.Keys.Where(x => _favoredEnemies.All(y => y == x)).ToList();

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