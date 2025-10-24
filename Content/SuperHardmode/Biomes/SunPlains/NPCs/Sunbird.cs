using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using WeBall.Core.Systems;

namespace WeBall.Content.SuperHardmode.Biomes.SunPlains.NPCs
{
    public class Sunbird : ModNPC
    {
        public override void SetDefaults()
        {
            NPC.width = 38;
            NPC.height = 20;
            NPC.damage = 0;
            NPC.defense = 0;
            NPC.lifeMax = 5;
            NPC.noGravity = true;
            NPC.aiStyle = 67;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
           => (SuperHardmodeSystem.superHardmode && Main.dayTime && spawnInfo.Player.ZoneOverworldHeight) ? 0.1f : 0f;

        public override void AI()
        {
            Lighting.AddLight(NPC.Center, 0.5f, 0.4f, 0.1f);
        }   
    }
}
