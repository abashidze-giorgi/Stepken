using Domain.Inventory.Shield;
using Domain.Inventory.Weapon;
using Domain.Model.HitPointModel;
using Domain.Models;
using System.Security.Cryptography.X509Certificates;

namespace Domain.Service
{
    public class CreateAmmunition
    {
        public  void Create()
        {
            CreateWeapon();
            CreateArmor();
            CreateShield();
        }
        #region Weapon Create
        private  void CreateWeapon()
        {
            ShortSword();
            LongtSword();
            Halberd();
            ShortBow();
            LongBow();
            CrossBow();
        }
        
        private  void ShortSword()
        {
            var shortSword = new Weapon(GetId(GameList.WeaponList), "Short Sword", 0, 8, 50, $"{GetFolderPath.GetWeaponFolderPath()}\\ShortSword.jpg");
            GameList.WeaponList.Add(shortSword);
        }
        private  void LongtSword()
        {
            var longtSword = new Weapon(GetId(GameList.WeaponList), "Long sword", 45, 16, 50, $"{GetFolderPath.GetWeaponFolderPath()}\\LongSword.jpg");
            GameList.WeaponList.Add(longtSword);
        }
        private  void Halberd()
        {
            var alebard = new Weapon(GetId(GameList.WeaponList), "Alebard", 52, 24, 75, $"{GetFolderPath.GetWeaponFolderPath()}\\Alebard.jpg");
            GameList.WeaponList.Add(alebard);
        }
        private  void CrossBow()
        {
            var crossBow = new Weapon(GetId(GameList.WeaponList), "CrossBow", 98, 35, 58, $"{GetFolderPath.GetWeaponFolderPath()}\\CrossBow.jpg");
            GameList.WeaponList.Add(crossBow);
        }
        private  void LongBow()
        {
            var longBow = new Weapon(GetId(GameList.WeaponList), "LongBow", 70, 30, 60, $"{GetFolderPath.GetWeaponFolderPath()}\\LongBow.jpg");
            GameList.WeaponList.Add(longBow);
        }
        private  void ShortBow()
        {
            var shortBow = new Weapon(GetId(GameList.WeaponList), "ShortBow", 64, 30, 75, $"{GetFolderPath.GetWeaponFolderPath()}\\ShortBow.png");
            GameList.WeaponList.Add(shortBow);
        }
        #endregion

        #region Armor Create
        private void CreateArmor()
        {

        }
        #endregion

        #region Shield Create
        private void CreateShield()
        {
            HeadShield();
            BodyShield();
            LegShield();
            HeadBodyShield();
            LegBodyShield();
        }

        private void BodyShield()
        {
            var bodySHield = new Shield(
                GetId(GameList.ShieldList), "Body shield", 0, null, 10, 80, 10, new List<ZoneModel>()
                );
            bodySHield.Zone.Add(ZoneModel.Body);
            GameList.ShieldList.Add(bodySHield);
        }

        private void HeadShield()
        {
            var headShield = new Shield(
                GetId(GameList.ShieldList), "Head shield", 0, null, 10, 80, 10, new List<ZoneModel>()
                );
            headShield.Zone.Add(ZoneModel.Head);
            GameList.ShieldList.Add(headShield);
        }

        private void LegShield()
        {
            var legShield = new Shield(
                GetId(GameList.ShieldList), "Leg shield", 0, null, 10, 80, 10, new List<ZoneModel>()
                );
            legShield.Zone.Add(ZoneModel.Leg);
            GameList.ShieldList.Add(legShield);
        }

        private void HeadBodyShield()
        {
            var headBodyShield = new Shield(
                GetId(GameList.ShieldList), "Head-Body shield", 0, null, 10, 80, 10, new List<ZoneModel>()
                );
            headBodyShield.Zone.Add(ZoneModel.Head);
            headBodyShield.Zone.Add(ZoneModel.Body);

            GameList.ShieldList.Add(headBodyShield);
        }

        private void LegBodyShield()
        {
            var legBodyShield = new Shield(
                GetId(GameList.ShieldList), "Leg-Body shield", 0, null, 10, 80, 10, new List<ZoneModel>()
                );
            legBodyShield.Zone.Add(ZoneModel.Body);
            legBodyShield.Zone.Add(ZoneModel.Leg);

            GameList.ShieldList.Add(legBodyShield);
        }
        #endregion

        private int GetId<T> (List<T> list)
        {
            return list.Count() + 1;
        }
    }
}
