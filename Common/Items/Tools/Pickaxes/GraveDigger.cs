using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace DTC.Common.Items.Tools.Pickaxes
{
    internal class GraveDigger : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 32;
            Item.height = 32;

            Item.useTime = 6;
            Item.useAnimation = 60;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.autoReuse = true;
            Item.useTurn = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 69;
            Item.knockBack = 3f;
            Item.crit = 28;

            Item.value = Item.buyPrice(silver: 20);
            Item.rare = ItemRarityID.Blue;

            Item.pick = 20;
        }

        public override void AddRecipes()
        {
            base.AddRecipes();
            CreateRecipe()
                .AddRecipeGroup(RecipeGroupID.Wood, 8)
                .AddIngredient(ItemID.EbonstoneBlock, 10)
                .Register();

            CreateRecipe()
                .AddRecipeGroup(RecipeGroupID.Wood, 8)
                .AddIngredient(ItemID.CrimstoneBlock, 10)
                .Register();
                
        }

    }
}
