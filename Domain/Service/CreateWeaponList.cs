using Domain.Inventory.Weapon;
using Domain.Models;

namespace Domain.Service
{
    public static class CreateWeaponList
    {
        public static List<WeaponModel> WeaponList { get; set; } = new List<WeaponModel>();
        public static List<ArmorModel> ArmorList { get; set; } = new List<ArmorModel> { };
        public static List<ShieldModel> ShieldList { get; set; } = new List<ShieldModel> { };
        public static void CreateWeapon()
        {
            ShortSword();
            LongtSword();
            Halberd();
            ShortBow();
            LongBow();
            CrossBow();
        }

        private static int GetId()
        {
            return WeaponList.Count() + 1;
        }

        private static void ShortSword()
        {
            var shortSword = new Weapon(GetId(), "Short Sword", 0, 8, 50, $"{GetFolderPath.GetWeaponFolderPath()}\\ShortSword.jpg");
            WeaponList.Add(shortSword);
        }
        private static void LongtSword()
        {
            var longtSword = new Weapon(GetId(), "Long sword", 45, 16, 50, $"{GetFolderPath.GetWeaponFolderPath()}\\LongSword.jpg");
            WeaponList.Add(longtSword);
        }
        private static void Halberd()
        {
            var alebard = new Weapon(GetId(), "Alebard", 52, 24, 75, $"{GetFolderPath.GetWeaponFolderPath()}\\Alebard.jpg");
            WeaponList.Add(alebard);
        }
        private static void CrossBow()
        {
            var crossBow = new Weapon(GetId(), "CrossBow", 98, 35, 58, $"{GetFolderPath.GetWeaponFolderPath()}\\CrossBow.jpg");
            WeaponList.Add(crossBow);
        }
        private static void LongBow()
        {
            var longBow = new Weapon(GetId(), "LongBow", 70, 30, 60, $"{GetFolderPath.GetWeaponFolderPath()}\\LongBow.jpg");
            WeaponList.Add(longBow);
        }
        private static void ShortBow()
        {
            var shortBow = new Weapon(GetId(), "ShortBow", 64, 30, 75, $"{GetFolderPath.GetWeaponFolderPath()}\\ShortBow.png");
            WeaponList.Add(shortBow);
        }
    }
}
