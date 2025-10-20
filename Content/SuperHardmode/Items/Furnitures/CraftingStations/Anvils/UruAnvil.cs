using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using WeBall.Content.SuperHardmode.Tiles.Furnitures.CraftingStations.Anvils;
using WeBall.Content.SuperHardmode.Items.Materials.Bars;

namespace WeBall.Content.SuperHardmode.Items.Furnitures.CraftingStations.Anvils
{
    public class UruAnvil : ModItem
    {
        public override void SetDefaults()
        {
            Item.height = 20;
            Item.width = 25;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<UruAnvilTile>();
        }

        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<UruBar>(20).
                AddIngredient(ItemID.LunarCraftingStation).
                Register();
        }
    }
}