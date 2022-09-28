using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;


namespace DTC.Common.Items.Weapons.Melee
{
    internal class SlapChop : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Slap Chop");
            Tooltip.SetDefault("Minces \ngrinds \nCHOPS!!");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            // Hitbox
            Item.width = 32;
            Item.height = 32;

            // Use and Animation Style
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.autoReuse = true;

            // Damage values
            Item.DamageType = DamageClass.Melee;
            Item.damage = 35;
            Item.knockBack = 4.6f;
            Item.crit = 17;


            // Misc
            Item.value = Item.buyPrice(copper: 80, silver: 20) ;
            Item.maxStack = 1;

            // Sound
            Item.UseSound = SoundID.Item1;
        }
        public override void AddRecipes()
        {
            base.AddRecipes();
            CreateRecipe()
                .AddIngredient(ItemID.DirtBlock, 20)
                .AddTile(TileID.WorkBenches)
                .Register();

        }
    }
}
