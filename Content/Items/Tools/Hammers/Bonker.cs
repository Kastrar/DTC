﻿using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DTC.Content.Items.Tools.Hammers
{
    internal class Bonker : ModItem
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
            Item.damage = 69;
            Item.knockBack = 3f;
            Item.crit = 28;

            // Item value
            Item.value = Item.buyPrice(silver: 20);
            Item.rare = ItemRarityID.Blue;

            // Pickaxe power and use time
            Item.hammer = 20;
            Item.useTime = 6;
            Item.useAnimation = 60;
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
