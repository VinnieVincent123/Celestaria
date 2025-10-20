using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using WeBall.Content.SuperHardmode.Items.Materials.Ores;

namespace WeBall.Content.SuperHardmode.Tiles.Ores
{
    public class BeskarOreTile : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileShine[Type] = 1100;
            Main.tileShine2[Type] = true;
            Main.tileOreFinderPriority[Type] = 700;
            Main.tileLighted[Type] = true;

            MineResist = 5f;
            MinPick = 250;

            AddMapEntry(new Color(80, 180, 255), CreateMapEntryName());
            DustType = DustID.Platinum;
            HitSound = SoundID.Tink;
        }
    }
}
