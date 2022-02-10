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
    public class ObjectoliteOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault ("Contains energy from another plane of existance.");
        }
        public override void SetDefaults()
        {
            //Hitbox Size
            item.width = 12;
            item.height = 12;
            // Stack & Value Infofs
            item.maxStack = 9999;
            item.value = Item.buyPrice(gold: 1);
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
            item.createTile = ModContent.TileType < Tiles.Objectolite.ObjectoliteOre> ();
            }
        }
    }
