using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace WeBall.Content.SuperHardmode.Projectiles.Weapons.Melee.Swords.BroadSwords
{
    public class SolsticeBeam : ModProjectile
    {
        private const float maxDetectRadius = 400f;
        private const float homingSpeed = 10f;

        public override void SetStaticDefaults()
        {

        }

        public override void SetDefaults()
        {
            Projectile.hostile = false;
            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.Melee;
            Projectile.penetrate = 3;
            Projectile.usesIDStaticNPCImmunity = true;
            Projectile.idStaticNPCHitCooldown = 10;
            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;
            Projectile.timeLeft = 300;
            Projectile.light = 0.5f;

        }

        public override void AI()
        {
            Lighting.AddLight(Projectile.Center, 0.3f, 0.45f, 0.8f);

            NPC target = FindClosestNPC(maxDetectRadius);
            if (target != null)
            {
                Vector2 direction = target.Center - Projectile.Center;
                direction.Normalize();
                direction *= homingSpeed;

                Projectile.velocity = (Projectile.velocity * 20f + direction) / 21f;
            }

            Projectile.rotation = Projectile.velocity.ToRotation() + MathHelper.PiOver2;
        }

        private NPC FindClosestNPC(float maxDetectDistance)
        {
            NPC closestNPC = null;
            float sqrMaxDetectDistance = maxDetectDistance * maxDetectDistance;
            float closestDist = sqrMaxDetectDistance;

            foreach (NPC npc in Main.npc)
            {
                if (npc.CanBeChasedBy() && !npc.friendly)
                {
                    float sqrDistance = Vector2.DistanceSquared(npc.Center, Projectile.Center);
                    if (sqrDistance < closestDist)
                    {
                        closestDist = sqrDistance;
                        closestNPC = npc;
                    }
                }
            }
            return closestNPC;
        }
    }
}