using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using WeBall.Core.WorldGenC;

namespace WeBall.Core.Globals
{
    public class SuperHardmodeTrigger : GlobalNPC
    {
        public override void OnKill(NPC npc)
        {
            if (npc.type == NPCID.MoonLordCore && !Systems.SuperHardmodeSystem.superHardmode)
            {
                Systems.SuperHardmodeSystem.superHardmode = true;

                if (Main.netMode == NetmodeID.SinglePlayer)
                {
                    Main.NewText("The World trembles as cosmis powers flood through it...", 255, 80, 100);
                    Main.NewText("The World has been blessed with Vibranium!", 80, 180, 255);
                    Main.NewText("The World has been blessed with Uru!", 80, 180, 255);
                    Main.NewText("The World has been blessed with Beskar!", 80, 180, 255);
                }
                else if (Main.netMode == NetmodeID.Server)
                {
                    Terraria.Chat.ChatHelper.BroadcastChatMessage(
                        Terraria.Localization.NetworkText.FromLiteral("The World trembles as cosmic powers flood through it..."),
                        new Microsoft.Xna.Framework.Color(255, 80, 100)
                    );
                }

                SunPlainsConversion.StartConversion();

                Systems.SuperHardmodeOreGen.GenerateSuperOres();

                if (Main.netMode != NetmodeID.MultiplayerClient)
                    NetMessage.SendData(MessageID.WorldData);

                //insert worldgen here later
            }
        }
    }   
}
