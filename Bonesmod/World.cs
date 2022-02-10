using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World.Generation;

namespace Bonesmod
{
    public class World : ModWorld
    {
        public static bool spawnOre;
        
        public override void Initialize()
        {
            spawnOre = false;
        }
        public override TagCompound Save()
        {
            return new TagCompound{
        {"ObjectoliteSpawn", spawnOre},
    };
        }
        public override void Load(TagCompound tag)
        {
            spawnOre = tag.GetBool("ObjectoliteSpawn");
        }
    }
}