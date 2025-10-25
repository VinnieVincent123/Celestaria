using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WeBall.Content.PreHardmode.NPCs.Bosses.Desert
{
    public class AntlionChaserKnight : ModNPC
    {
        private Action<NPC> difficultyBehavior;
        private bool initialized;

        public static bool bossAlive;

        public override void SetDefaults()
        {
            NPC.height = 403;
            NPC.width = 572;
            NPC.aiStyle = -1;
            NPC.damage = 35;
            NPC.defense = 5;
            NPC.noGravity = true;
            NPC.noTileCollide = true;
            NPC.knockBackResist = 0f;
            NPC.lavaImmune = true;
            NPC.boss = true;
            NPC.lifeMax = 6800;
        }

        public override void ApplyDifficultyAndPlayerScaling(int numPlayers, float balance, float bossAdjustment)
        {
            NPC.lifeMax = (int)(NPC.lifeMax * balance);
        }

        public override void SendExtraAI(BinaryWriter writer)
        {
            base.SendExtraAI(writer);

            writer.Write(NPC.scale);
        }

        public override void ReceiveExtraAI(BinaryReader reader)
        {
            base.ReceiveExtraAI(reader);

            NPC.scale = reader.ReadSingle();
        }

        public override void AI()
        {
           if (!initialized)
           {
               SelectDifficultyBehavior();
               initialized = true;
           }

           difficultyBehavior?.Invoke(NPC);
        }

        

        private void SelectDifficultyBehavior()
        {
            else if (Main.getGoodWorld)
                difficultyBehavior = LegendaryAI;    
            else if (Main.masterMode)
                difficultyBehavior = MasterAI;
            else if (Main.expertMode)
                difficultyBehavior = ExpertAI;
            else
                difficultyBehavior = ClassicAI;                
        }

        private void ClassicAI(NPC npc)
        {
            //
        }

        private void ExpertAI(NPC npc)
        {
            //
        }

        private void MasterAI(NPC npc)
        {
            //
        }

        private void LegendaryAI(NPC npc)
        {
            //
        }
    }
}


