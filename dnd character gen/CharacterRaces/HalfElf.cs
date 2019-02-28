using System.Collections.Generic;
using System.Linq;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterRaces
{
    public class HalfElf : ICharacterRace //TODO: fix this to reflect heritage (features). Fix subraces too.
    {
        private List<string> maleElfNames = new List<string>
        {
            "Adran", "Aelar", "Aramil", "Arannis", "Aust", "Beiro", "Berrian", "Carric", "Enialis", "Erdan", "Erevan",
            "Galinndan", "Hadarai", "Heian", "Himo", "Immeral", "Ivellios", "Laucian", "Mindartis", "Paelias", "Peren",
            "Quarion", "Riardon", "Rolen", "Soveliss", "Thamior", "Tharivol", "Theren", "Varis"
        };

        private List<string> femaleElfNames = new List<string>
        {
            "Adrie", "Althaea", "Anastrianna", "Andraste", "Antinua", "Bethrynna", "Birel", "Caelynn", "Drusilia", "Enna",
            "Felosial", "Ielenia", "Jelenneth", "Keyleth", "Leshanna", "Lia", "Meriele", "Mialee", "Naivara", "Quelenna",
            "Quillathe", "Sariel", "Shanairra", "Shava", "Silaqui", "Theirastra", "Thia", "Vadania", "Valanthe", "Xanaphia"
        };

        private List<string> maleHumanNames = new List<string>
        {
            "Aseir", "Bardeid", "Haseid", "Khemed", "Mehmen", "Sudeiman", "Zasheir",
            "Darvin", "Dorn", "Evendur", "Gorstag", "Grim", "Helm", "Malark", "Morn", "Randal", "Stedd",
            "Bor", "Fodel", "Glar", "Grigor", "Igan", "Ivor", "Kosef", "Mival", "Orel", "Pavel", "Sergor",
            "Ander", "Blath", "Bran", "Frath", "Geth", "Lander", "Luth", "Malcer", "Stor", "Taman", "Urth",
            "Aoth", "Bareris", "Ehput-Ki", "Kethoth", "Mumed", "Ramas", "So-Kehur", "Thazar-De", "Urhur",
            "Borivik", "Faurgar", "Jandar", "Kanithar", "Madislak", "Ralmevik", "Shaumar", "Vladislak",
            "An", "Chen", "Chi", "Fai", "Jiang", "Jun", "Lian", "Long", "Meng", "On", "Shan", "Shui", "Wen",
            "Anton", "Diero", "Marcon", "Pieron", "Rimardo", "Romero", "Salazar", "Umbero"
        };

        private List<string> femaleHumanNames = new List<string>
        {
            "Atala", "Ceidil", "Hama", "Jasmal", "Meilil", "Seipora", "Yasheira", "Zasheida",
            "Arveene", "Esvele", "Jhessail", "Kerri", "Lureene", "Miri", "Rowan", "Shandri", "Tessele",
            "Alethra", "Kara", "Katernin", "Mara", "Natali", "Olma", "Tana", "Zora",
            "Amafrey", "Betha", "Cefrey", "Kethra", "Mara", "Olga", "Silifrey", "Westra",
            "Arizima", "Chathi", "Nephis", "Nulara", "Murithi", "Sefris", "Thola", "Umara", "Zolis",
            "Fyevarra", "Hulmarra", "Immith", "Imzel", "Navarra", "Shevarra", "Tammith", "Yuldra",
            "Bai", "Chao", "Jia", "Lei", "Mei", "Qiao", "Shui", "Tai",
            "Balama", "Dona", "Faila", "Jalana", "Luisa", "Marta", "Quara", "Selise", "Vonda"
        };

        public virtual Dictionary<string, int> setAbilityScores()
        {
            Dictionary<string, int> abilityScores = new Dictionary<string, int>
            {
                { "Charisma", 2 }
            };
            List<string> availableStats = new List<string> { "Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom" };
            string stat = "";

            while (abilityScores.Count < 3)
            {
                stat = availableStats[NumberGen.gen(availableStats.Count)];

                abilityScores.Add(stat, 1);
                availableStats.Remove(stat);
            }

            return abilityScores;
        }

        public List<string> setArmorProf() => null;

        public virtual Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Darkvision", "Thanks to your elf blood, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray." },
            { "Fey Ancestry", "You have advantage on saving throws against being charmed, and magic can’t put you to sleep." },
            { "Skill Versatility", "You gain proficiency in two skills of your choice." },
            { "Languages", "You can speak, read, and write Common, Elvish, and one extra language of your choice." }
        };

        public int setHitPointModifier() => 0;

        public virtual List<string> setLanguages()
        {
            List<string> languages = new List<string> { "Common", "Elvish" };
            string language = "";

            while (languages.Count < 3)
            {
                language = Languages.Instance.languages[NumberGen.gen(Languages.Instance.languages.Count)];

                if (!languages.Contains(language))
                    languages.Add(language);
            }

            return languages;
        }

        public string setName()
        {
            string name = "";
            int randomNumber = NumberGen.gen(2);

            if (randomNumber == 0)
            {
                randomNumber = NumberGen.gen(2);
                if (randomNumber == 0)
                    name = femaleElfNames[NumberGen.gen(femaleElfNames.Count)];
                else if (randomNumber == 1)
                    name = maleElfNames[NumberGen.gen(maleElfNames.Count)];
            }
            else
            {
                randomNumber = NumberGen.gen(2);
                if (randomNumber == 0)
                    name = femaleHumanNames[NumberGen.gen(femaleHumanNames.Count)];
                else if (randomNumber == 1)
                    name = maleHumanNames[NumberGen.gen(maleHumanNames.Count)];
            }

            return name;
        }

        public string setSize() => "Medium";

        public List<string> setSkills()
        {
            List<string> skillProficiencies = new List<string>();
            string skill = "";

            while (skillProficiencies.Count < 2)
            {
                skill = Skills.Instance.skills.Keys.ElementAt(NumberGen.gen(Skills.Instance.skills.Count));

                if (!skillProficiencies.Contains(skill))
                {
                    skillProficiencies.Add(skill);
                }
            }

            return skillProficiencies;
        }

        public int setSpeed() => 30;

        public List<string> setToolsProf() => null;

        public List<string> setWeaponProf() => null;
    }
}