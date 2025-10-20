using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.WorldBuilding;
using Terraria.ID;
using Terraria.GameContent.Generation;
using System.IO;
using WeBall.Content.SuperHardmode.Tiles.Ores;
using WeBall.Core.Systems;

namespace WeBall.Core.Systems
{
    public class SuperHardmodeSystem : ModSystem
    {
        public static bool superHardmode;

        public override void OnWorldLoad() => superHardmode = false;

        public override void OnWorldUnload() => superHardmode = false;

        public override void SaveWorldData(TagCompound tag)
        {
            if (tag.ContainsKey("superHardmode"))
                superHardmode = tag.GetBool("SuperHardmode");
        }

        public override void LoadWorldData(TagCompound tag)
        {
            superHardmode = tag.GetBool("superHardmode");
        }

        public override void NetSend(BinaryWriter writer)
        {
            writer.Write(superHardmode);
        }

        public override void NetReceive(BinaryReader reader)
        {
            superHardmode = reader.ReadBoolean();
        }

        public override void PreUpdateWorld()
        {
            if (!SuperHardmodeSystem.superHardmode && NPC.downedMoonlord)
            {
                ActivateSuperHardmode();
            }
        }

        private void ActivateSuperHardmode()
        {
            superHardmode = true;

            if (Main.netMode != NetmodeID.Server)
            {
                Main.NewText("-------", 255, 100, 50);
            }

            if (Main.netMode == NetmodeID.Server)
                NetMessage.SendData(MessageID.WorldData);
        }
    }
}