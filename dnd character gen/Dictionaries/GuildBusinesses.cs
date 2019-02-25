using System.Collections.Generic;

namespace dnd_character_gen.Dictionaries
{
    public class GuildBusinesses
    {
        //Dictionary of businesses, paired with the artisan tools they use for their business.
        public Dictionary<string, string> guilds = new Dictionary<string, string>();

        private GuildBusinesses()
        {
            guilds.Add("Alchemist and Apothicaries", "Alchemist's supplies");
            guilds.Add("Armorers, locksmiths and finesmiths", "Mason's tools"); //??
            guilds.Add("Brewers, distillers and vintners", "Brewer's supplies");
            guilds.Add("Calligraphers, scribes and scriveners", "Calligrapher's supplies");
            guilds.Add("Carpenters, roofers and plasterers", "Carpenter's tools");
            guilds.Add("Cartographers, surveyors and chart makers", "Cartographer's tools");
            guilds.Add("Cobblers and shoemakers", "Cobbler's tools");
            guilds.Add("Cooks and bakers", "Cook's utensils");
            guilds.Add("Glassblowers and glaziers", "Glassblower's tools");
            guilds.Add("Jewelers and gem cutters", "Jeweler's tools");
            guilds.Add("Leatherworkers, skinners and tanners", "Leatherworker's tools");
            guilds.Add("Masons and stonecutters", "Mason's tools");
            guilds.Add("Painters, limners and sign makers", "Painter's supplies");
            guilds.Add("Potters and tile makers", "Potter's tools");
            guilds.Add("Shipwrights and sail makers", "Carpenter's tools"); //??
            guilds.Add("Smiths and metal workers", "Smith's tools");
            guilds.Add("Tinkers, pewterers and casters", "Tinker's tools");
            guilds.Add("Wagon makers and wheelwrights", "Carpenter's tools"); //??
            guilds.Add("Weavers and dyers", "Weaver's tools");
            guilds.Add("Woodcarvers, coopers and bowyers", "Woodcarver's tools");
        }

        private static GuildBusinesses instance;

        public static GuildBusinesses Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GuildBusinesses();
                }

                return instance;
            }
        }
    }
}