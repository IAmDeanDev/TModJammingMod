using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using TracerWizard.Content.DamageClasses;
using TracerWizard.Content.Projectiles;

namespace TracerWizard.Content.Items.Weapons.PreHardmode.SpiritClass
{
    public class SpiritTestWeapon : ModItem
    {

        public override void SetStaticDefaults()
        {
            Item.staff[Type] = true;
        }


        public override void SetDefaults()
        {
            Item.width = 140;
            Item.height = 21;

            Item.DamageType = ModContent.GetInstance<Spirit>();

            Item.useStyle = ItemUseStyleID.Shoot;
            Item.channel = true;
            Item.useTime = 2;
            Item.useAnimation = 2;
            Item.autoReuse = true;
            Item.mana = 0;
            Item.crit = 10;
            Item.shoot = ModContent.ProjectileType<InvisibleProjectile>();

            Item.damage = 5;
            Item.knockBack = 1;
            Item.crit = 5;
            Item.value = Item.sellPrice(gold: 1);
            Item.rare = ItemRarityID.Purple;

            Item.noUseGraphic = true;
            Item.noMelee = true;

        }

        public override bool CanShoot(Player player)
        {
            if (player.HeldItem.shoot == ModContent.ProjectileType<InvisibleProjectile>() && player.ownedProjectileCounts[Item.shoot] > 1)
                return false;
            return true;
        }
    }
}