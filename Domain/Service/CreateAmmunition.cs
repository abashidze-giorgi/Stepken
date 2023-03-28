using Domain.Inventory.Shield;
using Domain.Inventory.Weapon;
using Domain.Model.HitPointModel;
using Domain.Models;
using System.Security.Cryptography.X509Certificates;

namespace Domain.Service
{
    public class CreateAmmunition
    {
        #region Weapon Create

        public static AmmunitionModel CreateWeapon(int id)
        {
            switch (id)
            {
                case 1:
                    return ShortSword();
                case 2:
                    return LongtSword();
                case 3:
                    return Halberd();
                case 4:
                    return ShortBow();
                case 5:
                    return LongBow();
                case 6:
                    return CrossBow();
            }
            return null;
        }
        public static AmmunitionModel ShortSword()
        {
            var shortSword = new Weapon(1, "Short Sword", 0, 8, 50, $"{GetFolderPath.GetWeaponFolderPath()}\\ShortSword.jpg");
            return shortSword;
        }
        public static AmmunitionModel LongtSword()
        {
            var longtSword = new Weapon(2, "Long sword", 45, 16, 50, $"{GetFolderPath.GetWeaponFolderPath()}\\LongSword.jpg");
            return longtSword;
        }
        public static AmmunitionModel Halberd()
        {
            var alebard = new Weapon(3, "Alebard", 52, 24, 75, $"{GetFolderPath.GetWeaponFolderPath()}\\Alebard.jpg");
            return alebard;
        }
        public static AmmunitionModel ShortBow()
        {
            var shortBow = new Weapon(4, "ShortBow", 64, 30, 75, $"{GetFolderPath.GetWeaponFolderPath()}\\ShortBow.png");
            return shortBow;
        }
        public static AmmunitionModel LongBow()
        {
            var longBow = new Weapon(5, "LongBow", 70, 30, 60, $"{GetFolderPath.GetWeaponFolderPath()}\\LongBow.jpg");
            return longBow;
        }
        public static AmmunitionModel CrossBow()
        {
            var crossBow = new Weapon(6, "CrossBow", 98, 35, 58, $"{GetFolderPath.GetWeaponFolderPath()}\\CrossBow.jpg");
            return crossBow;
        }
        #endregion

        #region Armor Create
        private void CreateArmor()
        {

        }
        #endregion

        #region Shield Create
        public static AmmunitionModel CreateShield(int id)
        {
            switch (id)
            {
                case 1:
                    return HeadShield();
                case 2:
                    return BodyShield();
                case 3:
                    return LegShield();
                case 4:
                    return HeadBodyShield();
                case 5:
                    return LegBodyShield();
            }
            return null;
        }

        public static AmmunitionModel BodyShield()
        {
            var bodySHield = new Shield(
                1, "Body shield", 0, 
                $"{GetFolderPath.GetShieldFolderPath()}\\BodyShield.jpg", 150, 80, 10, new List<ZoneModel>()
                );
            bodySHield.Zone.Add(ZoneModel.Body);
            return bodySHield;
        }

        public static AmmunitionModel HeadShield()
        {
            var headShield = new Shield(
                2, "Head shield", 0, 
                $"{GetFolderPath.GetShieldFolderPath()}\\BodyShield.jpg", 500, 80, 10, new List<ZoneModel>()
                );
            headShield.Zone.Add(ZoneModel.Head);
            return headShield;
        }

        public static AmmunitionModel LegShield()
        {
            var legShield = new Shield(
                3, "Leg shield", 0, 
                $"{GetFolderPath.GetShieldFolderPath()}\\BodyShield.jpg", 500, 80, 10, new List<ZoneModel>()
                );
            legShield.Zone.Add(ZoneModel.Leg);
            return legShield;
        }

        public static AmmunitionModel HeadBodyShield()
        {
            var headBodyShield = new Shield(
                4, "Head-Body shield", 0, 
                $"{GetFolderPath.GetShieldFolderPath()}\\BodyShield.jpg", 450, 80, 10, new List<ZoneModel>()
                );
            headBodyShield.Zone.Add(ZoneModel.Head);
            headBodyShield.Zone.Add(ZoneModel.Body);

            return headBodyShield;
        }

        public static AmmunitionModel LegBodyShield()
        {
            var legBodyShield = new Shield(
                5, "Leg-Body shield", 0, 
                $"{GetFolderPath.GetShieldFolderPath()}\\BodyShield.jpg", 10000, 80, 10, new List<ZoneModel>()
                );
            legBodyShield.Zone.Add(ZoneModel.Body);
            legBodyShield.Zone.Add(ZoneModel.Leg);

            return legBodyShield;
        }
        #endregion

    }
}
