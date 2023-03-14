using Domain.Interface;
using Domain.Inventory.Weapons;
using Domain.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public static class CreateAllEquipments
    {
        public static List<AmmunitionModel> AmmunitionGlobalList = new List<AmmunitionModel>();

        public static void CreateWeapons()
        {

            AmmunitionGlobalList.Add(ShortSword());
            AmmunitionGlobalList.Add(LongtSword());
            AmmunitionGlobalList.Add(Halberd());
            AmmunitionGlobalList.Add(CrossBow());
            AmmunitionGlobalList.Add(LongBow());
            AmmunitionGlobalList.Add(ShortBow());
        }
        private static ShortSword ShortSword()
        {
            var shortSword = new ShortSword
            {
                Accuracy = 0,
                AttackPower = 0,
                Id = 0,
                Name = "Short Sword",
                Price = 0,
                ImageAddress = @"C:\Users\GFavaz\source\repos\Stepken\Domain\Lib\Image\WeaponImage\ShortSword.jpg"
            };
            return shortSword;
        }
        private static LongSword LongtSword()
        {
            var longtSword = new LongSword
            {
                Accuracy = 0,
                AttackPower = 0,
                Id = 0,
                Name = "Long Sword",
                Price = 0,
                ImageAddress = @"C:\Users\GFavaz\source\repos\Stepken\Domain\Lib\Image\WeaponImage\LongSword.jpg"
            };
            return longtSword;
        }
        private static Alebard Halberd()
        {
            var alebard = new Alebard
            {
                Accuracy = 0,
                AttackPower = 0,
                Id = 0,
                Name = "Alebard",
                Price = 0,
                ImageAddress = @"C:\Users\GFavaz\source\repos\Stepken\Domain\Lib\Image\WeaponImage\Alebard.jpg"
            };
            return alebard;
        }
        private static CrossBow CrossBow()
        {
            var crossBow = new CrossBow
            {
                Accuracy = 0,
                AttackPower = 0,
                Id = 0,
                Name = "CrossBow",
                Price = 0,
                ImageAddress = @"C:\Users\GFavaz\source\repos\Stepken\Domain\Lib\Image\WeaponImage\CrossBow.jpg"
            };
            return crossBow;
        }
        private static LongBow LongBow()
        {
            var longBow = new LongBow
            {
                Accuracy = 0,
                AttackPower = 0,
                Id = 0,
                Name = "LongBow",
                Price = 0,
                ImageAddress = @"C:\Users\GFavaz\source\repos\Stepken\Domain\Lib\Image\WeaponImage\LongBow.jpg"
            };
            return longBow;
        }
        private static ShortBow ShortBow()
        {
            var shortBow = new ShortBow
            {
                Accuracy = 0,
                AttackPower = 0,
                Id = 0,
                Name = "ShortBow",
                Price = 0,
                ImageAddress = @"C:\Users\GFavaz\source\repos\Stepken\Domain\Lib\Image\WeaponImage\ShortBow.png"
            };
            return shortBow;
        }
    }
}
