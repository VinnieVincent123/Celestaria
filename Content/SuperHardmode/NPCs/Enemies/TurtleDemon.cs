using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Utilities;
using WeBall.Core.Systems;

namespace WeBall.Content.SuperHardmode.NPCs.Enemies
{
    public class TurtleDemon : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 1;
        }
        
        public override void SetDefaults()
        {
            NPC.lifeMax = 25000;
            NPC.damage = 1000;
            NPC.defense = 100;
            NPC.knockBackResist = 1.0f;
            NPC.height = 50;
            NPC.width = 70;
            NPC.aiStyle = 39;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (spawnInfo.Player.ZoneUnderworldHeight && !SuperHardmodeSystem.superHardmode && !spawnInfo.Invasion)
            {
                return SpawnCondition.Underworld.Chance * 0.35f;
            }
            return 0f;
        }
    }
}