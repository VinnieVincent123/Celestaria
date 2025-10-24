using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace  WeBall.Content.SuperHardmode.Biomes.SunPlains.Blocks
{
    public class SunGrass : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileBlendAll[Type] = true;
            Main.tileLighted[Type] = true;

            AddMapEntry(new Color(255, 230, 130));
            DustType = DustID.GoldFlame;
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            Lighting.AddLight(new Vector2(i, j).ToWorldCoordinates(), 0.5f, 0.4f, 0.1f);
        }
    }
}
