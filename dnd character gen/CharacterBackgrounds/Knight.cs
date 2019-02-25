using System.Collections.Generic;

namespace dnd_character_gen.CharacterBackgrounds
{
    public class Knight : Noble
    {
        public override Dictionary<string, string> setFeatures() => new Dictionary<string, string>
        {
            { "Retainers", "You have the service of three retainers loyal to your family. These retainers can be attendants or messengers, and one might be a majordomo. Your retainers are commoners who can perform mundane tasks for you, but they do not fight for you, will not follow you into obviously dangerous areas (such as dungeons), and will leave if they are frequently endangered or abused" },
            { "Variant Noble: Knight", "A knighthood is among the lowest noble titles in most societies, but it can be a path to higher status. If you wish to be a knight, choose the Retainers feature instead of the Position of Privilege feature. One of your commoner retainers is replaced by a noble who serves as your squire, aiding you in exchange for training on his or her own path to knighthood. Your two remaining retainers might include a groom to care for your horse and a servant who polishes your armor (and even helps you put it on). \nAs an emblem of chivalry and the ideals of courtly love, you might include among your equipment a banner or other token from a noble lord or lady to whom you have given your heart — in a chaste sort of devotion. (This person could be your bond.)" }
        };

        public override List<string> setEquipment() => new List<string> { "Set of fine clothes", "Signet ring", "Token from courted noble", "Scroll of pedigree", "Purse containing 25 gp" };
    }
}