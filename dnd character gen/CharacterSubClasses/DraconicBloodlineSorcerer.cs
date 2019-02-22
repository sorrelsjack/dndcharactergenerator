using System;
using System.Collections.Generic;
using System.Linq;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterSubClasses
{
    public class DraconicBloodlineSorcerer : ICharacterSubClass
    {
        private Dictionary<string, string> _dragons = new Dictionary<string, string>
        {
            { "Black", "Acid" },
            { "Blue", "Lightning" },
            { "Brass", "Fire" },
            { "Bronze", "Lightning" },
            { "Copper", "Acid" },
            { "Gold", "Fire" },
            { "Green", "Poison" },
            { "Red", "Fire" },
            { "Silver", "Cold" },
            { "White", "Cold" }
        };

        public List<string> setArmorProf()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> setFeatures()
        {
            var selectedDragon = selectDragon();
            Dictionary<string, string> features = new Dictionary<string, string>
            {
                { "Dragon Ancestor", $"-Had a(n) {selectedDragon[0]} ancestor, giving the damage type {selectedDragon[1]}\n-Gain proficiency in the Draconic language\n-Charisma checks involving dragons get a doubled proficiency bonus" },
                { "Draconic Resilience", "-HP maximum increases by 1-When not wearing armor, AC is 13 + Dexterity modifier" }
            };

            return features;
        }

        private string[] selectDragon()
        {
            var dragon = _dragons.ElementAt(NumberGen.gen(_dragons.Count));
            return new string[] { dragon.Key, dragon.Value };
        }

        public List<string> setLanguageProf() => new List<string> { "Draconic" };

        public List<string> setSkillProf()
        {
            throw new NotImplementedException();
        }

        public List<string> setWeaponProf()
        {
            throw new NotImplementedException();
        }
    }
}