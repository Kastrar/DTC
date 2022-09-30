using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace DTC.Common.Items.Tools.Pickaxes
{
    internal class DefaultNewTool : ModItem
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

            // Item animation and sound
            Item.useStyle = ItemUseStyleID.Swing;
            Item.autoReuse = true;
            Item.useTurn = true;
            Item.UseSound = SoundID.Item1;

            // Item damage
            Item.DamageType = DamageClass.Melee;
            Item.damage = 20;
            Item.knockBack = 1f;
            Item.crit = 10;

            // Item value
            Item.value = Item.buyPrice(silver: 20);
            Item.rare = ItemRarityID.Blue;

            // Tool power and use time
            Item.useTime = 6;
            Item.useAnimation = 60;
            Item.pick = 20;
            Item.hammer = 20;
            Item.axe = 20;
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
