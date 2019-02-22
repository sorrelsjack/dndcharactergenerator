using dnd_character_gen.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_gen.CharacterBackgrounds
{
    public class Gladiator : Entertainer
    {
        public override List<string> setEquipment() => new List<string> 
        {
            "Trident", "Net"
        };

        public override Dictionary<string, string> setSpecial() => new Dictionary<string, string>
            {
                { "Entertainer Routine", $"{entertainerRoutines[NumberGen.gen(entertainerRoutines.Count)]}" },
                { "Entertainer Variant: Gladiator", "A gladiator is as much an entertainer as any minstrel or circus performer, trained to make the arts of combat into a spectacle the crowd can enjoy. This kind of flashy combat is your entertainer routine, though you might also have some skills as a tumbler or actor. Using your By Popular Demand feature, you can find a place to perform in any place that features combat for entertainment—perhaps a gladiatorial arena or secret pit fighting club. You can replace the musical instrument in your equipment package with an inexpensive but unusual weapon, such as a trident or net." }
            };
    }
}
