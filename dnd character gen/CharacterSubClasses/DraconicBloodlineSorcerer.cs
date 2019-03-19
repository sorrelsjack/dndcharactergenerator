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
                { "Dragon Ancestor", $"At 1st level, you choose one type of dragon as your ancestor. The damage type associated with each dragon is used by features you gain later. You can speak, read, and write Draconic. Additionally, whenever you make a Charisma check when interacting with dragons, your proficiency bonus is doubled if it applies to the check." +
                $"\nIn your case, you had a {selectedDragon[0]} dragon ancestor, giving you the damage type {selectedDragon[1]}" },
                { "Draconic Resilience", "As magic flows through your body, it causes physical traits of your dragon ancestors to emerge. At 1st level, your hit point maximum increases by 1 and increases by 1 again whenever you gain a level in this class." +
                "\nAdditionally, parts of your skin are covered by a thin sheen of dragon-like scales. When you aren’t wearing armor, your AC equals 13 + your Dexterity modifier." }
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