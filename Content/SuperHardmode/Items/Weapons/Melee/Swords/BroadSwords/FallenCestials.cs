using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WeBall.Content.SuperHardmode.Items.Weapons.Melee.Swords.BroadSwords
{
    public class FallenCelestials : ModItem
    {
        public override void SetStaticDefaults()
        {

        }

        public override void SetDefaults()
        {
            Item.width = 50;
            Item.height = 50;
            Item.damage = 180;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useAnimation = 16;
            Item.useTime = 16;
            Item.shootSpeed = 6f;
            Item.knockBack = 7f;
            Item.UseSound = SoundID.Item1;
            Item.DamageType = DamageClass.Melee;
            Item.autoReuse = true; 
        }
    }
}
