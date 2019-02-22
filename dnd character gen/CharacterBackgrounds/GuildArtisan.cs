using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterBackgrounds
{
    public class GuildArtisan : ICharacterBackground {
        private string artisansTools = ArtisansTools.Instance.tools[NumberGen.gen(ArtisansTools.Instance.tools.Count)];

        public string setBond() {
            throw new NotImplementedException();
        }

        public List<string> setEquipment() => new List<string> 
        {
            $"{artisansTools}", "Letter of introduction from guild", "Set of traveler's clothes", "Belt pouch containing 15 gp"
        };

        public Dictionary<string, string> setFeatures() {
            throw new NotImplementedException();
        }

        public string setFlaw() {
            throw new NotImplementedException();
        }

        public string setIdeal() {
            throw new NotImplementedException();
        }

        public List<string> setLanguages() => 
            new List<string> { Languages.Instance.languages[NumberGen.gen(Languages.Instance.languages.Count)]};

        public string setPersonalityTrait() {
            throw new NotImplementedException();
        }

        public List<string> setSkills() => new List<string> { "Insight", "Persuasion" };

        public Dictionary<string, string> setSpecial() {
            throw new NotImplementedException();
        }

        public List<string> setToolsProf() => new List<string> { $"{artisansTools}" };
    }
}
