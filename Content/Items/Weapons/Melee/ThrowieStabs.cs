using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using DTC.Content.Projectiles.Weapons.Melee;

namespace DTC.Content.Items.Weapons.Melee
{
    internal class DTCNewTool1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            // Item creative research
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            base.SetDefaults();

            // Item size
            Item.width = 32;
            Item.height = 32;

            // Item animation
            Item.useStyle = ItemUseStyleID.Rapier;
            Item.autoReuse = true;
            Item.useTurn = true;

            // Projectile weapon stuff
            Item.noUseGraphic = true;
            Item.noMelee = true;
            Item.shootSpeed = 2.1f;
            Item.shoot = ModContent.ProjectileType<ThrowieStabsProjectile>();

            // Item speed
            Item.useTime = 12;
            Item.useAnimation = 12;

            // Item damage
            Item.DamageType = DamageClass.Melee;
            Item.damage = 28;
            Item.knockBack = 4f;
            Item.crit = 10;

            // Item value and others
            Item.value = Item.buyPrice(silver: 20);
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item1;


        }

        public override void AddRecipes()
        {
            base.AddRecipes();
            // Primary recipe
            CreateRecipe()
                .AddRecipeGroup(RecipeGroupID.Wood, 8)
                .AddIngredient(ItemID.StoneBlock, 10)
                .Register();

            // Secondary recipe
            CreateRecipe()
                .AddRecipeGroup(RecipeGroupID.Wood, 8)
                .AddIngredient(ItemID.SandBlock, 10)
                .Register();

        }

    }
}
