using System.Collections.Generic;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterBackgrounds
{
    public class FolkHero : ICharacterBackground
    {
        private string artisansTools = ArtisansTools.Instance.tools[NumberGen.gen(ArtisansTools.Instance.tools.Count)];

        private List<string> definingEvents = new List<string>
        {
            "I stood up to a tyrant's agents.",
            "I saved people during a natural disaster.",
            "I stood alone against a terrible monster.",
            "I stole from a corrupt merchant to help the poor.",
            "I led a militia to fight off an invading army.",
            "I broke into a tyrant’s castle and stole weapons to arm the people.",
            "I trained the peasantry to use farm implements as weapons against a tyrant’s soldiers.",
            "A lord rescinded an unpopular decree after I led a symbolic act of protest against it.",
            "A celestial, fey, or similar creature gave me a blessing or revealed my secret origin.",
            "Recruited into a lord’s army, I rose to leadership and was commended for my heroism."
        };

        public string setBond()
        {
            throw new System.NotImplementedException();
        }

        public List<string> setEquipment() => new List<string> { $"{artisansTools}", "Shovel", "Iron pot", "Set of common clothes", "Belt pouch containing 10 gp" };

        public Dictionary<string, string> setFeatures()
        {
            throw new System.NotImplementedException();
        }

        public string setFlaw()
        {
            throw new System.NotImplementedException();
        }

        public string setIdeal()
        {
            throw new System.NotImplementedException();
        }

        public List<string> setLanguages()
        {
            throw new System.NotImplementedException();
        }

        public string setPersonalityTrait()
        {
            throw new System.NotImplementedException();
        }

        public List<string> setSkills() => new List<string> { "Animal Handling", "Survival" };

        public Dictionary<string, string> setSpecial()
        {
            throw new System.NotImplementedException();
        }

        public List<string> setToolsProf() => new List<string> { $"{artisansTools}", "Vehicles (Land)" };
    }
}