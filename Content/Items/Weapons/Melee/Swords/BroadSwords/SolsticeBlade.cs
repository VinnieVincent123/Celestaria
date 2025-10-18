using Terraria;
using Terraria.ID;
using Terraria.Audio;
using Terraria.ModLoader;
using Luminance.Core.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace WeBall.Content.Items.Weapons.Melee.Swords.BroadSwords
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
            Item.knockBack = 7f;
            Item.UseSound = SoundID.Item1;
            Item.DamageType = DamageClass.Melee;
            Item.autoReuse = true; 
        }

        public override bool CanUseItem(Player player)
        {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = false;
        }
    }
}