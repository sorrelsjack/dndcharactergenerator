using System.Collections.Generic;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Extensions;
using dnd_character_gen.Interfaces;

namespace dnd_character_gen.CharacterRaces
{
    public class Human : ICharacterRace
    {
        private List<string> maleNames = new List<string>
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

        private List<string> femaleNames = new List<string>
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

        public virtual Dictionary<string, int> setAbilityScores() => new Dictionary<string, int>
        {
            { "Strength", 1 },
            { "Dexterity", 1 },
            { "Constitution", 1 },
            { "Intelligence", 1 },
            { "Wisdom", 1 },
            { "Charisma", 1 }
        };

        public List<string> setArmorProf() => null;

        public virtual Dictionary<string, string> setFeatures() => null;

        public int setHitPointModifier() => 0;

        public List<string> setLanguages()
        {
            List<string> languages = new List<string> { "Common" };
            string language = "";

            while (languages.Count < 2)
            {
                language = Languages.Instance.languages[NumberGen.gen(Languages.Instance.languages.Count)];

                if (!languages.Contains(language))
                    languages.Add(language);
            }

            return languages;
        }

        public string setName() => NumberGen.gen(2) == 0
            ? femaleNames[NumberGen.gen(femaleNames.Count)]
            : maleNames[NumberGen.gen(maleNames.Count)];

        public string setSize() => "Medium";

        public List<string> setSkills() => null;

        public virtual int setSpeed() => 30;

        public virtual List<string> setToolsProf() => null;

        public List<string> setWeaponProf() => null;
    }
}