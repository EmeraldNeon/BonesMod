using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace Bonesmod.Items.objectolite
{
    public class ObjectoliteBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Refined Bars with small Dark Objectolite Impurities. Maybe you can refine it?");
        }
        public override void SetDefaults()
        {
            //Hitbox Size
            item.width = 12;
            item.height = 12;
            // Stack & Value Infofs
            item.maxStack = 9999;
            item.value = Item.buyPrice(gold: 3);
            item.rare = ItemRarityID.Cyan;
            item.consumable = true;
            //Usage
            item.useTime = 12;
            item.useAnimation = 12;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTurn = true;
            item.consumable = true;
            item.autoReuse = true;
            //Create Tile
            item.createTile = ModContent.TileType <Tiles.Objectolite.ObjectoliteBar> ();
            item.placeStyle = 0;
        }

        public override void AddRecipes()
        {

            var recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<ObjectoliteOre>(), 3);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
