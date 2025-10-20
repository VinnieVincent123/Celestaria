using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace WeBall.Content.SuperHardmode.Tiles.Furnitures.CraftingStations.Forges
{
    public class BeskarForgeTile : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileLighted[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = false;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style5x4); // Uses 5x4 style, but reduces height to 3.
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 18 };
            TileObjectData.newTile.Origin = new Point16(2, 1);
            TileObjectData.addTile(Type);

            AnimationFrameHeight = 54;
            TileID.Sets.DisableSmartCursor[Type] = true;
            DustType = DustID.Platinum; 


            AdjTiles = new int[] {
                TileID.LunarCraftingStation,
                TileID.DemonAltar,
                TileID.Furnaces,
                TileID.Hellforge,
                TileID.AdamantiteForge,
            };    
        }
    }
}