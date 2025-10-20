using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using WeBall.Content.SuperHardmode.Tiles.Furnitures.CraftingStations.Forges;

namespace WeBall.Content.SuperHardmode.Items.Furnitures.CraftingStations.Forges
{
    public class BeskarForge : ModItem
    {
        public override void SetDefaults()
        {
            Item.height = 30;
            Item.width = 30;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<BeskarForgeTile>();
        }
    }
}