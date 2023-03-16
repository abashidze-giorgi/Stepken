using Domain.Models;
using Domain.Inventory.Weapons;

namespace Domain.Service
{
    public static class CreateWeaponList
    {
        public static List<WeaponModel> WeaponFullList { get; set; } =  new List<WeaponModel>();
        public static List<ArmorModel> ArmorFullList { get; set; } = new List<ArmorModel> { };
        public static List<ShieldModel> ShieldFullList { get; set; } = new List<ShieldModel> { };
        public static void CreateWeapon()
        {

            WeaponFullList.Add(ShortSword());
            WeaponFullList.Add(LongtSword());
            WeaponFullList.Add(Halberd());
            WeaponFullList.Add(ShortBow());
            WeaponFullList.Add(LongBow());
            WeaponFullList.Add(CrossBow());
        }
        private static ShortSword ShortSword()
        {
            var shortSword = new ShortSword
            {
                Fault = 50,
                AttackPower = 8,
                Id = 1,
                Name = "Short Sword",
                Price = 0,
                ImageAddress = $"{GetFolderPath.GetWeaponFolderPath()}\\ShortSword.jpg"
            };
            return shortSword;
        }
        private static LongSword LongtSword()
        {
            var longtSword = new LongSword
            {
                Fault = 50,
                AttackPower = 16,
                Id = 2,
                Name = "Long Sword",
                Price = 45,
                ImageAddress = $"{GetFolderPath.GetWeaponFolderPath()}\\LongSword.jpg"
            };
            return longtSword;
        }
        private static Alebard Halberd()
        {
            var alebard = new Alebard
            {
                Fault = 75,
                AttackPower = 24,
                Id = 3,
                Name = "Alebard",
                Price = 52,
                ImageAddress = $"{GetFolderPath.GetWeaponFolderPath()}\\Alebard.jpg"
            };
            return alebard;
        }
        private static CrossBow CrossBow()
        {
            var crossBow = new CrossBow
            {
                Fault = 58,
                AttackPower = 35,
                Id = 6,
                Name = "CrossBow",
                Price = 98,
                ImageAddress = $"{GetFolderPath.GetWeaponFolderPath()}\\CrossBow.jpg"
            };
            return crossBow;
        }
        private static LongBow LongBow()
        {
            var longBow = new LongBow
            {
                Fault = 60,
                AttackPower = 30,
                Id = 5,
                Name = "LongBow",
                Price = 70,
                ImageAddress = $"{GetFolderPath.GetWeaponFolderPath()}\\LongBow.jpg"
            };
            return longBow;
        }
        private static ShortBow ShortBow()
        {
            var shortBow = new ShortBow
            {
                Fault = 75,
                AttackPower = 30,
                Id = 4,
                Name = "ShortBow",
                Price = 64,
                ImageAddress = $"{GetFolderPath.GetWeaponFolderPath()}\\ShortBow.png"
            };
            return shortBow;
        }
    }
}
