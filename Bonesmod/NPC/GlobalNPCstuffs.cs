using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bonesmod.NPC
{
	public class GlobalNPCstuffs : GlobalNPC
    {
        public override void NPCLoot(Terraria.NPC npc)
        {
            if (npc.type == NPCID.CultistBoss)
            {
                if (!World.spawnOre)
                {
                    Main.NewText("A material from Another World seeps into the Caverns...", 28, 201, 57);
                    for (var i = 0; i <(int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); i++)
                    {
                        int x = WorldGen.genRand.Next(200, Main.maxTilesX - 200);
                        int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY - 500);

                        WorldGen.TileRunner(x, y, WorldGen.genRand.Next(4, 7), WorldGen.genRand.Next(3, 6),
                            ModContent.TileType<Tiles.Objectolite.ObjectoliteOre>());
                    }
                }
                World.spawnOre = true;
            }
        
        }
    }
}
