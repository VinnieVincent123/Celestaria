using Terraria;
using Terraria.ID;
using Terraria.Audio;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using WeBall.Core.Systems;

namespace WeBall.Content.SuperHardmode.NPCs.Enemies
{
    public class ShootingStarSlime : ModNPC
    {
        private bool wingsLost;

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[NPC.type] = 1;
        }

        public override void SetDefaults()
        {
            NPC.width = 48;
            NPC.height = 40;
            NPC.damage = 80;
            NPC.defense = 40;
            NPC.lifeMax = 4800;
            NPC.knockBackResist = 0.4f;
            NPC.aiStyle = -1;
            NPC.noGravity = true;
            NPC.noTileCollide = true;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (SuperHardmodeSystem.superHardmode && spawnInfo.Player.ZoneOverworldHeight)
                return 0.08f;
            return 0f;    
        }

        public override void AI()
        {
            Player target = Main.player[NPC.target];
            if (!target.active || target.dead)
            {
                NPC.TargetClosest(false);
                return;
            }

            if (!wingsLost)
            {
                Vector2 moveTo = target.Center + new Vector2(0, -100f);
                Vector2 move = (moveTo - NPC.Center) * 0.04f;
                NPC.velocity = Vector2.Lerp(NPC.velocity, move, 0.2f);

                if (Main.netMode != NetmodeID.MultiplayerClient && Main.rand.NextBool(80))
                {
                    Vector2 dir = (target.Center - NPC.Center).SafeNormalize(Vector2.UnitY);
                    Projectile.NewProjectile(NPC.GetSource_FromAI(), NPC.Center, dir * 10f,
                        ProjectileID.FallingStar, 45, 1.5f, Main.myPlayer);
                    SoundEngine.PlaySound(SoundID.Item9, NPC.Center);    
                }

                if (NPC.life < NPC.lifeMax / 2)
                {
                    wingsLost = true;
                    NPC.noGravity = false;
                    NPC.noTileCollide = false;
                    SoundEngine.PlaySound(SoundID.Item14, NPC.Center);
                    for (int i = 0; i < 20; i++)
                        Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.GoldFlame, Main.rand.NextFloat(-3, 3), Main.rand.NextFloat(-3, 3));
                }
            }
            else
            {
                NPC.aiStyle = 1;
                if (Main.rand.NextBool(120) && NPC.velocity.Y == 0)
                {
                    Vector2 dir = (target.Center - NPC.Center).SafeNormalize(Vector2.UnitY);
                    Projectile.NewProjectile(NPC.GetSource_FromAI(), NPC.Center, dir * 8f,
                        ProjectileID.Starfury, 30, 1.5f, Main.myPlayer);
                }
            }
        }

        public override void HitEffect(NPC.HitInfo hit)
        {
            if (NPC.life <= 0)
            {
                for (int i = 0; i < 15; i++)
                    Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.BlueTorch, Main.rand.NextFloat(-3, 3), Main.rand.NextFloat(-3, 3));

            }
        }

        public override void FindFrame(int frameHeight)
        {
            NPC.frame.Y = (int)(Main.GameUpdateCount / 10 % Main.npcFrameCount[NPC.type]) * frameHeight;
        }
    }
}