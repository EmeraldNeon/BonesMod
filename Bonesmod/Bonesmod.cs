using Terraria.ModLoader;

namespace Bonesmod
{
	public class Bonesmod : Mod
	{
		public static Bonesmod Instance;

		public Bonesmod()
        {
			Instance = this;
        }

        public override void Load()
        {
            if(Instance == null || Instance != this )
            {
                Instance = this;
            }
        }
        public override void PostSetupContent()
        {
            Mod wWeaponScaling = ModLoader.GetMod("WWeaponScaling");
            if (wWeaponScaling != null)
            {
                wWeaponScaling.Call(ModContent.ItemType<Weapons.Mage.BoneZone>(), 13, 1f);
                wWeaponScaling.Call(ModContent.ItemType<Weapons.Ranged.ArtemisSigh>(), 13, 1f);
            }
        }
    }
}