using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using WeBall.Content.SuperHardmode.Tiles.Biomes.Infection;

namespace WeBall.Content.SuperHardmode.Biomes.Blocks
{
    public class InfectedStone : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 12;
            Item.height = 12;
            Item.maxStack = 9999;
            Item.value = Item.sellPrice(gold: 1);
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<InfectedStoneTile>(); 
        }
    }
}
