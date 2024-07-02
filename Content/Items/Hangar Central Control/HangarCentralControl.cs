using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Mechromancy.Content.Items.Hangar_Central_Control
{
    public class HangarCentralControl : ModTile
    {
        public override void SetStaticDefaults()
        {
            // Set tile as light source
            Main.tileLighted[Type] = true;

            // This changes a Framed tile to a tile that that uses a TileObjectData
            Main.tileFrameImportant[Type] = true;

            // Tile is not affected by lava
            Main.tileLavaDeath[Type] = false;

            // Use this to utilize an existing template
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);

            // Adds a new tile
            TileObjectData.addTile(Type);
        }

        // This method allows you to determine how much light this block emits
        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.93f;
            g = 0.11f;
            b = 0.12f;
        }

    }

    public class HangarCentralControlItem : ModItem
    {
        public override void SetDefaults()
        {
            //Item.CloneDefaults(ItemID.FireflyinaBottle);
            Item.createTile = ModContent.TileType<HangarCentralControl>();
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .Register();
        }
    }
}
