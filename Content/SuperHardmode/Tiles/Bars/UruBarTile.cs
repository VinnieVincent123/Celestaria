using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace WeBall.Content.SuperHardmode.Tiles.Bars
{
    public class UruBarTile : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileShine[Type] = 1100;
            Main.tileShine2[Type] = true;
            Main.tileLighted[Type] = true;

            AddMapEntry(new Color(80, 180, 255), CreateMapEntryName());
            DustType = DustID.Platinum;
            HitSound = SoundID.Tink;
        }
    }
}
