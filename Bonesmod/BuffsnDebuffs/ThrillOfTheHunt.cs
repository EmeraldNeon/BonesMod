using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bonesmod.BuffsnDebuffs
{
    public class ThrillOfTheHunt : ModBuff
	{
        public override void SetDefaults()
		{
			DisplayName.SetDefault("Thrill Of The Hunt");
			Description.SetDefault("Increases all stats by a small amount." +
			"\n If you really have a thrilling hunt, you wouldn't be reading this.");
			Main.buffNoTimeDisplay[Type] = false;
			Main.debuff[Type] = false;
		}

        public override void Update(Player player, ref int buffIndex)
		{
			player.statDefense += 4;
			player.allDamageMult += 0.1f;
			player.lifeRegen +=4;
			player.maxRunSpeed += 8;
		}
	}
}
