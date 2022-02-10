using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bonesmod.Tiles.Objectolite
{
    public class ObjectoliteOre : ModTile
    {
        public override void SetDefaults()
        {
            TileID.Sets.Ore[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileShine[Type] = 975;
            Main.tileShine2[Type] = true;
            Main.tileValue[Type] = 775;
            Main.tileSpelunker[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Objectolite Ore");
            AddMapEntry(new Microsoft.Xna.Framework.Color(0, 103, 105), name);

            drop = ModContent.ItemType<Items.objectolite.ObjectoliteOre>();
            soundType = SoundID.Tink;
            soundStyle = 1;
            minPick = 210;
            mineResist = 30f;
        }
    }
}
