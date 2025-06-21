using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using TracerWizard.Content.DamageClasses;

namespace TracerWizard.Content.Projectiles
{
    public class InvisibleProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            ProjectileID.Sets.NoLiquidDistortion[Type] = true;
        }

        public override void SetDefaults()
        {
            Projectile.width = 25;
            Projectile.height = 25;

            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.DamageType = ModContent.GetInstance<Spirit>();
            Projectile.penetrate = -1;
            Projectile.timeLeft = 2;
            Projectile.light = 0.25f;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = false;

            Projectile.alpha = 255;
        }

        public override void AI()
        {
            Player player = Main.player[Projectile.owner];

            if (player.ownedProjectileCounts[ModContent.ProjectileType<InvisibleProjectile>()] > 0)
            {
                Projectile.Kill();
                return;
            }

            Projectile.timeLeft = 2;
            Projectile.Center = Main.MouseWorld;
            Projectile.netImportant = true;
            Projectile.netUpdate = true;
        }
    }
}