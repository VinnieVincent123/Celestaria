using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using WeBall.Core.Systems;

namespace WeBall.Core.Ambience
{
    public class SunPlainsAmbientSystem : ModSystem
    {
        public override void PostDrawTiles()
        {
            Player player = Main.LocalPlayer;
            if (!SuperHardmodeSystem.superHardmode || !player.ZoneOverworldHeight)
                return;

            for (int i = 0; i < 4; i++)
            {
                if (Main.rand.NextBool(5))
                {
                    Vector2 pos = player.Center + Main.rand.NextVector2Circular(600, 300);
                    Dust.NewDustPerfect(pos, DustID.GoldFlame, Main.rand.NextVector2Circular(0.5f, 0.5f),
                    100, new Color(255, 230, 120), 1.2f).noGravity = true;
                }
            }    
        }
    }
}