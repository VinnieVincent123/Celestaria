using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WeBall.Content.SuperHardmode.Tiles.Furnitures.CraftingStations.Anvils
{
    public class UruAnvilTile : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileLighted[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = false;
            Main.tileSolidTop[Type] = true;
            Main.tileTable[Type] = true;
            DustType = 179;
            AdjTiles = new int[] { TileID.Anvils, TileID.MythrilAnvil };
        }
    }
}