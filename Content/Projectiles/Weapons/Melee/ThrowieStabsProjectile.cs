using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace DTC.Content.Projectiles.Weapons.Melee
{
    internal class ThrowieStabsProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            base.SetDefaults();

            // Projectile size
            Projectile.width = 24;
            Projectile.height = 24;

            // Projectile properties
            Projectile.friendly = true; // Player/Npc damage
            Projectile.penetrate = -1; // Amount of penetration -1 infninte
            Projectile.tileCollide = false; // Destroyed on terrain
            Projectile.ownerHitCheck = true; // Damage through terrain ??
            Projectile.extraUpdates = 2; // Extra update rate of the projectile
            Projectile.timeLeft = 300; // Time of projectiles life

            // Projectile AI
            Projectile.aiStyle = ProjAIStyleID.ShortSword;

            // Projectile damage
            Projectile.DamageType = DamageClass.Melee;
            

            
        }
        public override void AI()
        {
            base.AI();

            Projectile.rotation = Projectile.velocity.ToRotation() + MathHelper.PiOver2 - MathHelper.PiOver4 * Projectile.spriteDirection; // Make projectile rotate

            int halfProjWidth = Projectile.width / 2;
            int halfProjHeight = Projectile.height / 2;

            // Spirte drawing override
            DrawOriginOffsetX = 0; // idk tbh
            DrawOffsetX = -((32 / 2) - halfProjWidth); // Sprite divided by 2
            DrawOriginOffsetY = -((32 /2 ) - halfProjHeight); // Sprite divided by 2

        }
    }
}
