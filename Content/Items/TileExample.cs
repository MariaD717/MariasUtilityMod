using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MariasUtilityMod.Content.Items
{
    // This is a basic item template.
    // Please see tModLoader's ExampleMod for every other example:
    // https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
    public class TileExample : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.MariasUtilityMod.hjson' file.
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Tile Example");
        }
        public override void SetDefaults()
        {
            Item.useTime = 1;
            Item.useAnimation = 10;
            Item.autoReuse = false;
            Item.rare = ItemRarityID.Gray;
            Item.value = 20;
            Item.width = 8;
            Item.height = 8;
            Item.maxStack = 10;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<PinkBlockTile>();
            Item.useStyle = ItemUseStyleID.Swing;

        }
    }
      
}