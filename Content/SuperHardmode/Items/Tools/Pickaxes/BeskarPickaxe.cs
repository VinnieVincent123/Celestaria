using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WeBall.Content.SuperHardmode.Items.Tools.Pickaxes
{
    public class BeskarPickaxe : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 30;
            Item.damage = 60;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.pick = 260;
            Item.tileBoost += 5;
            Item.knockBack = 5f;
            Item.DamageType = DamageClass.Melee;
            Item.useTurn = true;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }

        //public override void AddRecipes()
        //{
          //  CreateRecipes().
        //}
    }
}
