using Terraria;
using Terraria.ID;
using Terraria.Audio;
using Terraria.ModLoader;
using Luminance.Core.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using WeBall.Content.SuperHardmode.Projectiles.Weapons.Melee.Swords.BroadSwords;

namespace WeBall.Content.SuperHardmode.Items.Weapons.Melee.Swords.BroadSwords
{
    public class SolsticeBlade : ModItem
    {
        public override void SetStaticDefaults()
        {

        }

        public override void SetDefaults()
        {
            Item.width = 200;
            Item.height = 100;
            Item.damage = 250;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useAnimation = 16;
            Item.useTime = 16;
            Item.shootSpeed = 6f;
            Item.shoot = ModContent.ProjectileType<SolsticeBeam>();
            Item.knockBack = 7f;
            Item.UseSound = SoundID.Item1;
            Item.DamageType = DamageClass.Melee;
            Item.autoReuse = true; 
        }
    }
}