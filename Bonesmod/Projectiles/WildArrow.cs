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

namespace Bonesmod.Projectiles
{
    public class WildArrow : ModProjectile
    {
		public override void SetDefaults()
		{
			projectile.width = 36;
			projectile.height = 16;
			projectile.friendly = true;
			projectile.ranged = true;
			projectile.penetrate = 1;
			projectile.timeLeft = 60000;
			projectile.Name = "Wild Arrow";
			projectile.tileCollide = true;
			projectile.ignoreWater = true;
			projectile.aiStyle = 0;
			projectile.damage = 17;
		}
        public override void AI()
        {
			projectile.rotation = projectile.velocity.ToRotation() + MathHelper.PiOver2;
			projectile.ai[0] += 1f;
			if (projectile.ai[0] >= 30f)
			{
				projectile.ai[0] = 15f;
				projectile.velocity.Y = projectile.velocity.Y + 0.1f;
			}
			if (projectile.velocity.Y > 16f)
			{
				projectile.velocity.Y = 16f;
			}
			projectile.velocity *= 1.125f;
		}
        public override void OnHitNPC(Terraria.NPC target, int damage, float knockback, bool crit)
        {
			target.AddBuff(ModContent.BuffType<BuffsnDebuffs.Marked>(), 360);
		}
    }
}
