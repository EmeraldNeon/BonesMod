using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bonesmod.Weapons.Mage
{
    public class BoneZone : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.staff[item.type] = true;
            Tooltip.SetDefault("Sprays a vicous barrage of homing Bones." +
                "\nHas a high Crit Chance and Fast Attack speed.");
        }
        public override void SetDefaults()
        {
            //Stats
            item.magic = true;
            item.damage = 135;
            item.useTime = 6;
            item.mana = 10;
            item.noMelee = true;
            item.knockBack = 2;
            item.rare = ItemRarityID.Red;
            item.value = 460462;
            item.autoReuse = true;
            item.crit = 25;
            //visuals
            item.width = 40;
            item.height = 44;
            item.useAnimation = 6;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.UseSound = SoundID.Item20;
            //projectile Create
            item.shootSpeed = 40;
            item.shoot = ModContent.ProjectileType<Projectiles.BZBone>();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 1 + Main.rand.Next(2);
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30));
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
        public override void AddRecipes()
        {
            var recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.objectolite.ObjectoliteBar>(), 12);
            recipe.AddIngredient(ItemID.SkeletronMask);
            recipe.AddIngredient(ItemID.SkeletronPrimeMask);
            recipe.AddIngredient(ItemID.FragmentNebula, 20);
            recipe.AddIngredient(ItemID.Bone, 75);
            recipe.AddIngredient(ItemID.SoulofFright, 4);
            recipe.AddIngredient(ItemID.Razorpine);
            recipe.AddIngredient(ItemID.MagicDagger);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
