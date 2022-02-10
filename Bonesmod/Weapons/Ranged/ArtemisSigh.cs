using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bonesmod.Weapons.Ranged
{
	public class ArtemisSigh : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("The Hunter's deathbringer" +
			"\nEvery 10 Shots you gain the thrill of the hunt Buff." +
			"\n Replaces wooden arrows with Wild arrows, which have a higher velocity and inflicts the Marked Debuff.");
		}

		public override void SetDefaults()
		{
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.useAnimation = 10;
			item.useTime = 10;
			item.shootSpeed = 20f;
			item.knockBack = 2f;
			item.damage = 120;
			item.UseSound = SoundID.Item5;
			item.shoot = ProjectileID.Phantasm;
			item.shootSpeed = 75f;
			item.rare = ItemRarityID.Cyan;
			item.value = Item.sellPrice(0, 10);
			item.noMelee = true;
			item.ranged = true;
			item.useAmmo = AmmoID.Arrow;
			item.autoReuse = true;
			item.width = 42;
			item.height = 90;
		}
		public override void AddRecipes()
		{
			var recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.objectolite.ObjectoliteBar>(), 12);
			recipe.AddIngredient(ItemID.FragmentVortex, 20);
			recipe.AddIngredient(ItemID.SoulofMight, 4);
			recipe.AddIngredient(ItemID.Vine, 7);
			recipe.AddIngredient(ItemID.Tsunami);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		int ShotCount = 0;
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			ShotCount++;
			if (ShotCount == 15)
            {
				player.AddBuff(ModContent.BuffType<BuffsnDebuffs.ThrillOfTheHunt>(), 360);
				ShotCount = 0;
			}
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 25f;
			if (type == ProjectileID.WoodenArrowFriendly)
			{
				type = ModContent.ProjectileType<Projectiles.WildArrow>();

			}
			float numberProjectiles = 3;
			float rotation = MathHelper.ToRadians(2);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f;
				var projectile = Projectile.NewProjectileDirect(position, new Vector2(perturbedSpeed.X, perturbedSpeed.Y), type, damage, knockBack, player.whoAmI);
				projectile.noDropItem = true;
			}
			return false;
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-17, 0);
		}
    }
}
