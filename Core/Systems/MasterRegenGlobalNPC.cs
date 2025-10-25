using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WeBall.Core.Systems
{
    public class MasterRegenGlobalNPC : GlobalNPC
    {
        private int timeSinceLastHit = 0;

        public override bool InstancePerEntity => true;

        public override void AI(NPC npc)
        {
            if (!Main.masterMode)
                return;

            if (npc.active && !npc.friendly && npc.life > 0)
            {
                timeSinceLastHit++;

                if (npc.life >= npc.lifeMax)
                {
                    timeSinceLastHit = 0;
                    return;
                }

                if (timeSinceLastHit > 300 && npc.life < npc.lifeMax)
                {
                    if (timeSinceLastHit % 60 == 0)
                    {
                    int regenAmount = npc.lifeMax / 50;
                    regenAmount = Utils.Clamp(regenAmount, 5, 200);
                    
                        npc.life += regenAmount;
                        if (npc.life > npc.lifeMax)
                            npc.life = npc.lifeMax;

                    if (Main.rand.NextBool(4))
                        Dust.NewDust(npc.position, npc.width, npc.height, DustID.HealingPlus, 0f, 0f, 150, default, 1.2f);

                    if (timeSinceLastHit % 60 == 0)
                        CombatText.NewText(npc.Hitbox, Microsoft.Xna.Framework.Color.LimeGreen, "+HP");    
                    }     
                }
            }    
        }

        public override void OnHitByItem(NPC npc, Player player, Item item, NPC.HitInfo hit, int damageDone)
        {
            timeSinceLastHit = 0;
        }

        public override void OnHitByProjectile(NPC npc, Projectile projectile, NPC.HitInfo hit, int damageDone)
        {
            timeSinceLastHit = 0;
        }
    }
}