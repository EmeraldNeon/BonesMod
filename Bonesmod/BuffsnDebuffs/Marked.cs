using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bonesmod.BuffsnDebuffs
{
    public class Marked : ModBuff
    {
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Marked!");
			Description.SetDefault("Your weak points are exposed"); 
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true; 
		}
        public override void Update(Terraria.NPC npc, ref int buffIndex)
        {
			npc.defense -= 40;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense -= 20;
        }
    }
}
